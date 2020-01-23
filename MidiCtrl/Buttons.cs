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
    public partial class Buttons : Form {

        public static Buttons _Instance;
        public static Buttons Instance{ 
            get => (_Instance == null || _Instance.IsDisposed) ? _Instance = new Buttons() : _Instance;
        }

        private Buttons() {
            InitializeComponent();
        }

        private void Buttons_Load( object sender, EventArgs e ) {

        }
    }
}
