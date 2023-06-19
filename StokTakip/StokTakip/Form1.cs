using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Form1 : Form
    {

        SqlConnection cnn = new SqlConnection("Data Source=DIMEC-DESKTOP;Initial Catalog=StokTakip;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lwListeleme.Columns.Add("Urun ID", 50);
            lwListeleme.Columns.Add("Urun Adi", 100);
            lwListeleme.Columns.Add("Birim Fiyat", 100);
            lwListeleme.Columns.Add("Tarih", 120);
            lwListeleme.Columns.Add("Kategori Adı", 110);
            lwListeleme.Columns.Add("Market Adı", 110);

            cbDoldur();
            //Goster();

        }

        public void cbDoldur()
        {

            //Kategori
            List<KeyValuePair<int, string>> dataKategori = new List<KeyValuePair<int, string>>();
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Kategoriler";
            SqlDataReader drKategori = cmd.ExecuteReader();
            while (drKategori.Read())
            {
                dataKategori.Add(new KeyValuePair<int, string>(Convert.ToInt32(drKategori[0]), drKategori[1].ToString()));
                //cbKategori.Items.Add(drKategori[1].ToString());
            }
            cbKategori.DataSource = new BindingSource(dataKategori, null);
            cbKategori.DisplayMember = "Value";
            cbKategori.ValueMember = "Key";
            cnn.Close();
            //dataKategori.Close();


            //Marketler
            List<KeyValuePair<int, string>> dataMarket = new List<KeyValuePair<int, string>>();
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Marketler";
            SqlDataReader drMarketler = cmd.ExecuteReader();
            while (drMarketler.Read())
            {
                dataMarket.Add(new KeyValuePair<int, string>(Convert.ToInt32(drMarketler[0]), drMarketler[1].ToString()));
                //cbMarketAdi.Items.Add(drMarketler[1].ToString());
            }
            cbMarketAdi.DataSource = new BindingSource(dataMarket, null);
            cbMarketAdi.DisplayMember = "Value";
            cbMarketAdi.ValueMember = "Key";
            cnn.Close();



            //KategoriListeleme
            cbKategoriListele.Items.Add("Boş Değer");
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Kategoriler";
            SqlDataReader drKategoriListeleme = cmd.ExecuteReader();
            while (drKategoriListeleme.Read())
            {
                cbKategoriListele.Items.Add(drKategoriListeleme[1].ToString());
            }
            cnn.Close();



            //MarketlerListeleme
            cbMarketListeleme.Items.Add("Boş Değer");
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Marketler";
            SqlDataReader drMarketListeleme = cmd.ExecuteReader();
            while (drMarketListeleme.Read())
            {
                cbMarketListeleme.Items.Add(drMarketListeleme[1].ToString());
            }
            cnn.Close();



        }

        public void Goster()
        {
            lwListeleme.Items.Clear();
            if (cbMarketListeleme.SelectedIndex == -1 || cbMarketListeleme.SelectedIndex == 0)
            {
                sp_KategoriGoreUrunListeleme();
            }
            else if (cbKategoriListele.SelectedIndex == -1 || cbKategoriListele.SelectedIndex == 0)
            {
                sp_MarketGoreUrunListeleme();
            }
            else
            {
                sp_MarketveKategoriGoreUrunListeleme();
            }

            if (cbKategoriListele.SelectedIndex == -1 || cbKategoriListele.SelectedIndex == 0)
            {
                sp_MarketGoreUrunListeleme();
            }
            else if (cbMarketListeleme.SelectedIndex == -1 || cbMarketListeleme.SelectedIndex == 0)
            {
                sp_KategoriGoreUrunListeleme();
            }
            else
            {
                sp_MarketveKategoriGoreUrunListeleme();
            }

        }


        public void sp_KategoriGoreUrunListeleme()
        {
            cnn.Open();

            cmd = cnn.CreateCommand();
            cmd.CommandText = "sp_KategoriGoreUrunListeleme";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KategoriID", cbKategoriListele.SelectedIndex);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["UrunID"].ToString());
                item.SubItems.Add(dr["UrunAdi"].ToString());
                item.SubItems.Add(dr["BirimFiyat"].ToString());
                item.SubItems.Add(dr["Tarih"].ToString());
                item.SubItems.Add(dr["KategoriAdi"].ToString());
                item.SubItems.Add(dr["MarketAdi"].ToString());

                lwListeleme.Items.Add(item);
            }
            cnn.Close();
        }

        public void sp_MarketveKategoriGoreUrunListeleme()
        {
            cnn.Open();

            cmd = cnn.CreateCommand();
            cmd.CommandText = "sp_MarketveKategoriGoreUrunListeleme";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KategoriID", cbKategoriListele.SelectedIndex);
            cmd.Parameters.AddWithValue("@MarketID", cbMarketListeleme.SelectedIndex);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["UrunID"].ToString());
                item.SubItems.Add(dr["UrunAdi"].ToString());
                item.SubItems.Add(dr["BirimFiyat"].ToString());
                item.SubItems.Add(dr["Tarih"].ToString());
                item.SubItems.Add(dr["KategoriAdi"].ToString());
                item.SubItems.Add(dr["MarketAdi"].ToString());

                lwListeleme.Items.Add(item);
            }
            cnn.Close();
        }

        public void sp_MarketGoreUrunListeleme()
        {
            cnn.Open();

            cmd = cnn.CreateCommand();
            cmd.CommandText = "sp_MarketGoreUrunListeleme";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MarketID", cbMarketListeleme.SelectedIndex);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["UrunID"].ToString());
                item.SubItems.Add(dr["UrunAdi"].ToString());
                item.SubItems.Add(dr["BirimFiyat"].ToString());
                item.SubItems.Add(dr["Tarih"].ToString());
                item.SubItems.Add(dr["KategoriAdi"].ToString());
                item.SubItems.Add(dr["MarketAdi"].ToString());

                lwListeleme.Items.Add(item);
            }
            cnn.Close();
        }

        private void cbKategoriListele_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lwListeleme.Items.Clear();
            if(cbMarketListeleme.SelectedIndex== -1 || cbMarketListeleme.SelectedIndex==0)
            {
                sp_KategoriGoreUrunListeleme();
            }
            else if(cbKategoriListele.SelectedIndex == -1 || cbKategoriListele.SelectedIndex == 0)
            {
                sp_MarketGoreUrunListeleme();
            }
            else
            {
                sp_MarketveKategoriGoreUrunListeleme();
            }


            

            
        }
        private void cbMarketListeleme_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lwListeleme.Items.Clear();
            if (cbKategoriListele.SelectedIndex == -1 || cbKategoriListele.SelectedIndex == 0)
            {
                sp_MarketGoreUrunListeleme();
            }
            else if (cbMarketListeleme.SelectedIndex == -1 || cbMarketListeleme.SelectedIndex == 0)
            {
                sp_KategoriGoreUrunListeleme();
            }
            else
            {
                sp_MarketveKategoriGoreUrunListeleme();
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectedPairKategori = (KeyValuePair<int, string>)cbKategori.SelectedItem;
            KeyValuePair<int, string> selectedPairMarket = (KeyValuePair<int, string>)cbMarketAdi.SelectedItem;
            cnn.Open();

            cmd = cnn.CreateCommand();
            cmd.CommandText = "sp_UrunlerINSERT";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KategoriID", selectedPairKategori.Key);
            cmd.Parameters.AddWithValue("@MarketID", selectedPairMarket.Key);
            cmd.Parameters.AddWithValue("@UrunAdi", tbUrunAdi.Text);
            cmd.Parameters.AddWithValue("@BirimFiyat", tbBirimFiyat.Text);
            cmd.Parameters.AddWithValue("@Tarih", dtTarih.Value);

            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectedPairKategori = (KeyValuePair<int, string>)cbKategori.SelectedItem;
            KeyValuePair<int, string> selectedPairMarket = (KeyValuePair<int, string>)cbMarketAdi.SelectedItem;
            cnn.Open();
            
            cmd = cnn.CreateCommand();
            cmd.CommandText = "sp_UrunlerUPDATE";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunID", GuncellemeID);
            cmd.Parameters.AddWithValue("@UrunAdi", tbUrunAdi.Text);
            cmd.Parameters.AddWithValue("@BirimFiyat", tbBirimFiyat.Text);
            cmd.Parameters.AddWithValue("@Tarih", dtTarih.Value);
            cmd.Parameters.AddWithValue("@KategoriID", selectedPairKategori.Key);
            cmd.Parameters.AddWithValue("@MarketID", selectedPairMarket.Key);

            cmd.ExecuteNonQuery();
            cnn.Close();
            //Goster();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lwListeleme.SelectedItems)
            {
                int seciliindex = Convert.ToInt32(eachItem.SubItems[0].Text);
                cnn.Open();

                cmd = cnn.CreateCommand();
                cmd.CommandText = "sp_UrunlerDELETE";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UrunID", seciliindex);

                cmd.ExecuteNonQuery();
                cnn.Close();
                

                lwListeleme.Items.Remove(eachItem);
            }
        }

        int GuncellemeID;
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            

            foreach (ListViewItem eachItem in lwListeleme.SelectedItems)
            {
                GuncellemeID=Convert.ToInt32(eachItem.SubItems[0].Text);
                cnn.Open();
                
                cmd = cnn.CreateCommand();
                cmd.CommandText = "sp_UrunGuncelleKategoriMarketID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@UrunID", eachItem.SubItems[0].Text);

                SqlDataReader drUrunGuncelle = cmd.ExecuteReader();
                while (drUrunGuncelle.Read())
                {
                    cbKategori.SelectedIndex = Convert.ToInt32(drUrunGuncelle[0])-1;
                    cbMarketAdi.SelectedIndex = Convert.ToInt32(drUrunGuncelle[1])-1;
                }
                cnn.Close();

                tbUrunAdi.Text = eachItem.SubItems[1].Text;
                tbBirimFiyat.Text = eachItem.SubItems[2].Text;
                dtTarih.Value = Convert.ToDateTime(eachItem.SubItems[3].Text);




                // urun ıd sinden kategori ve market ıd si al


            }
        }
    }
}
