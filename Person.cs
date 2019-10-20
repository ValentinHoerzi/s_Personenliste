using System;

namespace Personenliste
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public bool IsMale { get; set;}

        public bool HasDriversLicense { get; set; }

        public Person(string firstName, string lastName, DateTime? birthDate, bool isMale, bool hasDriversLicense)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            IsMale = isMale;
            HasDriversLicense = hasDriversLicense;
        }

        public override string ToString() => $"{LastName} {FirstName} - {BirthDate?.ToString("dd.MM.yyyy")} [{(IsMale ? " Male" : " Female")} {(HasDriversLicense ? " , Driver ":"")}]";
        
        public string AsCsvString() => $"{FirstName};{LastName};{BirthDate?.ToString("dd.MM.yyyy")};{IsMale};{HasDriversLicense}";


    }
}
