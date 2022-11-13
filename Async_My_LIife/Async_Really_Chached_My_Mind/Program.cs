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
            Texture texture = await makeApp.WorkWithApp();

            var makePotion = new Pill();
            makePotion.DrinkPill();

            var downloadApp = new Download();            
            Soft soft = await downloadApp.DowloadNewApp();

            var makeNotes = new Notes();
            makeNotes.MakeNotesAboutWork();

            var testSoft = new Reupload();
            testSoft.TestNewFiture(soft, texture);
        }
    }
}
