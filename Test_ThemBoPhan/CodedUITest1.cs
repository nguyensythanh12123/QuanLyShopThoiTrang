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


namespace Test_ThemBoPhan
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
        public void TC_FullTT()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.Test_FormBoPhan();
            this.UIMap.Assert_ThemThanhCong();
        }

        [TestMethod]
        public void TC_NullTT()
        {
            string mabp = "";
            string tenbp = "";

            this.UIMap.Test_FormBoPhanParams.UITxtMaBPEditText = mabp.ToString();
            this.UIMap.Test_FormBoPhanParams.UITxtTenBPEditText = tenbp.ToString();
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.Test_FormBoPhan();
            this.UIMap.Assert_NullTT();

        }

        [TestMethod]
        public void TC_NullMaBP()
        {
            string mabp = "";
            string tenbp = "Nhân Viên Bảo Vệ";

            this.UIMap.Test_FormBoPhanParams.UITxtMaBPEditText = mabp.ToString();
            this.UIMap.Test_FormBoPhanParams.UITxtTenBPEditText = tenbp.ToString();
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.Test_FormBoPhan();
            this.UIMap.Assert_NullTT();

        }

        [TestMethod]
        public void TC_NullTenBP()
        {
            string mabp = "BP04";
            string tenbp = "";

            this.UIMap.Test_FormBoPhanParams.UITxtMaBPEditText = mabp.ToString();
            this.UIMap.Test_FormBoPhanParams.UITxtTenBPEditText = tenbp.ToString();
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.Test_FormBoPhan();
            this.UIMap.Assert_NullTT();

        }

        [TestMethod]
        public void TC_MaBPDaCo()
        {
            string mabp = "BP03";
            string tenbp = "Nhân Viên Bảo Vệ";

            this.UIMap.Test_FormBoPhanParams.UITxtMaBPEditText = mabp.ToString();
            this.UIMap.Test_FormBoPhanParams.UITxtTenBPEditText = tenbp.ToString();
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.Test_FormBoPhan();
            this.UIMap.Assert_MaBPDaCo();
        }
        [TestMethod]
        public void TC_TenBPDaCo()
        {
            string mabp = "BP04";
            string tenbp = "Nhân Viên Quản Lý";

            this.UIMap.Test_FormBoPhanParams.UITxtMaBPEditText = mabp.ToString();
            this.UIMap.Test_FormBoPhanParams.UITxtTenBPEditText = tenbp.ToString();
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.Test_FormBoPhan();
            this.UIMap.Assert_TenBPDaCo();
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
