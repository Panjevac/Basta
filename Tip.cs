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
    public partial class Tip : Form
    {
        DataTable grid;

        public Tip()
        {
            InitializeComponent();
        }

        private void Tip_Load(object sender, EventArgs e)
        {

        }
        private void grid_populate()
        {
            SqlConnection veza1 = Konekcija.Povezivanje();
            //SqlDataAdapter adapter = new SqlDataAdapter("select biljka.id as id, str(pozicija.kord1) + ' , ' + str(pozicija.kord2) as naziv, osuncanost as ucenik from biljka join pozicija on biljka.pozicija=pozicija.id" , veza1);
            grid = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, naziv, podnaziv, zivotni_vek from tip", veza1);
            adapter.Fill(grid);

            grid1.DataSource = grid;
            grid1.AllowUserToAddRows = false;
            grid1.Columns["naziv"].Visible = true;
        }

        
        private void btn_add_Click(object sender, EventArgs e)
        {
            
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
            txt_id.Text = grid.Rows[br_sloga]["id"].ToString();
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grid_populate();
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("insert into tip(naziv, podnaziv, zivotni_vek) values ('");
            naredba.Append(txt_vrsta.Text.ToString() + "','");
            naredba.Append(txt_podvrsta.Text.ToString() + "',");
            naredba.Append(txt_vek.Text + ")");
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

        private void btn_del_Click_1(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("delete from tip ");
            naredba.Append(" where id= " + txt_id.Text);
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

