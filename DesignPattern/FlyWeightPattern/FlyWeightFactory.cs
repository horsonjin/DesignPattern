using System.Collections.Generic;

namespace FlyWeightPattern
{
    public static class FlyWeightFactory
    {
        private static Dictionary<string, Shape> _Store;

        static FlyWeightFactory()
        {
            _Store = new Dictionary<string, Shape>();
        }

        public static Shape GetShape(string shapeName, string colorName)
        {
            string key = shapeName + "_" + colorName;
            if (_Store.ContainsKey(key))
            {
                return _Store[key];
            }
            else
            {
                var shape = ShapeFactory.Create(shapeName);
                shape.SetColor(colorName);
                _Store.Add(key, shape);
                return shape;
            }
        }
    }
}
