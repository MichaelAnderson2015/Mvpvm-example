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


namespace Module1
{
    public class ViewModule1ViewModel : BindableBase
    {
        private string _title = "Module1 AREA";

        public ICommand SubmitCommand { get;  set; }

        private IEventAggregator eventAggregator;
        private string _caseID;
        public ViewModule1ViewModel(IEventAggregator eventAggregator)
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
            var module1EventData = new EventData("Module1",new EventData(CaseID));

            eventAggregator.GetEvent<SubmitButtonEvent>().Publish(module1EventData);
        }
    }
}
