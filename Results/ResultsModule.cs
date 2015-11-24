using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;
using CapitalGroup.MVPVM;

namespace Results
{
    public class ResultsModule : ModuleBase<ResultPresenter>, IModule
    {
 
        public ResultsModule(IUnityContainer container) : base(container)
        {
            
        }


    }
}
