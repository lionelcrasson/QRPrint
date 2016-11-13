using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRPrint
{
    public partial class vueNouveauDossier : Form
    {
        public vueNouveauDossier()
        {
            InitializeComponent();
        }


        private void bt_nouveauDossier_Click(object sender, EventArgs e)
        {
            try
            {
                Dossier currentDossier = new Dossier(tb_nomClient.Text, tb_prenomClient.Text, tb_numeroDossier.Text);
                this.Close();
                MessageBox.Show("Nouveau dossier : "+currentDossier.fullPath+" créé");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
