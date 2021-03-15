using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using VRoads.UVP.Base;

namespace VcRoads.UVP.StepDefs
{
    [Binding]
    public sealed class UnregisteredVP
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        IWebDriver driver = null;

        public UnregisteredVP(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        #region Given
        [Given(@"I provide my '(.*)','(.*)','(.*)','(.*)'")]
        public void GivenIProvideMy(string p0, string p1, string p2, string p3)
        {
            driver.Navigate().GoToUrl(Config.UvpUrl);

        }

        [Given(@"I click on the Calculate button")]
        public void GivenIClickOnTheCalculateButton()
        {
            
        }
        #endregion


    }
}
