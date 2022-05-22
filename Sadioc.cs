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
    public partial class Sadioc : Form
    {
        DataTable grid;
        public Sadioc()
        {
            InitializeComponent();
        }
        private void grid_populate()
        {
            SqlConnection veza1 = Konekcija.Povezivanje();
            //SqlDataAdapter adapter = new SqlDataAdapter("select biljka.id as id, str(pozicija.kord1) + ' , ' + str(pozicija.kord2) as naziv, osuncanost as ucenik from biljka join pozicija on biljka.pozicija=pozicija.id" , veza1);
            grid = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from sadioc", veza1);
            adapter.Fill(grid);

            grid1.DataSource = grid;
            grid1.AllowUserToAddRows = false;
            grid1.Columns["ime"].Visible = true;
        }

        private void Sadioc_Load(object sender, EventArgs e)
        {

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("delete from sadioc ");
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("insert into sadioc(ime, zanimanje, pass) values ('");
            naredba.Append(txt_ime.Text.ToString() + "','");
            naredba.Append(txt_zanimanje.Text.ToString() + "','");
            naredba.Append(txt_pass.Text.ToString() + "')");
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

        private void btn_prikaz_Click(object sender, EventArgs e)
        {
            grid_populate();
        }
    }
}
