using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace Test_DangNhap
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void TC_DangNhapThanhCong()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.

            this.UIMap.Test_FormDangNhap();
            this.UIMap.Asser_DNThanhCong();

        }

        [TestMethod]
        public void TC_NullTT()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            string username = "";
            string password = "";

            this.UIMap.Test_FormDangNhapParams.UITxtTenDNEditText = username.ToString();
            this.UIMap.Test_FormDangNhapParams.UITxtMKEditText = password.ToString();

            this.UIMap.Test_FormDangNhap();
            this.UIMap.AssertNullTT();

        }

        [TestMethod]
        public void TC_NullUserName()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            string username = "";
            string password = "Thanh123";

            this.UIMap.Test_FormDangNhapParams.UITxtTenDNEditText = username.ToString();
            this.UIMap.Test_FormDangNhapParams.UITxtMKEditText = password.ToString();

            this.UIMap.Test_FormDangNhap();
            this.UIMap.AssertNullTT();

        }
        [TestMethod]
        public void TC_NullPassword()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            string username = "NV01";
            string password = "";

            this.UIMap.Test_FormDangNhapParams.UITxtTenDNEditText = username.ToString();
            this.UIMap.Test_FormDangNhapParams.UITxtMKEditText = password.ToString();

            this.UIMap.Test_FormDangNhap();
            this.UIMap.Assert_NullPass();
        }

        [TestMethod]
        public void TC_SaiTT()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            string username = "NV01";
            string password = "Thanh1234";

            this.UIMap.Test_FormDangNhapParams.UITxtTenDNEditText = username.ToString();
            this.UIMap.Test_FormDangNhapParams.UITxtMKEditText = password.ToString();

            this.UIMap.Test_FormDangNhap();
            this.UIMap.Assert_SaiTT();

        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
