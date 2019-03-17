using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Folder: FakeFile
    {
        public Folder()
        {
            _FileType = "Folder";
            _FileStore = new List<FakeFile>();
        }
        private List<FakeFile> _FileStore;
        public void Add(FakeFile file)
        {
            _FileStore.Add(file);
        }
        public void Remove(FakeFile file)
        {
            _FileStore.Remove(file);
        }
        public FakeFile Get(int index)
        {
            return _FileStore[index];
        }
        public override string Display()
        {
            Records = new List<string>();
            foreach (var file in _FileStore)
            {
                Records.Add(file.Display());
            }
            return _FileType;
        }

        #region for unit test
        public List<string> Records { get; private set; }
        #endregion
    }
}
