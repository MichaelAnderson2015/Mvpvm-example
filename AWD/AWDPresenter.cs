using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapitalGroup.MVPVM;

namespace AWD
{
    public class AWDPresenter : BasePresenter<ViewAWD>
    {
        public AWDPresenter(IUnityContainer container, IRegionManager regionManager, IEventAggregator eventAggregator) :
            base(container, regionManager, eventAggregator, "AWD")
        {
           
        }
    }
}
