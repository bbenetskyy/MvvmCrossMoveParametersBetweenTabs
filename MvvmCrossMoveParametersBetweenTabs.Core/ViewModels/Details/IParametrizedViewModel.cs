using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MvvmCrossMoveParametersBetweenTabs.Core.Models;

namespace MvvmCrossMoveParametersBetweenTabs.Core.ViewModels.Details
{
    public interface IParametrizedViewModel
    {
        ObservableCollection<User> UserCollection { get; set; }
    }
}
