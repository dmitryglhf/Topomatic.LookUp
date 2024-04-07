using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.Controls.Dialogs;

namespace Topomatic.LookUp
{
    partial class Module : Topomatic.ApplicationPlatform.Plugins.PluginInitializator
    {
        [cmd("lookup_cmd")]
        public void LookUpFunction()
        {
            MessageDlg.Show("Hello world+");
        }
    }
}
