using ClubOrganiser.ClientModels;
using ClubOrganiser.Data;
using ClubOrganiser.Interfaces;
using ClubOrganiser.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ClubOrganiser.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        private List<ITileItem> _homePageTiles;
        public ICommand tapCommand;
        public List<ITileItem> HomePageTilesList
        {
            get { return _homePageTiles; }
            set
            {
                _homePageTiles = value;
                OnPropertyChanged("HomePageTiles");
            }
        }

        public Command TapCommand
        {
            get
            {
                return new Command(async val => {
                    HomePageTileItem tileData = val as HomePageTileItem;
                    Page page = tileData.PageType;
                    await App.Current.MainPage.Navigation.PushModalAsync(page);
                });
            }
        }


        public HomePageViewModel()
        {
            this.HomePageTilesList = HomePageData.CreateHomePageTileList();
        }

        //// The command is the important piece
        //public Command MyCommand
        //{
        //    get
        //    {
        //        return new Command(p => {
        //            // option 1
        //            var vm = (HomePageViewModel)p;
        //            vm.HomePageTilesList[1].PageType; // bla
        //        });
        //    }
        //}
    }
}
