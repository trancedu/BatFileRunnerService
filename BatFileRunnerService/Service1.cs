using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace BatFileRunnerService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "C:\\Users\\29468\\Downloads\\writeTime.bat",
                    //FileName = "C:\\Users\\Trance\\Downloads\\TaskTest\\logTime.bat",
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                Process batchProcess = new Process
                {
                    StartInfo = processInfo
                };
                batchProcess.Start();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        protected override void OnStop()
        {
            // Code executed on service stop
        }

    }
}
