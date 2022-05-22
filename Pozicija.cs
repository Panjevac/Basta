using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Basta
{
    public partial class Pozicija : Form
    {
        DataTable grid;

        public Pozicija()
        {
            InitializeComponent();
        }
 
        private void Pozicija_Load(object sender, EventArgs e)
        {
           
        }
        
        
        private void grid_populate()
        {
            SqlConnection veza1 = Konekcija.Povezivanje();
           //SqlDataAdapter adapter = new SqlDataAdapter("select biljka.id as id, str(pozicija.kord1) + ' , ' + str(pozicija.kord2) as naziv, osuncanost as ucenik from biljka join pozicija on biljka.pozicija=pozicija.id" , veza1);
            grid = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, str(pozicija.kord1) + ' , ' + str(pozicija.kord2) as naziv, osuncanost from pozicija", veza1);
            adapter.Fill(grid);

            grid1.DataSource = grid;
            grid1.AllowUserToAddRows = false;
            grid1.Columns["osuncanost"].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid_populate();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("insert into pozicija(kord1, kord2, osuncanost, pret_biljka) values (");
            naredba.Append(txt_k1.Text + ",");
            naredba.Append(txt_k2.Text + ",");
            naredba.Append(txt_os.Text + ",");
            naredba.Append( "1)");
            SqlConnection veza1 = Konekcija.Povezivanje();


            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza1);
            try
            {
                veza1.Open();
                komanda.ExecuteNonQuery();
                veza1.Close();
                grid_populate();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
                throw;
            }
        }

        private void grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ucenik_ocena_id(e.RowIndex);
            }
        }

        private void ucenik_ocena_id(int br_sloga)
        {
            txt_sad.Text = grid.Rows[br_sloga]["id"].ToString();
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("delete from pozicija ");
            naredba.Append(" where id= " + txt_sad.Text);
            SqlConnection veza1 = Konekcija.Povezivanje();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza1);
            try
            {
                veza1.Open();
                komanda.ExecuteNonQuery();
                veza1.Close();
                grid_populate();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
                throw;
            }
        }
    }
}
