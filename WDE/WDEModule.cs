using CapitalGroup.MVPVM;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WDE
{
    public class WDEModule : ModuleBase<WDEPresenter>, IModule
    {
        public WDEModule(IUnityContainer container) : base(container)
        {
            
        }

    }
}
