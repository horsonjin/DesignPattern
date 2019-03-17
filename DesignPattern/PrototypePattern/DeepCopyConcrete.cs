using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class DeepCopyConcrete : ICloneable
    {
        private string _Name;
        private Address _Address;

        public string Name { get { return _Name; } }
        public Address Address { get { return _Address; } }

        public DeepCopyConcrete(string name, string postalCode, string address)
        {
            _Name = name;
            _Address = new Address(postalCode, address);
        }
        
        public object Clone()
        {
            return new DeepCopyConcrete(
                this.Name,
                this.Address.PostalCode,
                this.Address.DeliveryAddress);
        }
    }
}
