using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enversoft.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enversoft.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Enversoft.Models;

namespace Enversoft.Controllers.Tests
{
    [TestClass()]
    public class SuppliersControllerTests
    {
        private SuppliersController _controller;

        [TestInitialize]
        public void Setup()
        {
            //mock DbContext for suppliercController
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDB")
                .Options;

            var dbContext = new ApplicationDbContext(options);

            // Populate the mock DbContext with some test data
            dbContext.Suppliers.Add(new Supplier { Code = 1, Name = "Supplier 1", TelelphoneNo = "1234567890" });
            dbContext.Suppliers.Add(new Supplier { Code = 2, Name = "Supplier 2", TelelphoneNo = "2345678901" });
            dbContext.SaveChanges();

            // Instantiate the controller with the mock DbContext
            _controller = new SuppliersController(dbContext);
        }
        [TestMethod()]
        public async Task GetSuppliersTest()
        {
            // Act
            var result = await _controller.GetSuppliers();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Value, typeof(List<Supplier>));
            Assert.AreEqual(2, result.Value.Count());
        }

        [TestMethod()]
        public async Task SearchSuppliersTest()
        {
            // Act
            var result = await _controller.SearchSuppliers(companyName: "2");

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Value, typeof(List<object>));
            Assert.AreEqual(1, result.Value.Count());
            Assert.AreEqual("2345678901", result.Value.First().TelelphoneNo);
        }

        [TestMethod()]
        public async Task PostSupplierTest()
        {
            // Arrange
            var newSupplier = new Supplier { Code = 3, Name = "New Supplier", TelelphoneNo = "5555555555" };

            // Act
            var result = await _controller.PostSupplier(newSupplier);
            var createdSupplier = (result.Result as CreatedAtActionResult).Value as Supplier;
            var allSuppliers = await _controller.GetSuppliers();

            // Assert
            Assert.IsInstanceOfType(result.Result, typeof(CreatedAtActionResult));
            Assert.AreEqual("New Supplier", createdSupplier.Name);
            Assert.AreEqual("5555555555", createdSupplier.TelelphoneNo);
            Assert.AreEqual(3, allSuppliers.Value.Count());
        }
    }
}