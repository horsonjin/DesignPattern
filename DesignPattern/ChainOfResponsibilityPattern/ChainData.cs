using System.Collections.Generic;

namespace ChainOfResponsibilityPattern
{
    public sealed class ChainData
    {
        private List<string> _ChainList;
        private static ChainData _ChainData;

        private ChainData()
        {
            _ChainList = new List<string>();
        }

        public static ChainData Instance()
        {
            if (_ChainData == null)
            {
                _ChainData = new ChainData();

            }
            return _ChainData;
        }

        public void Add(string handlerName)
        {
            _ChainList.Add(handlerName);
        }

        public List<string> GetChainList()
        {
            return _ChainList;
        }
    }
}
