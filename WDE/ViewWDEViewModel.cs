using Events;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WDE
{
    public class ViewWDEViewModel : BindableBase
    {
        private string _title = "WDE AREA";

        public ICommand SubmitCommand { get; private set; }

        private IEventAggregator eventAggregator;
         public ViewWDEViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            this.SubmitCommand = new DelegateCommand<object>(this.OnSubmit);
        }
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private void OnSubmit(object obj)
        {
            var wdeEventData = this;
            var testData = "Some Garbage";
            var eventData = new EventData("WDE");

            eventAggregator.GetEvent<UpdateEvent>().Publish(wdeEventData);
            eventAggregator.GetEvent<UpdateEvent>().Publish(testData);
            eventAggregator.GetEvent<UpdateEvent>().Publish(eventData);

        }
    }
}
