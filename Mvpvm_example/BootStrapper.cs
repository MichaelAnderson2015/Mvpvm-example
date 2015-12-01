using Prism.Unity;
using Prism.Modularity;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Module2;
using Module1;
using Results;
using MVPVM;
using BusinessLayer;
using DataAccessLayer;

namespace Mvpvm_example
{
    class BootStrapper: UnityBootstrapper
    {
        private List<Type> moduleTypes = new List<Type>()
        {
            typeof(Module2Module),
            typeof(Module1Module),
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

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            RegisterTypeIfMissing(typeof(IRandomService), typeof(RandomService) , true);
            RegisterTypeIfMissing(typeof(ISimulatedData), typeof(SimulatedData), true);
            
        }


        protected override DependencyObject CreateShell()
        {
            return new MainWindow();
        }

      
    }
}
