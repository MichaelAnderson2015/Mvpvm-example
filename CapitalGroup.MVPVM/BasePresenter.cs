using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalGroup.MVPVM
{
    public class BasePresenter<TView> : IPresenter 
    {
        IRegionManager _regionManager;
        IUnityContainer _container;
        IEventAggregator _eventAggregator;
        TView _view;
        string _region;

        public TView View {
            get { return _view; }
        }

        public IEventAggregator EventAggregator
        {
            get { return _eventAggregator; }
        }
        public BasePresenter(IUnityContainer container, IRegionManager regionManager, IEventAggregator eventAggregator, string region)
        {
            _container = container;
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;
            _view = _container.Resolve<TView>();
            _region = region;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(_region, GetView);
        }

        private object GetView()
        {
            return _view;
        }
    }
}
