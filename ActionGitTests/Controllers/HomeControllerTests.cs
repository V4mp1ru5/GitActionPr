﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActionGit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionGit.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            Assert.AreEqual(1, 1);
        }
    }
}