﻿using Android_Assignment_2.Services;
using Android_Assignment_2.Model;
using MvvmHelpers;
using MvvmHelpers.Commands;

namespace Android_Assignment_2.ViewModels
{
    internal class HolidayListViewModel
    {

        public IHolidayDataStore<Holiday> DataStore =>
            DependencyService.Get<IHolidayDataStore<Holiday>>();

        public ObservableRangeCollection<Holiday> Holiday { get; set; }

        public AsyncCommand PageAppearingCommand { get; }


        public HolidayListViewModel()
        {
            Holiday = new ObservableRangeCollection<Holiday>();
            PageAppearingCommand = new AsyncCommand(PageAppearing);
        }

        public async Task Refresh()
        {
            var holiday = await DataStore.GetHolidayAsync();

            Holiday.AddRange(holiday);
        }

        async Task PageAppearing()
        {
            await Refresh();
        }
    }
}

