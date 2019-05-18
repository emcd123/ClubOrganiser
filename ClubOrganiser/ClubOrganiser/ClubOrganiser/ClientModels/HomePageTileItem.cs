using ClubOrganiser.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ClubOrganiser.ClientModels
{
    public class HomePageTileItem : ITileItem
    {
        private int _id;
        private string _title;
        private string _svgImage;
        private string _backgroundColor;
        private NavigationPage _pageType;
        private int _column;
        private int _row;

        public int Id
        {
            get {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public string SvgImage
        {
            get
            {
                return _svgImage;
            }
            set
            {
                _svgImage = value;
            }
        }

        public string BackgroundColor
        {
            get
            {
                return _backgroundColor;
            }
            set
            {
                _backgroundColor = value;
            }
        }

        public NavigationPage PageType
        {
            get
            {
                return _pageType;
            }
            set
            {
                _pageType = value;
            }
        }
        public int Column
        {
            get
            {
                return _column;
            }
            set
            {
                _column = value;
            }
        }

        public int Row
        {
            get
            {
                return _row;
            }
            set
            {
                _row = value;
            }
        }
    }
}
