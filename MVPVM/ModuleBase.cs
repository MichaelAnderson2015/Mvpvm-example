using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPVM
{
    public class ModuleBase<TPresenter> 
        where TPresenter : IPresenter
    {
        
        IPresenter _presenter;

        private IUnityContainer _Container;
        [Dependency]
        /// <summary>
        /// Get / Set Container 
        /// </summary>
        public IUnityContainer Container
        {
            get { return _Container; }
            set
            {
                _Container = value;

                // Instantiate the main view
                _presenter = value.Resolve<TPresenter>();

               
            }
        }


        public ModuleBase(){
          
        }

        public virtual void Initialize()
        {
            //_presenter = _container.Resolve<TPresenter>();
            _presenter.Initialize();
        }
    }
}
