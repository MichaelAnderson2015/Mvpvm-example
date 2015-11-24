using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapitalGroup.MVPVM;

namespace AWD
{
    public class AWDModule : ModuleBase<AWDPresenter>, IModule
    {
        public AWDModule(IUnityContainer container)
            : base(container)
        {

        }

    }
}
