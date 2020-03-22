// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Bookings.IntegrationTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute(TestName="CaseTypes")]
    [NUnit.Framework.DescriptionAttribute("\tIn order to retrieve a list of case types\r\n\tAs an api service\r\n\tI want to be abl" +
        "e to return a list of case types")]
    [NUnit.Framework.CategoryAttribute("VIH-3622")]
    public partial class CaseTypesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "VIH-3622"};
        
#line 1 "CaseTypes.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CaseTypes", "\tIn order to retrieve a list of case types\r\n\tAs an api service\r\n\tI want to be abl" +
                    "e to return a list of case types", ProgrammingLanguage.CSharp, new string[] {
                        "VIH-3622"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestCaseAttribute(TestName="Get available case types")]
        [NUnit.Framework.DescriptionAttribute("Get available case types")]
        [NUnit.Framework.CategoryAttribute("VIH-3582")]
        public virtual void GetAvailableCaseTypes()
        {
            string[] tagsOfScenario = new string[] {
                    "VIH-3582"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get available case types", null, new string[] {
                        "VIH-3582"});
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
 testRunner.Given("I have a get available case types request", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.When("I send the request to the endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("the response should have the status OK and success status True", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.And("a list of case types should be retrieved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestCaseAttribute(TestName="Get case roles for a case type with nonexistent case type")]
        [NUnit.Framework.DescriptionAttribute("Get case roles for a case type with nonexistent case type")]
        public virtual void GetCaseRolesForACaseTypeWithNonexistentCaseType()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get case roles for a case type with nonexistent case type", null, ((string[])(null)));
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 15
 testRunner.Given("I have a get case roles for a case type of \'nonexistent\' request", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 16
 testRunner.When("I send the request to the endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.Then("the response should have the status NotFound and success status False", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestCaseAttribute(TestName="Get hearing roles for a case role of a case type with nonexistent case type")]
        [NUnit.Framework.DescriptionAttribute("Get hearing roles for a case role of a case type with nonexistent case type")]
        public virtual void GetHearingRolesForACaseRoleOfACaseTypeWithNonexistentCaseType()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get hearing roles for a case role of a case type with nonexistent case type", null, ((string[])(null)));
#line 19
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 20
 testRunner.Given("I have a get hearing roles for a case type of \'Civil Money Claims\' and case role " +
                        "of \'nonexistent\' request", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
 testRunner.When("I send the request to the endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.Then("the response should have the status NotFound and success status False", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestCaseAttribute(TestName="Get hearing roles for a case role of a case type with nonexistent role name")]
        [NUnit.Framework.DescriptionAttribute("Get hearing roles for a case role of a case type with nonexistent role name")]
        public virtual void GetHearingRolesForACaseRoleOfACaseTypeWithNonexistentRoleName()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get hearing roles for a case role of a case type with nonexistent role name", null, ((string[])(null)));
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
 testRunner.Given("I have a get hearing roles for a case type of \'nonexistent\' and case role of \'Cla" +
                        "imant\' request", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
 testRunner.When("I send the request to the endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then("the response should have the status NotFound and success status False", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.DescriptionAttribute("Get case roles for a case type")]
        [NUnit.Framework.TestCaseAttribute("Civil Money Claims", null, TestName="Get case roles for a case type(Civil Money Claims)")]
        [NUnit.Framework.TestCaseAttribute("Financial Remedy", null, TestName="Get case roles for a case type(Financial Remedy)")]
        [NUnit.Framework.TestCaseAttribute("Generic", null, TestName="Get case roles for a case type(Generic)")]
        [NUnit.Framework.TestCaseAttribute("Children Act", null, TestName="Get case roles for a case type(Children Act)")]
        [NUnit.Framework.TestCaseAttribute("Tax", null, TestName="Get case roles for a case type(Tax)")]
        [NUnit.Framework.TestCaseAttribute("Family Law Act", null, TestName="Get case roles for a case type(Family Law Act)")]
        [NUnit.Framework.TestCaseAttribute("Tribunal", null, TestName="Get case roles for a case type(Tribunal)")]
        public virtual void GetCaseRolesForACaseType(string caseTypes, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get case roles for a case type", null, exampleTags);
#line 29
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 30
 testRunner.Given(string.Format("I have a get case roles for a case type of {0} request", caseTypes), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 31
 testRunner.When("I send the request to the endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.Then("the response should have the status OK and success status True", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
 testRunner.And("a list of case roles should be retrieved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.DescriptionAttribute("Get hearing roles for a case role of a case type")]
        [NUnit.Framework.TestCaseAttribute("Children Act", "Applicant", null, TestName="Get hearing roles for a case role of a case type(Children Act,Applicant)")]
        [NUnit.Framework.TestCaseAttribute("Children Act", "Respondent", null, TestName="Get hearing roles for a case role of a case type(Children Act,Respondent)")]
        [NUnit.Framework.TestCaseAttribute("Children Act", "Judge", null, TestName="Get hearing roles for a case role of a case type(Children Act,Judge)")]
        [NUnit.Framework.TestCaseAttribute("Civil Money Claims", "Claimant", null, TestName="Get hearing roles for a case role of a case type(Civil Money Claims,Claimant)")]
        [NUnit.Framework.TestCaseAttribute("Civil Money Claims", "Defendant", null, TestName="Get hearing roles for a case role of a case type(Civil Money Claims,Defendant)")]
        [NUnit.Framework.TestCaseAttribute("Civil Money Claims", "Judge", null, TestName="Get hearing roles for a case role of a case type(Civil Money Claims,Judge)")]
        [NUnit.Framework.TestCaseAttribute("Family Law Act", "Applicant", null, TestName="Get hearing roles for a case role of a case type(Family Law Act,Applicant)")]
        [NUnit.Framework.TestCaseAttribute("Family Law Act", "Respondent", null, TestName="Get hearing roles for a case role of a case type(Family Law Act,Respondent)")]
        [NUnit.Framework.TestCaseAttribute("Family Law Act", "Judge", null, TestName="Get hearing roles for a case role of a case type(Family Law Act,Judge)")]
        [NUnit.Framework.TestCaseAttribute("Financial Remedy", "Applicant", null, TestName="Get hearing roles for a case role of a case type(Financial Remedy,Applicant)")]
        [NUnit.Framework.TestCaseAttribute("Financial Remedy", "Respondent", null, TestName="Get hearing roles for a case role of a case type(Financial Remedy,Respondent)")]
        [NUnit.Framework.TestCaseAttribute("Financial Remedy", "Judge", null, TestName="Get hearing roles for a case role of a case type(Financial Remedy,Judge)")]
        [NUnit.Framework.TestCaseAttribute("Generic", "Applicant", null, TestName="Get hearing roles for a case role of a case type(Generic,Applicant)")]
        [NUnit.Framework.TestCaseAttribute("Generic", "Respondent", null, TestName="Get hearing roles for a case role of a case type(Generic,Respondent)")]
        [NUnit.Framework.TestCaseAttribute("Generic", "Judge", null, TestName="Get hearing roles for a case role of a case type(Generic,Judge)")]
        [NUnit.Framework.TestCaseAttribute("Tax", "Applicant", null, TestName="Get hearing roles for a case role of a case type(Tax,Applicant)")]
        [NUnit.Framework.TestCaseAttribute("Tax", "Respondent", null, TestName="Get hearing roles for a case role of a case type(Tax,Respondent)")]
        [NUnit.Framework.TestCaseAttribute("Tax", "Judge", null, TestName="Get hearing roles for a case role of a case type(Tax,Judge)")]
        [NUnit.Framework.TestCaseAttribute("Tribunal", "Applicant", null, TestName="Get hearing roles for a case role of a case type(Tribunal,Applicant)")]
        [NUnit.Framework.TestCaseAttribute("Tribunal", "Respondent", null, TestName="Get hearing roles for a case role of a case type(Tribunal,Respondent)")]
        [NUnit.Framework.TestCaseAttribute("Tribunal", "Judge", null, TestName="Get hearing roles for a case role of a case type(Tribunal,Judge)")]
        public virtual void GetHearingRolesForACaseRoleOfACaseType(string caseTypes, string caseRole, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get hearing roles for a case role of a case type", null, exampleTags);
#line 44
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 45
 testRunner.Given(string.Format("I have a get hearing roles for a case type of \'{0}\' and case role of \'{1}\' reques" +
                            "t", caseTypes, caseRole), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 46
 testRunner.When("I send the request to the endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then("the response should have the status OK and success status True", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.And("a list of hearing roles should be retrieved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
