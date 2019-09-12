using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCrossMoveParametersBetweenTabs.Core.ViewModels.Details;

namespace MvvmCrossMoveParametersBetweenTabs.Core.ViewModels.Home
{
    public class HomeViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private bool _firstTime = true;
        private IMvxViewModel _previousViewModel;

        public HomeViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private Task ShowInitialViewModels()
        {
            var tasks = new List<Task>
            {
                _navigationService.Navigate<DetailsViewModel>(),
                _navigationService.Navigate<SecondDetailsViewModel>(),
                _navigationService.Navigate<ThirdDetailsViewModel>()
            };
            return Task.WhenAll(tasks);
        }

        public override void ViewAppearing()
        {
            if (_firstTime)
            {
                ShowInitialViewModels();
                _firstTime = false;
            }
        }

        public void OnSelectedTabChanged(IMvxViewModel selectedViewModel)
        {
            if (_previousViewModel != null)
            {
                if (_previousViewModel is DetailsViewModel d1
                    && selectedViewModel is ThirdDetailsViewModel d3)
                {
                    d3.SecretUser = d1.SecretUser;
                }
            }
            _previousViewModel = selectedViewModel;
        }
    }
}
