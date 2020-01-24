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
    public partial class Rotaries : Form {

        public static Rotaries _Instance;
        public static Rotaries Instance{ 
            get => (_Instance == null || _Instance.IsDisposed) ? _Instance = new Rotaries() : _Instance;
        }
        private Rotaries() {
            InitializeComponent();
            
        }

        private void button2_Click( object sender, EventArgs e ) {
        }

        private void button1_MouseUp( object sender, MouseEventArgs e ) {
        }

        private void button1_MouseDown( object sender, MouseEventArgs e ) {
            
        }

        private void button2_MouseDown( object sender, MouseEventArgs e ) {
        }
        private void button2_MouseUp( object sender, MouseEventArgs e ) {
        }

        private void Rotaries_FormClosing( object sender, FormClosingEventArgs e ) {
        }
    }
}
