﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Playwrights_Web_Automation.Feature
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Add Employee Test")]
    [NUnit.Framework.FixtureLifeCycleAttribute(NUnit.Framework.LifeCycle.InstancePerTestCase)]
    public partial class AddEmployeeTestFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature", "Add Employee Test", null, global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "AddEmployeeTests.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("To Verify, Admin should be able to Create Employe by login and then go to create " +
            "Employe Page")]
        [NUnit.Framework.CategoryAttribute("AddEmployeeFeature")]
        [NUnit.Framework.TestCaseAttribute("Admin", "admin123", "/auth/login", "Uz", "Ai", "R", "15", "December", "2023", "Qatari", "Married", "5", "August", "1991", "Male", null)]
        public async System.Threading.Tasks.Task ToVerifyAdminShouldBeAbleToCreateEmployeByLoginAndThenGoToCreateEmployePage(
                    string username, 
                    string password, 
                    string pageNavigationRoute, 
                    string firstName, 
                    string middleName, 
                    string lastName, 
                    string driverLicenseExpiryDay, 
                    string driverLicenseExpiryMonth, 
                    string driverLicenseExpiryYear, 
                    string nationality, 
                    string maritalStatus, 
                    string dateOfBirthDay, 
                    string dateOfBirthMonth, 
                    string dateOfBirthYear, 
                    string gender, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AddEmployeeFeature"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("PageNavigationRoute", pageNavigationRoute);
            argumentsOfScenario.Add("FirstName", firstName);
            argumentsOfScenario.Add("MiddleName", middleName);
            argumentsOfScenario.Add("LastName", lastName);
            argumentsOfScenario.Add("DriverLicenseExpiryDay", driverLicenseExpiryDay);
            argumentsOfScenario.Add("DriverLicenseExpiryMonth", driverLicenseExpiryMonth);
            argumentsOfScenario.Add("DriverLicenseExpiryYear", driverLicenseExpiryYear);
            argumentsOfScenario.Add("Nationality", nationality);
            argumentsOfScenario.Add("MaritalStatus", maritalStatus);
            argumentsOfScenario.Add("DateOfBirthDay", dateOfBirthDay);
            argumentsOfScenario.Add("DateOfBirthMonth", dateOfBirthMonth);
            argumentsOfScenario.Add("DateOfBirthYear", dateOfBirthYear);
            argumentsOfScenario.Add("Gender", gender);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("To Verify, Admin should be able to Create Employe by login and then go to create " +
                    "Employe Page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 14
 await testRunner.GivenAsync(string.Format("Go to Admin Login Page with URL \"{0}\"", pageNavigationRoute), ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 15
 await testRunner.WhenAsync(string.Format("Enter Correct UserName \"{0}\" and Password \"{1}\"", username, password), ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 16
 await testRunner.ThenAsync("Click on the Login Button", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 17
 await testRunner.AndAsync("Then go to PIM Page", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 18
 await testRunner.AndAsync("Click on Add Employe Button", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 19
 await testRunner.AndAsync(string.Format("Enter Correct First Name \"{0}\", Middle Name\"{1}\", Last Name \"{2}\", Employee ID \"<" +
                            "EmployeeId>\"", firstName, middleName, lastName), ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 21
 await testRunner.ThenAsync("Click on the Save Button", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 22
 await testRunner.ThenAsync("Click on the Personal Details Button", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 23
 await testRunner.ThenAsync(string.Format("Enter Driver\'s License Number \"<DriverLicenseNumber>\", License Expiry Date \"{0}\" " +
                            "\"{1}\" \"{2}\", Nationality \"{3}\",Marital Status \"{4}\", Date of Birth \"{5}\" \"{6}\" \"" +
                            "{7}\", Gender \"{8}\"", driverLicenseExpiryDay, driverLicenseExpiryMonth, driverLicenseExpiryYear, nationality, maritalStatus, dateOfBirthDay, dateOfBirthMonth, dateOfBirthYear, gender), ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 25
 await testRunner.ThenAsync("Click on the Save Button Add Details", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
