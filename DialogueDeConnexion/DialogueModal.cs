using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueDeConnexion
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();

            this.AcceptButton = btnSeConnecter;
            this.CancelButton = btnQuitter;
        }

        private void zoneSaisieID_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
           
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
           
        }

        private void zoneSaisieID_Validating(object sender, CancelEventArgs e)
        {
            bool result;
            string texteID = zoneSaisieID.Text;
            int indice = zoneSaisieID.Text.Length;
            result = char.IsLetter(texteID[0]);
             
            
            if (zoneSaisieID.Text == string.Empty || zoneSaisieID.Text.Length < 5 || result == false )
            {
                e.Cancel = true;
            }
 
        }

        private void zoneSaisieMDP_Validating(object sender, CancelEventArgs e)
        {
            if (zoneSaisieMDP.Text == string.Empty || zoneSaisieMDP.Text.Length <= 5 || zoneSaisieID.Text != zoneSaisieMDP.Text)
            {
                e.Cancel = true;
            }
            
        }
    }
}
