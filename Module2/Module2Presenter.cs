using MVPVM;
using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2.ModuleEvents;
using Events;

namespace Module2
{
    // Module2 Presenter class
    public class Module2Presenter : BasePresenter<ViewModule2, ViewModule2ViewModel>
    {
       public Module2Presenter() :
            base("Module2")
        {
  
        }

        protected override void OnEventAggregatorSet()
        {
 	        base.OnEventAggregatorSet();
            base.EventAggregator.GetEvent<Module2ButtonPressed>().Subscribe(ButtonPressed);
        }

        private void ButtonPressed(object obj)
        {
            var testData = "Some Garbage";
            var eventData = new EventData("Module2");

            base.EventAggregator.GetEvent<UpdateEvent>().Publish(testData);
            base.EventAggregator.GetEvent<UpdateEvent>().Publish(eventData);
        }


      
    }
}
