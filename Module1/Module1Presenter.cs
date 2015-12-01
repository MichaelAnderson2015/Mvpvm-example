using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPVM;
using Prism.Commands;
using Events;
using BusinessLayer;

namespace Module1
{
    public class Module1Presenter : BasePresenter<ViewModule1, ViewModule1ViewModel>
    {
        IRandomService _service;
        [Dependency]
        public IRandomService Service
        {
            get { return _service; }
            set { _service = value; }
        }
        public Module1Presenter() :
            base("Module1")
        {
             
        }

        protected override void OnEventAggregatorSet()
        {
            base.OnEventAggregatorSet();
            base.EventAggregator.GetEvent<SubmitButtonEvent>().Subscribe(EventReceived);
        }

        private void EventReceived(object obj)
        {
            var eventData = (EventData)obj;
            var enclosedObj = (EventData)eventData.DataObject;
            var data = _service.GetRandomData(enclosedObj.Source);
            var module1EventData = new EventData("Module1", new EventData(data));

            base.EventAggregator.GetEvent<UpdateEvent>().Publish(module1EventData);
        }

  
    }
}
