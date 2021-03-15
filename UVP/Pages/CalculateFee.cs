using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using VRoads.UVP.Base;
using OpenQA.Selenium.Support.PageObjects;


namespace VcRoads
{
    class CalculateFee
    {
        #region Initialisation
        IWebDriver driver = null;
        //private static readonly String Url = Config.UvpUrl;

        public CalculateFee(IWebDriver driver)
        {
            this.driver = driver;
        }


        #endregion

        #region WebElement
        [FindsBy(How = How.Id, Using="ph_pagebody_0_phthreecolumnmaincontent_0_panel_VehicleType_DDList")]
        public IWebElement vehicleType;

        [FindsBy(How = How.Id, Using = "ph_pagebody_0_phthreecolumnmaincontent_0_panel_PassengerVehicleSubType_DDList")]
        public IWebElement vehicleSubType;

     
        #endregion

        #region Actions

        #endregion
    }
}
