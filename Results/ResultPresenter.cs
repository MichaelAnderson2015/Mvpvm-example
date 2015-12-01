using MVPVM;
using Events;
using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;
using vm.Aspects.Diagnostics;

namespace Results
{
    public class ResultPresenter : BasePresenter<ViewResults, ViewResultsViewModel>
    {
        public ResultPresenter() :
            base("Results")
        {
           
           
        }

        protected override void OnEventAggregatorSet()
        {
            base.EventAggregator.GetEvent<UpdateEvent>().Subscribe(ResultsReceived);
            

        }

        protected override void OnViewModelSet()
        {
            base.ViewModel.ResultsText = "Test on startup";
           
        }


        private void ResultsReceived(Object data)
        {
            var writer = new StringWriter();
            var dumper = new ObjectTextDumper(writer);

            dumper.Dump(data);
       
            Paragraph paragraph = new Paragraph();
            Bold recv = new Bold();
            var converter = new System.Windows.Media.BrushConverter();
            recv.Foreground = (Brush)converter.ConvertFromString("#FF8ACCCF");
            recv.FontSize = 14.0;
            recv.Inlines.Add("Event Received :" + Environment.NewLine);
            paragraph.Inlines.Add(recv);

            Span text = new Span();
            text.Foreground = (Brush)converter.ConvertFromString("#FFDFDFBF");
            text.Inlines.Add(writer.GetStringBuilder().ToString());
            paragraph.Inlines.Add(text);

            View.console.Document.Blocks.Add(paragraph);
            View.scroller.ScrollToBottom();
        }
    }
}
