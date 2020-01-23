using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiCtrl {
    public partial class Main : Form {

        public Main() {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click( object sender, EventArgs e ) {
            Application.Exit();
        }

        private void buttonsToolStripMenuItem_Click( object sender, EventArgs e ) {
            Buttons.Instance.ShowDialog();
        }

        private void inputToolStripMenuItem_Click( object sender, EventArgs e ) {
            Rotaries.Instance.ShowDialog();
        }

    }
}
