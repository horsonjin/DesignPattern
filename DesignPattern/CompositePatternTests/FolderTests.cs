using Xunit;
using CompositePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Tests
{
    public class FolderTests
    {
        [Fact()]
        public void DisplayTest()
        {
            Folder folder1 = new Folder();
            FakeFile textFile = new TextFile();
            FakeFile videoFile = new VideoFile();
            folder1.Add(textFile);
            folder1.Add(videoFile);
            folder1.Display();
            Assert.Equal("TextFile", folder1.Records[0]);
            Assert.Equal("VideoFile", folder1.Records[1]);

            Folder folder2 = new Folder();
            folder2.Add(folder1);
        }
    }
}