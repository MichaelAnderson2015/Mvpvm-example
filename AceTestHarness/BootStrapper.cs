using Prism.Unity;
using Prism.Modularity;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using WDE;
using AWD;
using Results;

namespace AceTestHarness
{
    class BootStrapper: UnityBootstrapper
    {
        private List<Type> moduleTypes = new List<Type>()
        {
            typeof(WDEModule),
            typeof(AWDModule),
            typeof(ResultsModule)
        };

        protected override void ConfigureModuleCatalog()
        {
            ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
            foreach (var moduleType in moduleTypes)
            {
                catalog.AddModule(moduleType);
            }

        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

      
    }
}
