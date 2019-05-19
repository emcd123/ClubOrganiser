using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ClubOrganiser.Interfaces
{
    public interface ITileItem
    {
        int Id { get; set; }
        string Title { get; set; }
        string Icon { get; set; }
        string IconFamily { get; set; }
        string BackgroundColor { get; set; }
        NavigationPage PageType { get; set; }
        int Column { get; set; }
        int Row { get; set; }
    }
}
