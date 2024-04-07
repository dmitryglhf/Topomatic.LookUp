using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Topomatic.LookUp
{
    public class ModulePluginHost : Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator
    {
        protected override Type[] GetTypes()
        {
            return new Type[] { typeof(Module) };
        }
    }
}
