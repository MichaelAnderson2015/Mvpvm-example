using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MVPVM
{
    public class BasePresenter<TView,TViewModel> : IPresenter 
        where TView : UserControl
    {
       
       
        TView _view;
        TViewModel _viewModel;
        
        string _region;

        public TView View {
            get { return _view; }
            set { _view = value;
                    OnViewSet();
            }
        }

        public TViewModel ViewModel
        {
            get { return _viewModel; }
            set { _viewModel = value;
                OnViewModelSet();
            }
        }

        protected virtual void OnViewSet()
        {
            ViewModel = (TViewModel)View.DataContext;
        }

       protected virtual void OnViewModelSet()
        {

        }


        IRegionManager _regionManager;
        [Dependency]
        public IRegionManager RegionManager
        {
            get { return _regionManager; }
            set
            {
                _regionManager = value;
                OnRegionManagerSet();
            }
        }

        protected virtual void OnRegionManagerSet()
        {
            _regionManager.RegisterViewWithRegion(_region, GetView);
        }

        IEventAggregator _eventAggregator;
        [Dependency]
        public IEventAggregator EventAggregator
        {
            get { return _eventAggregator; }
            set { 
                _eventAggregator = value;
                OnEventAggregatorSet();
                }
        }

        protected virtual void OnEventAggregatorSet()
        {
            
        }
        public BasePresenter(string region)
        {
            View = (TView)Activator.CreateInstance<TView>();
            _region = region;
        }

        public void Initialize()
        {
           
        }

        private object GetView()
        {
            return _view;
        }
    }
}
