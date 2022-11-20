using System;
namespace Android_Assignment_2.Model
{
	public class APIResponse
	{


        public List<Model.Holiday> Holidays { get; set; }
        public APIResponse(List<Holiday> holidays)
            {
            Holidays = holidays;
            }
    }
}