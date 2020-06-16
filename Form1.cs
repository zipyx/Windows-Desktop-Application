using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataApplication.fa_client_profiles' table. You can move, or remove it, as needed.
            this.fa_client_profilesTableAdapter.Fill(this.dataApplication.fa_client_profiles);
            faclientprofilesBindingSource.DataSource = this.dataApplication.fa_client_profiles;

        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13) {
                if (string.IsNullOrEmpty(textSearch.Text))
                {
                    this.fa_client_profilesTableAdapter.Fill(this.dataApplication.fa_client_profiles);
                    faclientprofilesBindingSource.DataSource = this.dataApplication.fa_client_profiles;
                } else
                {
                    var query = from o in this.dataApplication.fa_client_profiles
                                where o.firstname.Contains(textSearch.Text) || o.firstname.Contains(textFirstName.Text) || o.middlename.Contains(textMiddleName.Text) ||
                                o.surname.Contains(textSurname.Text) || o.homeaddress.Contains(texthomeaddress.Text) || o.suburb.Contains(textSuburb.Text) || o.city.Contains(textCity.Text)
                                select o;
                    faclientprofilesBindingSource.DataSource = query.ToList();
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                textFirstName.Focus();
                this.dataApplication.fa_client_profiles.Addfa_client_profilesRow(this.dataApplication.fa_client_profiles.Newfa_client_profilesRow());
                faclientprofilesBindingSource.MoveLast();
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            textFirstName.Focus();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            faclientprofilesBindingSource.ResetBindings(false);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                faclientprofilesBindingSource.EndEdit();
                fa_client_profilesTableAdapter.Update(this.dataApplication.fa_client_profiles);
                panel.Enabled = false;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    faclientprofilesBindingSource.RemoveCurrent();
            }
        }
    }
}
