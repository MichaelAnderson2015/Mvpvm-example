using MVPVM;
using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    // Module2 Presenter class
    public class Module2Presenter : BasePresenter<ViewModule2, ViewModule2ViewModel>
    {
       public Module2Presenter() :
            base("Module2")
        {
  
        }

    }
}
