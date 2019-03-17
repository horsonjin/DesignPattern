using Xunit;
using MementoPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Tests
{
    public class PersonTests
    {
        [Fact()]
        public void PersonSaveAndRestoreTest()
        {
            Person person = new Person("Tom",21);
            CareTaker careTaker = new CareTaker();
            careTaker.Memento = person.CreateMemento();

            person.Name = "Timi";
            person.Age = 30;

            person.RestoreMemento(careTaker.Memento);

            Assert.True(person.Name=="Tom"
                &&person.Age == 21);
        }
    }
}