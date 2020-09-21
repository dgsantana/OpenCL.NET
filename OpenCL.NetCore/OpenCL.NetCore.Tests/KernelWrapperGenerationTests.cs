using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(basePath, @"TestKernels\TestKernel1.cl");
            var wrapper = OpenCL.NetCore.Tasks.Kernel.ProcessKernelFile(filePath, File.ReadAllText(filePath));
        }
    }
}
