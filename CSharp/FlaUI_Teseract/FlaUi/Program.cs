using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using System.Threading;
using FlaUI.Core.WindowsAPI;
using FlaUI.Core.Capturing;
using System.Drawing;

namespace FlaUi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var application = Application.Launch("firefox.exe");
            //var mainwindow = application.GetMainWindow(new UIA3Automation());
            //ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            //mainwindow.FindFirstDescendant(cf.ByName("Editor de Texto")).AsTextBox().Enter("Hello world");
            //mainwindow.FindFirstDescendant(cf.ByName("Arquivo")).AsButton().Click();
            // mainwindow.FindFirstDescendant(cf.ByAutomationId("1148")).AsTextBox().Enter("file1 (5).txt");

            MouseMoveTo(170, 1059);
            WriteText("firefox");
            MouseMoveTo(176, 506);
            MouseMoveTo(477, 21);
            MouseMoveTo(502, 70);
            WriteText("https://animesonline.cc/tv/");
            Keyboard.Type(VirtualKeyShort.ENTER);
            Thread.Sleep(5000);
            string path = capScreenShot(320, 50, 250, 28);
            Thread.Sleep(5000);
            Keyboard.TypeSimultaneously(VirtualKeyShort.ALT, VirtualKeyShort.F4);
        }

        private static void MouseMoveTo(int x, int y)
        {
            Mouse.MoveTo(x, y);

            Wait.UntilInputIsProcessed();

            Mouse.LeftClick();

            Thread.Sleep(100);
        }


        private static void WriteText(string phrase)
        {
            Wait.UntilInputIsProcessed();

            string[] words = phrase.Split();

            foreach (string word in words)
            {
                Keyboard.Type(word);
            }

                Thread.Sleep(100);
        }

        public static string capScreenShot(int x, int  y, int  width, int height)
        {
            DateTime date = DateTime.Now;
            String timeStapmString  = date.ToString("yyyyMMddHHmmssffff");
            var fullScreenShotImg = Capture.Rectangle(new Rectangle(x, y, width, height));
            string path = $@"C:\temp\{timeStapmString}.png";
            fullScreenShotImg.ToFile(path);

            return path;
        }
    }
}
