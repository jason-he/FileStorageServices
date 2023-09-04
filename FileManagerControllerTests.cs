using Agorus.Repository;
using Agorus.Domain;
using AgorusFileService.Controllers;
using Moq;
namespace AgorusFileSerivce.Tests
{
    public class FileManagerControllerTests
    {
        [Fact]
        public void CreateAgorusFile_ReturnSuccess()
        {
            var controller = new FileManagerController(null, null);
          
            var filedata = new AgorusFileContent()
            {
                
                FileName =  "Myfile1",
                FileContent =  "SGVsbG8gd29ybGQh",
                CreatedOn = DateTime.UtcNow,
                CreatedBy = 0,
                ModifiedOn = DateTime.UtcNow,
                ModifiedBy = 0
            };

            var result = controller.CreateAgorusFile(filedata);
            Assert.True(149 == result.Result);
        }

        [Fact]
        public void Get_AgorusFiles_Success()
        {
            var controller = new FileManagerController(null, null);
            var result = controller.Get();
            Assert.NotNull(result);
            Assert.Equal(3, result.Count());
        }
    }
}