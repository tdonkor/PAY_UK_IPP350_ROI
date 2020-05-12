using Acrelec.Library.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PAY_ROI_IPP350.Communicator;

namespace PAY_ROI_IPP350
{
    class Program
    {
        static void Main(string[] args)
        {
            CoreCommunicator coreCommunicator = new CoreCommunicator();

            PayIngenicoIPP350_ROI payIngenicoIPP350_ROI = new PayIngenicoIPP350_ROI(coreCommunicator);

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Log.Info(PayIngenicoIPP350_ROI.PAY_INGENICO_IPP350_ROI_LOG, "Pay Conexflow started.");
        }

    static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        Log.Info(PayIngenicoIPP350_ROI.PAY_INGENICO_IPP350_ROI_LOG, "Unhandled Exception: " + (e.ExceptionObject as Exception).Message);
    }
}
}
