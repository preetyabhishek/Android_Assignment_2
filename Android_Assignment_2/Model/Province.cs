using System;
namespace CanadaHoliday.Model
{
	public class Province
	{
        public string Id { get; set; }

        public string NameEn { get; set; }

        public string NameFr { get; set; }

        public string SourceEn { get; set; }

        public Province(string id, string nameEn, string nameFr, string sourceEn)
        {
            Id = id;
            NameEn = nameEn;
            NameFr = nameFr;
            SourceEn = sourceEn;
        }
    }
}

