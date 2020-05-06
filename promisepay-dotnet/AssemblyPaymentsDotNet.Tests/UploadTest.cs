using Newtonsoft.Json;
using NUnit.Framework;
using AssemblyPaymentsDotNet.DTO;
using AssemblyPaymentsDotNet.Implementations;
using RestSharp;

namespace AssemblyPaymentsDotNet.Tests
{
    public class UploadTest
    {
        [Test]
        public void UploadDeserialization()
        {
            const string jsonStr = "{ \"id\": \"a2711d90-ed41-4d12-81d2-000000000002\", \"processed_lines\": 6, \"total_lines\": 6, \"update_lines\": 0, \"error_lines\": 6, \"progress\": 100.0 }";
            var upload = JsonConvert.DeserializeObject<Upload>(jsonStr);
            Assert.IsNotNull(upload);
            Assert.AreEqual("a2711d90-ed41-4d12-81d2-000000000002", upload.Id);
        }

        [Test]
        [Ignore("Not implemented yet")]
        public void CreateUploadSuccessfully()
        {
            Assert.Fail();
        }

        [Test]
        [Ignore("Not implemented yet")]
        public void ListUploadsSuccessfully()
        {
            Assert.Fail();
        }

        [Test]
        [Ignore("Not implemented yet")]
        public void GetUploadByIdSuccessfully()
        {
            Assert.Fail();
        }



        [Test]
        [Ignore("Not implemented yet")]
        public void GetStatusSuccessfully()
        {
            Assert.Fail();            
        }

        [Test]
        [Ignore("Not implemented yet")]
        public void StartImportSuccessfully()
        {
            Assert.Fail();            
        }


    }
}
