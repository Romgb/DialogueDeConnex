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
    public partial class Invocation : Form
    {
        public Invocation()
        {
            InitializeComponent();
        }

        private void btnAppel_Click(object sender, EventArgs e)
        {
            form1 dialogueModal = new form1();
            DialogResult resultat = dialogueModal.ShowDialog();
            zoneSaisie.Text = DialogResult.ToString();
       
        }

        private void zoneSaisie_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
