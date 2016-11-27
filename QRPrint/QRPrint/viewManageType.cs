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
    public partial class viewManageType : Form
    {
        public viewManageType()
        {
            InitializeComponent();

            List<TypeInter> choices = TypeInter.getAllType();
            this.Cb_parentInter.DataSource = choices;
            this.Cb_parentInter.DisplayMember = "nom_type";
            this.Cb_parentInter.ValueMember = "id_type";
        }

        private void bt_addInter_Click(object sender, EventArgs e)
        {
           if (Cb_parentInter.SelectedValue != null)
            {
                TypeInter.addType(new TypeInter(tb_nameInter.Text, Cb_parentInter.SelectedValue.ToString()));
            }
           else
            {
                TypeInter.addType(new TypeInter(tb_nameInter.Text, Cb_parentInter.Text));
            }
           
        }

        private void bt_deleteInter_Click(object sender, EventArgs e)
        {
            TypeInter.deleteType(Cb_delete.Text);
        }
    }
}
