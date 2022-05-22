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
    public partial class Sadnja : Form
    {
        DataTable grid;
        public Sadnja()
        {
            InitializeComponent();
        }
        private void grid_populate()
        {
            SqlConnection veza1 = Konekcija.Povezivanje();
            //SqlDataAdapter adapter = new SqlDataAdapter("select biljka.id as id, str(pozicija.kord1) + ' , ' + str(pozicija.kord2) as naziv, osuncanost as ucenik from biljka join pozicija on biljka.pozicija=pozicija.id" , veza1);
            grid = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select biljka.id, tip.naziv as tip, vreme_radj, sadioc.ime as sadioc, pozicija.osuncanost as osuncanost from biljka join tip on tip=tip.id join sadioc on sadioc=sadioc.id join pozicija on pozicija=pozicija.id", veza1);
            adapter.Fill(grid);

            grid1.DataSource = grid;
            grid1.AllowUserToAddRows = false;
            //grid1.Columns["ime"].Visible = true;
        }

        private void Sadnja_Load(object sender, EventArgs e)
        {
            cmb_sadioc_populate();
            cmb_tip_populate();
            cmb_poz_populate();
        }

        private void cmb_tip_populate()
        {
            //string godina = cmb_godina.SelectedValue.ToString();
            SqlConnection veza1 = Konekcija.Povezivanje();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, naziv from tip", veza1);
            DataTable ucenik = new DataTable();
            adapter.Fill(ucenik);

            cmb_tip.DataSource = ucenik;
            cmb_tip.DisplayMember = "naziv";
            cmb_tip.ValueMember = "id";

        }

        private void cmb_sadioc_populate()
        {
            //string godina = cmb_godina.SelectedValue.ToString();
            SqlConnection veza1 = Konekcija.Povezivanje();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, ime as naziv from sadioc", veza1);
            DataTable ucenik = new DataTable();
            adapter.Fill(ucenik);

            cmb_sadioc.DataSource = ucenik;
            cmb_sadioc.DisplayMember = "naziv";
            cmb_sadioc.ValueMember = "id";

        }

        private void cmb_poz_populate()
        {
            //string godina = cmb_godina.SelectedValue.ToString();
            SqlConnection veza1 = Konekcija.Povezivanje();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, osuncanost as naziv from pozicija", veza1);
            DataTable ucenik = new DataTable();
            adapter.Fill(ucenik);

            cmb_poz.DataSource = ucenik;
            cmb_poz.DisplayMember = "naziv";
            cmb_poz.ValueMember = "id";

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("delete from biljka ");
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
            StringBuilder naredba = new StringBuilder("insert into biljka(tip, vreme_radj, god_sadnje, sadioc, pozicija, mesec_sadnje) values (");
            naredba.Append(cmb_tip.SelectedValue + ",'");
            naredba.Append(txt_vreme.Text.ToString() + "',");
            naredba.Append(txt_god.Text + ",");
            naredba.Append(cmb_sadioc.SelectedValue + ",");
            naredba.Append(cmb_poz.SelectedValue + ",");
            naredba.Append(txt_mesec.Text + ")");
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
