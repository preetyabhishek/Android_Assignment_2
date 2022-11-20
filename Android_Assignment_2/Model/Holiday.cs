using System;
namespace Android_Assignment_2.Model
{
	public class Holiday
	{
        public string Id { get; set; }

        public string englishName { get; set; }

        public string frenchName { get; set; }

        public string date { get; set; }

        public Holiday(string Id, string englishName, string frenchName, string date)
        {
            this.Id = Id;
            this.englishName = englishName;
            this.frenchName = frenchName;
            this.date = date;
        }
    }
}

