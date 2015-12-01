using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPVM;
using Prism.Commands;
using Events;

namespace Module1
{
    public class Module1Presenter : BasePresenter<ViewModule1, ViewModule1ViewModel>
    {
        public Module1Presenter() :
            base("Module1")
        {
             
        }

  
    }
}
