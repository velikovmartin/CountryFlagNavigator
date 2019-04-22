
namespace CountryFlagNavigator
{
    class Country
    {
        public Country(string name, string info, string capital, string photoId)
        {
            this.Name = name;
            this.Info = info;
            this.Capital = capital;
            this.PhotoID = photoId;
        }
        public string Name { get; set; }

        public string Info { get; set; }

        public string Capital { get; set; }

        public string PhotoID { get; set; }
    }
}
