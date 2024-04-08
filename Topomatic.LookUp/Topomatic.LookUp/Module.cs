using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.Cad.View.Hints;
using Topomatic.Controls.Dialogs;
using Topomatic.LookUp.UI;

namespace Topomatic.LookUp
{
    partial class Module : Topomatic.ApplicationPlatform.Plugins.PluginInitializator
    {
        [cmd("lookup_cmd")]
        public void LookUpFunction()
        {
            var cadView = CadView;
            Predicate<object> match = delegate (object obj)
            {
                return true;
            };
            if (cadView != null)
            {
                var selection = cadView.SelectionSet;
                //Предлагаем способ выбора
                string select = "Выбрать по очереди";
                //Функция возвращает выбраный элемент, не помещая его в SelectionSet
                var obj = selection.PickOneObjectAtScreen(match, "Укажите элемент");
                
                MainMenu menu = new MainMenu(obj);
                menu.Show();

            }
        }
    }
}
