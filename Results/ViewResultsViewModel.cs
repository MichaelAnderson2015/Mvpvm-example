using Events;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using vm.Aspects.Diagnostics;

namespace Results
{
    class ViewResultsViewModel : BindableBase
    {
        private string _title = "RESULTS AREA";
        private string _resultsText;

        private IEventAggregator eventAggregator;

        public ICommand ClearCommand { get; private set; }

        public string ResultsText
        {
            get { return _resultsText; }
            set { SetProperty(ref _resultsText, value);  }
        }

        public ViewResultsViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            this.ClearCommand = new DelegateCommand<object>(this.OnClear);
        }



        private void OnClear(object obj)
        {
           
            ResultsText = string.Empty;
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

   

    }
}
