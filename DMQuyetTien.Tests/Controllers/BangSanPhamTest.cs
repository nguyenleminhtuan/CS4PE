using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication;
using DMQuyetTien.Models;
using DMQuyetTien.Controllers;

namespace WebApplication.Tests.Controllers {
    [TestClass]
    public class BangSanPhamTest {
        [TestMethod]
        public void TestIndex() {
            var controller = new BangSanPhamController();
            var result = controller.Index() as ViewResult;
            var db = new CS4PEEntities();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Model, typeof(List<BangSanPham>));
            Assert.AreEqual(db.BangSanPhams.Count(), ((List<BangSanPham>)result.Model).Count);
        }
    }
}