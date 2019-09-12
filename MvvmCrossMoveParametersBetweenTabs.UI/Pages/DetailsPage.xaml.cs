using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MvvmCrossMoveParametersBetweenTabs.Core.ViewModels.Details;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmCrossMoveParametersBetweenTabs.UI.Pages
{
    [MvxTabbedPagePresentation]
    public partial class DetailsPage : MvxContentPage<DetailsViewModel>
    {
        public DetailsPage()
        {
            InitializeComponent();
        }
    }
}
