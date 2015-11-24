using CapitalGroup.MVPVM;
using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDE
{
    // WDE Presenter class
    public class WDEPresenter : BasePresenter<ViewWDE>
    {
       public WDEPresenter(IUnityContainer container, IRegionManager regionManager, IEventAggregator eventAggregator) :
            base(container, regionManager, eventAggregator, "WDE")
        {
  
        }

    }
}
