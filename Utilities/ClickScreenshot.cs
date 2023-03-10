using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlylearning.Utilities
{
    public class ClickScreenshot : CommonDriver
    {

        public static void LoginScreenShot()
        {

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"C:\Users\rasan\Documents\mars excel/logIn" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".jpeg", ScreenshotImageFormat.Png);

        }

        public static void CreateSkillScreenShot()
        {

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"C:\Users\rasan\Documents\mars excel/create" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".jpeg", ScreenshotImageFormat.Png);

        }

        public static void EditSkillScreenShot()
        {

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"C:\Users\rasan\Documents\mars excel/saveAs" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".jpeg", ScreenshotImageFormat.Png);

        }

        public static void DeleteSkillScreenShot()
        {

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"C:\Users\rasan\Documents\mars excel/deleteSkill" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".jpeg", ScreenshotImageFormat.Png);

        }


    }
}
