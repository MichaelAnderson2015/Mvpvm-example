using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalGroup.MVPVM
{
    public class ModuleBase<TPresenter> 
        where TPresenter : IPresenter
    {
        IUnityContainer _container;
        IPresenter _presenter;
        public ModuleBase(IUnityContainer container){
         _container = container;
        }

        public virtual void Initialize()
        {
            _presenter = _container.Resolve<TPresenter>();
            _presenter.Initialize();
        }
    }
}
