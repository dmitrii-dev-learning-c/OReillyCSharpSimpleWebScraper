using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper.HumanBuilderExample
{
    internal class HumanBuilder
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private int _eyeColour;
        private int _hairColour;

        //Constructor for our builder class:
        public HumanBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _firstName = "John";
            _lastName = "Smith";
            _age = 30;
            _eyeColour = 153;
            _hairColour = 153;

        }

        //Methods that will enable us to change these values:
        public HumanBuilder WithFirstName(string firstName)
        {
            _firstName = firstName;
            return this;//returning a builder object allows us to chain methods
        }
        public HumanBuilder WithLastName(string lastname)
        {
            _lastName = lastname;
            return this;
        }
        public HumanBuilder WithAge(int age)
        {
            _age = age;
            return this;
        }
        public HumanBuilder WithEyeColour(int eyeColour)
        {
            _eyeColour = eyeColour;
            return this;
        }
        public HumanBuilder WithHairColour(int hairColour)
        {
            _hairColour = hairColour;
            return this;
        }

        public Human Build()
        {
            Human human = new Human(_firstName, _lastName, _age, _eyeColour, _hairColour);
            return human;
        }
    }
}
