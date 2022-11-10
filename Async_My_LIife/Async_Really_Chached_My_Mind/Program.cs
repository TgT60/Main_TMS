using System;
using System.Threading;

namespace Async_Really_Chached_My_Mind
{
    class Program
    {
        static void Main(string[] args)
        {
            var асtionsWhitPc = new PC();
            асtionsWhitPc.SitOnPc();

            var makeApp = new App();
            makeApp.WorkWithApp();

            var makePotion = new Pill();
            makePotion.DrinkPill();

            var downloadApp = new Download();
            downloadApp.DowloadNewApp();

            var makeNotes = new Notes();
            makeNotes.MakeNotesAboutWork();

            var testSoft = new Reupload();
            testSoft.TestNewFiture(makeApp, downloadApp);
        }
    }
}
