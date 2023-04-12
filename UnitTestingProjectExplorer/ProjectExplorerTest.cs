using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectLib;

namespace UnitTestingProjectExplorer
{
    [TestClass]
    public class ProjectExplorerTest
    {
        [TestMethod]
        public void ConnectionOpenReturnTrue()
        {
            DataBaseConstruction db = new DataBaseConstruction();
            Assert.IsTrue(db.IsConnected);
        }

        [TestMethod]
        public void ConnectionCloseReturnTrue()
        {
            DataBaseConstruction db = new DataBaseConstruction();
            db.ConnectionClose();
            Assert.IsTrue(db.IsConnected);
        }

        [TestMethod]
        public void AddProjectReturnTrue()
        {
            ProjectConstraction project = new ProjectConstraction();
            Assert.IsTrue(project.AddProject("test", "test"));
        }

        [TestMethod]
        public void DeleteProjectReturnTrue()
        {
            ProjectConstraction project = new ProjectConstraction();
            Assert.IsTrue(project.DeleteProject("test"));
        }
    }
}
