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
    public class ThirdDetailsViewModel : MvxViewModel, IParametrizedViewModel
    {
        private readonly IModelGenerator<User> _generator;
        public ObservableCollection<User> UserCollection { get; set; }


        private User _secretUser;

        public User SecretUser
        {
            get => _secretUser;
            set => SetProperty(ref _secretUser, value);
        }

        public MvxCommand GenerateCommand { get; }
        public MvxCommand GenerateSecretCommand { get; }

        public ThirdDetailsViewModel(IModelGenerator<User> generator)
        {
            _generator = generator;
            UserCollection = new ObservableCollection<User>();
            GenerateCommand = new MvxCommand(() => UserCollection.Add(_generator.GenerateModel()));
            GenerateSecretCommand = new MvxCommand(() => SecretUser = _generator.GenerateModel());
        }
    }
}
