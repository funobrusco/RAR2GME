using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace RAR2GME
{
    public partial class Main : ServiceBase
    {
        readonly EventLog eventLog = new EventLog();

        public Main()
        {
            InitializeComponent();
            eventLog.Source = "RAR2GME";
        }

        protected override void OnStart(string[] args)
        {
            eventLog.Log = "OnStart";
        }

        protected override void OnStop()
        {
            eventLog.Log = "OnStop";
        }
    }
}
