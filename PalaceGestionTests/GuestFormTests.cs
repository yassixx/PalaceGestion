using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalaceGestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalaceGestion.Tests
{
    [TestClass()]
    public class GuestFormTests
    {
    

        [TestMethod()]
        public void EnregistrerNouveauClientTest()
        {
            // Arrange
            var id = "test12345";
            var prenom = "testPrenom";
            var nom = "testNom";
            var phone = "testPhone";
            var city = "testCity";

            var guestForm = new GuestForm();

            // Act
            var result = guestForm.EnregistrerNouveauClient(id, prenom, nom, phone, city);

            // Assert
            Assert.IsTrue(result);
        }
    }
}