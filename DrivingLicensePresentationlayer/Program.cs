using DVLD_EventsLogs_;
using DVLDPresentationLayer.GeneralClasses;
using DVLDPresentationLayer.MainScreens;
using DVLDPresentationLayer.People;
using DVLDPresentationLayer.PeopleScreens;

namespace DrivingLicenseMangement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            clsEventLogs.CreateEventLogSource();
            ApplicationConfiguration.Initialize();
            Application.Run(new frmUserLoginScreen());
        }
    }
}