using AviBL;
using AviDL;
using AviModels;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AviTests
{
    public class TestAviatorBL
    {
        private Mock<IAviRepo> _aviatorBLMock;

        public TestAviatorBL()
        {
            _aviatorBLMock = new Mock<IAviRepo>();
        }

        [Fact]
        public void AddFileShouldCallAddFile()
        {
            var newFile = new File();
            _aviatorBLMock.Setup(x => x.AddFile(It.IsAny<File>())).Returns(newFile);
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            var result = newAviqtorBL.AddFile(newFile);

            Assert.Equal(result, newFile);
            _aviatorBLMock.Verify(x => x.AddFile(It.IsAny<File>()));
        }

        [Fact]
        public void AddPilotShouldCallAddPilot()
        {
            var newPilot = new Pilot();
            _aviatorBLMock.Setup(x => x.AddPilot(It.IsAny<Pilot>())).Returns(newPilot);
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            var result = newAviqtorBL.AddPilot(newPilot);

            Assert.Equal(result, newPilot);
            _aviatorBLMock.Verify(x => x.AddPilot(It.IsAny<Pilot>()));
        }

        [Fact]
        public void AddSceneFileShouldCallAddSceneFile()
        {
            var newSceneFile = new SceneFile();
            _aviatorBLMock.Setup(x => x.AddSceneFile(It.IsAny<SceneFile>())).Returns(newSceneFile);
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            var result = newAviqtorBL.AddSceneFile(newSceneFile);

            Assert.Equal(result, newSceneFile);
            _aviatorBLMock.Verify(x => x.AddSceneFile(It.IsAny<SceneFile>()));
        }

        [Fact]
        public void AddScriptShouldCallAddScript()
        {
            var newScript = new Script();
            _aviatorBLMock.Setup(x => x.AddScript(It.IsAny<Script>())).Returns(newScript);
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            var result = newAviqtorBL.AddScript(newScript);

            Assert.Equal(result, newScript);
            _aviatorBLMock.Verify(x => x.AddScript(It.IsAny<Script>()));
        }

        [Fact]
        public void DeleteFileShouldCallDeleteFile()
        {
            var newFile = new File();
            _aviatorBLMock.Setup(x => x.DeleteFile(It.IsAny<File>())).Returns(newFile);
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            var result = newAviqtorBL.DeleteFile(newFile);

            Assert.Equal(result, newFile);
            _aviatorBLMock.Verify(x => x.DeleteFile(It.IsAny<File>()));
        }

        [Fact]
        public void GetContributorsByUserIDShouldCallGetContributorsByUserID()
        {
            int userId = 1;
            var contributors = new List<Contributor> { new Contributor() { UserID = 1} };
            _aviatorBLMock.Setup(x => x.GetContributorsByUserID(It.IsAny<int>())).Returns(contributors);
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            var result = newAviqtorBL.GetContributorsByUserID(userId);

            Assert.Equal(result, contributors);
            _aviatorBLMock.Verify(x => x.GetContributorsByUserID(It.IsAny<int>()));
        }

        [Fact]
        public void GetContributorsByPilotIDShouldCallGetContributorsByPilotID()
        {
            int pilotId = 1;
            var contributors = new List<Contributor> { new Contributor() { PilotID = 1 } };
            _aviatorBLMock.Setup(x => x.GetContributorsByPilotID(It.IsAny<int>())).Returns(contributors);
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            var result = newAviqtorBL.GetContributorsByPilotID(pilotId);

            Assert.Equal(result, contributors);
            _aviatorBLMock.Verify(x => x.GetContributorsByPilotID(It.IsAny<int>()));
        }

        [Fact]
        public void GetFilesByPilotIDShouldCallGetFilesByPilotID()
        {
            int pilotId = 1;
            var files = new List<File> { new File() { PilotID = 1 } };
            _aviatorBLMock.Setup(x => x.GetFilesByPilotID(It.IsAny<int>())).Returns(files);
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            var result = newAviqtorBL.GetFilesByPilotID(pilotId);

            Assert.Equal(result, files);
            _aviatorBLMock.Verify(x => x.GetFilesByPilotID(It.IsAny<int>()));
        }

        [Fact]
        public void GetFilesBySceneIdShouldCallGetFilesBySceneId()
        {
            int scenId = 1;
            var files = new List<File> { new File() { PilotID = 1 } };
            _aviatorBLMock.Setup(x => x.GetFilesBySceneId(It.IsAny<int>())).Returns(files);
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            var result = newAviqtorBL.GetFilesBySceneId(scenId);

            Assert.Equal(result, files);
            _aviatorBLMock.Verify(x => x.GetFilesBySceneId(It.IsAny<int>()));
        }

        [Fact]
        public void GetPilotByIDShouldCallGetPilotByID()
        {
            int pilotId = 1;
            var pilot = new Pilot();
            _aviatorBLMock.Setup(x => x.GetPilotByID(It.IsAny<int>())).Returns(pilot);
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            var result = newAviqtorBL.GetPilotByID(pilotId);

            Assert.Equal(result, pilot);
            _aviatorBLMock.Verify(x => x.GetPilotByID(It.IsAny<int>()));
        }

        [Fact]
        public void GetScenesByPilotIDShouldCallGetScenesByPilotID()
        {
            int pilotId = 1;
            var scenes = new List<Scene> { new Scene() { PilotID = 1 } };
            _aviatorBLMock.Setup(x => x.GetScenesByPilotID(It.IsAny<int>())).Returns(scenes);
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            var result = newAviqtorBL.GetScenesByPilotID(pilotId);

            Assert.Equal(result, scenes);
            _aviatorBLMock.Verify(x => x.GetScenesByPilotID(It.IsAny<int>()));
        }

        [Fact]
        public void GetScriptByPilotIDShouldCallGetScriptByPilotID()
        {
            int pilotId = 1;
            var script = new Script();
            _aviatorBLMock.Setup(x => x.GetScriptByPilotID(It.IsAny<int>())).Returns(script);
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            var result = newAviqtorBL.GetScriptByPilotID(pilotId);

            Assert.Equal(result, script);
            _aviatorBLMock.Verify(x => x.GetScriptByPilotID(It.IsAny<int>()));
        }

        [Fact]
        public void GetPilotsShouldCallGetPilots()
        {
            var pilots = new List<Pilot> { new Pilot() };
            _aviatorBLMock.Setup(x => x.GetPilots()).Returns(pilots);
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            var result = newAviqtorBL.GetPilots();

            Assert.Equal(result, pilots);
            _aviatorBLMock.Verify(x => x.GetPilots());
        }

        [Fact]
        public void GetPilotsByProducerIDShouldGetPilots()
        {
            var pilots = new List<Pilot> { new Pilot() };
            _aviatorBLMock.Setup(x => x.GetPilotsByProducerID(1)).Returns(pilots);
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            var result = newAviqtorBL.GetPilotsByProducerID(1);

            Assert.Equal(result, pilots);
            _aviatorBLMock.Verify(x => x.GetPilotsByProducerID(1));
        }

        [Fact]
        public void DeleteScriptIfExistsShouldDeleteScript()
        {
            _aviatorBLMock.Setup(x => x.DeleteScriptIfExists(1));
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            newAviqtorBL.DeleteScriptIfExists(1);
            _aviatorBLMock.Verify(x => x.DeleteScriptIfExists(1));
        }

        [Fact]
        public void DeleteScenesIfExistsShouldDeleteScenes()
        {
            _aviatorBLMock.Setup(x => x.DeleteScenesIfExists(1));
            var newAviqtorBL = new AviatorBL(_aviatorBLMock.Object);
            newAviqtorBL.DeleteScenesIfExists(1);
            _aviatorBLMock.Verify(x => x.DeleteScenesIfExists(1));
        }
    }
}
