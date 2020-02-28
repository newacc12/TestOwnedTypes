using System;

namespace TestOwnedTypes.Data
{
    public class Address
    {
        public string StreetName { get; private set; }
        public string StreetNumber { get; private set; }

        private Address() { }

        private Address(string streetName, string streetNumber)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
        }

        public static Address Create(string streetName, string streetNumber)
        {
            if (string.IsNullOrWhiteSpace(streetName))
                throw new ArgumentNullException(nameof(streetName));

            if (string.IsNullOrWhiteSpace(streetNumber))
                throw new ArgumentNullException(nameof(streetNumber));

            return new Address(streetName, streetNumber);
        }
    }
}
