﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace HBAuto_Install2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The WSInstallDestination recording.
    /// </summary>
    [TestModule("65b706fb-2484-40a5-ad80-f5abda2b41d7", ModuleType.Recording, 1)]
    public partial class WSInstallDestination : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HBAuto_Install2Repository repository.
        /// </summary>
        public static HBAuto_Install2Repository repo = HBAuto_Install2Repository.Instance;

        static WSInstallDestination instance = new WSInstallDestination();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WSInstallDestination()
        {
            YearVersion = "2018.1";
            WSInstallLocation = "C:\\HeavyBidWS\\";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WSInstallDestination Instance
        {
            get { return instance; }
        }

#region Variables

        string _YearVersion;

        /// <summary>
        /// Gets or sets the value of variable YearVersion.
        /// </summary>
        [TestVariable("fce983cc-3353-4ba3-9656-01a605f15bea")]
        public string YearVersion
        {
            get { return _YearVersion; }
            set { _YearVersion = value; }
        }

        string _WSInstallLocation;

        /// <summary>
        /// Gets or sets the value of variable WSInstallLocation.
        /// </summary>
        [TestVariable("e22c6ac4-3efb-4ee8-a0dd-df63a151ee2f")]
        public string WSInstallLocation
        {
            get { return _WSInstallLocation; }
            set { _WSInstallLocation = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~'HeavyBid') on item 'HeavyBidServerSetup.Titlebar'.", repo.HeavyBidServerSetup.TitlebarInfo, new RecordItemIndex(0));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TitlebarInfo, "Text", new Regex("HeavyBid"), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~'Workstation') on item 'HeavyBidServerSetup.Titlebar'.", repo.HeavyBidServerSetup.TitlebarInfo, new RecordItemIndex(1));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TitlebarInfo, "Text", new Regex("Workstation"), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~$YearVersion) on item 'HeavyBidServerSetup.Titlebar'.", repo.HeavyBidServerSetup.TitlebarInfo, new RecordItemIndex(2));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TitlebarInfo, "Text", new Regex(YearVersion), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text=$WSInstallLocation) on item 'HeavyBidServerSetup.FilepathTextbox'.", repo.HeavyBidServerSetup.FilepathTextboxInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.HeavyBidServerSetup.FilepathTextboxInfo, "Text", WSInstallLocation, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 30s to exist. Associated repository item: 'HeavyBidServerSetup.UpdateButton'", repo.HeavyBidServerSetup.UpdateButtonInfo, new ActionTimeout(30000), new RecordItemIndex(4));
                repo.HeavyBidServerSetup.UpdateButtonInfo.WaitForExists(30000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HeavyBidServerSetup.UpdateButton' at Center.", repo.HeavyBidServerSetup.UpdateButtonInfo, new RecordItemIndex(5));
                repo.HeavyBidServerSetup.UpdateButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 15m to exist. Associated repository item: 'HeavyBidServerSetup.FinishButton'", repo.HeavyBidServerSetup.FinishButtonInfo, new ActionTimeout(900000), new RecordItemIndex(6));
                repo.HeavyBidServerSetup.FinishButtonInfo.WaitForExists(900000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HeavyBidServerSetup.FinishButton' at Center.", repo.HeavyBidServerSetup.FinishButtonInfo, new RecordItemIndex(7));
                repo.HeavyBidServerSetup.FinishButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
