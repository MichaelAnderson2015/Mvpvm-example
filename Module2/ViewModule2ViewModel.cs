﻿using Events;
using Module2.ModuleEvents;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Module2
{
    public class ViewModule2ViewModel : BindableBase
    {
        private string _title = "Module2 AREA";

        public ICommand SubmitCommand { get; private set; }

        private IEventAggregator eventAggregator;
         public ViewModule2ViewModel(IEventAggregator eventAggregator)
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
            
            var eventData = new EventData("Module2");

            eventAggregator.GetEvent<Module2ButtonPressed>().Publish(eventData);

        }
    }
}
