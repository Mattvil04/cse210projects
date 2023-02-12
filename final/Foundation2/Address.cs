class Address
    {
        private string streetAddress;
        private string city;
        private string stateProvince;
        private string country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateProvince = stateProvince;
            this.country = country;
        }

        public string StreetAddress
        {
            get { return streetAddress; }
        }

        public string City
        {
            get { return city; }
        }

        public string StateProvince
        {
            get { return stateProvince; }
        }

        public string Country
        {
            get { return country; }
        }

        public bool IsInUSA()
        {
            return country == "USA";
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}, {2}\n{3}", streetAddress, city, stateProvince, country);
        }
    }

