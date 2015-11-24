using Prism.Mvvm;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Prism.Commands;
using System.Windows.Input;
using Events;


namespace AWD
{
    public class ViewAWDViewModel : BindableBase
    {
        private string _title = "AWD AREA";

        public ICommand SubmitCommand { get; private set; }

        private IEventAggregator eventAggregator;
        private string _caseID;
        public ViewAWDViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            this.SubmitCommand = new DelegateCommand<object>(this.OnSubmit);
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string CaseID
        {
            get { return _caseID;  }
            set { SetProperty(ref _caseID, value);  }
        }
        private void OnSubmit(object obj)
        {
            var awdEventData = new EventData("AWD",new EventData(CaseID));

            eventAggregator.GetEvent<UpdateEvent>().Publish(awdEventData);
        }
    }
}
