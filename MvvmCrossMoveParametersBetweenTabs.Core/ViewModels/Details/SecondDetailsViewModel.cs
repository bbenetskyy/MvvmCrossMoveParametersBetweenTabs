using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using MvvmCrossMoveParametersBetweenTabs.Core.Models;
using MvvmCrossMoveParametersBetweenTabs.Core.Services;

namespace MvvmCrossMoveParametersBetweenTabs.Core.ViewModels.Details
{
    public class SecondDetailsViewModel : MvxViewModel, IParametrizedViewModel
    {
        private readonly IModelGenerator<User> _generator;
        public ObservableCollection<User> UserCollection { get; set; }

        public MvxCommand GenerateCommand { get; }

        public SecondDetailsViewModel(IModelGenerator<User> generator)
        {
            _generator = generator;
            UserCollection = new ObservableCollection<User>();
            GenerateCommand = new MvxCommand(() => UserCollection.Add(_generator.GenerateModel()));
        }
    }
}
