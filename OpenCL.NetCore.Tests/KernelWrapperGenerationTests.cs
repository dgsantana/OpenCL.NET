using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenCL.NetCore.Tests
{
    [TestClass]
    public sealed class KernelWrapperGenerationTests
    {
        [TestMethod]
        public void TestKernelGeneration()
        {
            //var basePath = AppDomain.CurrentDomain.BaseDirectory;
            //var filePath = Path.Combine(basePath, @"TestKernels\TestKernel1.cl");
            string filePath = @"E:\repos\OpenCL.NetCore\OpenCL.NetCore.Tests\TestKernels\TestKernel1.cl";
            Tasks.Kernel.ProcessKernelFile(filePath, File.ReadAllText(filePath));
        }
    }
}
