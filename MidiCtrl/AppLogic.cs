using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sanford.Multimedia.Midi;

namespace MidiCtrl {
    public static class MidiInterface {

        public static IEnumerable<MidiInCaps> DeviceList(){

            List<MidiInCaps> DeviceInfo = new List<MidiInCaps>();

            for(int i = 0; i < InputDevice.DeviceCount; i++){
                DeviceInfo.Add( InputDevice.GetDeviceCapabilities(i) );
            }

            return DeviceInfo;

        }
        public static IEnumerable<string> AsNameList( this IEnumerable<MidiInCaps> DeviceInfoList ) => DeviceInfoList.Select( x => x.name );
        public static IEnumerable<ToolStripMenuItem> AsToolstripItems( this IEnumerable<MidiInCaps> DeviceInfoList ){
            List<ToolStripMenuItem> Output = DeviceInfoList.Select( x => new ToolStripMenuItem(x.name) ).ToList();
            Output.ForEach(m => m.Click += (s,e) => {
                m.Owner.Items.Cast<ToolStripMenuItem>().ToList().ForEach(x => x.Checked = false);
                m.Checked = true;
            } );
            return Output;
        }
        public static ToolStripMenuItem ActiveItem( this IEnumerable<ToolStripMenuItem> MenuItems ) => MenuItems.FirstOrDefault( x => x.Checked );
    }
}
