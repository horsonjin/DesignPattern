using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class TextFile:FakeFile
    {
        public TextFile()
        {
            _FileType = "TextFile";
        }
    }
}
