using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Really_Chached_My_Mind
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var асtionsWhitPc = new PC();
            асtionsWhitPc.SitOnPc();

            var makeApp = new App();
            var Tusk = makeApp.WorkWithApp();
            var TuskFromAthozer = await Tusk;

            var makePotion = new Pill();
            makePotion.DrinkPill();

            var downloadApp = new Download();            
            var soft = downloadApp.DowloadNewApp();

            var makeNotes = new Notes();
            makeNotes.MakeNotesAboutWork();

            var testSoft = new Reupload();
            testSoft.TestNewFiture(await soft, TuskFromAthozer);
        }
    }
}
