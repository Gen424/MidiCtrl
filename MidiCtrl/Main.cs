using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sanford.Multimedia.Midi;
//using Midi;

namespace MidiCtrl {
    public partial class Main : Form {

        //private ReadOnlyCollection<InputDevice> InputDevices => InputDevice.InstalledDevices;

        //private InputDevice _ActiveDevice = default;
        //public InputDevice ActiveDevice{ 
        //    get => _ActiveDevice = _ActiveDevice ?? InputDevices.FirstOrDefault();
        //    private set => _ActiveDevice = value;
        //}

        public Main() {
            InitializeComponent();
            UpdateInputDevices();
            //Midi.InputDevice.InstalledDevices.First().
            //UpdateOutputDevices();
        }

        private void UpdateInputDevices(){

            //ToolStripItem[] ToolStripItems = InputDevices
            //    .Select( x => new ToolStripMenuItem(x) )
            //    .ToArray();

            //Midi.Control.

            //rotariesToolStripMenuItem.DropDownItems.Clear();
            //rotariesToolStripMenuItem.DropDownItems.AddRange( ToolStripItems );

            //if(ToolStripItems.Length > 0){
            //    foreach(ToolStripItem Item in BindSettings){
            //        Item.Click += (x,y) => Item.Select();
            //    }
            //}else{
            //    BindSettings.ToList().ForEach(x => x.Enabled = false);
            //}

        }

        //private void UpdateOutputDevices(){

        //    OutputDevices = OutputDevice.InstalledDevices.Select( x => new ToolStripMenuItem(x.Name) ).ToArray();

        //    outputToolStripMenuItem.DropDownItems.Clear();
        //    outputToolStripMenuItem.DropDownItems.AddRange( OutputDevices );

        //}

        private void quitToolStripMenuItem_Click( object sender, EventArgs e ) => Application.Exit();
        private void buttonsToolStripMenuItem_Click( object sender, EventArgs e ) => Buttons.Instance.ShowDialog();
        private void inputToolStripMenuItem_Click( object sender, EventArgs e ) => Rotaries.Instance.ShowDialog();
        private void inputToolStripMenuItem2_DropDownOpening( object sender, EventArgs e ) => UpdateInputDevices();

        private void saveSettingsToolStripMenuItem_Click( object sender, EventArgs e ) {

        }

        private void refreshToolStripMenuItem_Click( object sender, EventArgs e ){
            inputDeviceToolStripMenuItem.DropDownItems.Clear();
            inputDeviceToolStripMenuItem.DropDownItems.AddRange( MidiInterface.DeviceList().AsToolstripItems().ToArray() );
            if( inputDeviceToolStripMenuItem.Enabled == false ) inputDeviceToolStripMenuItem.Enabled = true;
        }

        private void editToolStripMenuItem_Click( object sender, EventArgs e ) {
            if( inputDeviceToolStripMenuItem.DropDownItems.Cast<ToolStripMenuItem>().Any( x => x.Checked == true) ){
                buttonsToolStripMenuItem.Enabled = true;
                rotariesToolStripMenuItem.Enabled = true;
            }
        }
        //private void outputToolStripMenuItem_DropDownOpening( object sender, EventArgs e ) => UpdateOutputDevices();
    }
}
