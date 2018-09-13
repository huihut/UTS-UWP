using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_UWP.Primary.Models;

namespace UTS_UWP.Primary.ViewModels
{
    public class MainViewModel
    {
        public MainModel mainModel = null;

        MainViewModel()
        {
            mainModel = new MainModel();
        }

    }
}
