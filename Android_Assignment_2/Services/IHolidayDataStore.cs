using System;
using Android_Assignment_2.Model;
using Android_Assignment_2.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Android_Assignment_2.Services
{
    interface IHolidayDataStore<Holiday>
    {
        Task<IEnumerable<Holiday>> GetHolidayAsync();

    }
}
