using System;
using MvvmCrossMoveParametersBetweenTabs.Core.Models;
using RandomNameGeneratorLibrary;

namespace MvvmCrossMoveParametersBetweenTabs.Core.Services
{
    public class UserGenerator : IModelGenerator<User>
    {
        private readonly PersonNameGenerator _generator = new PersonNameGenerator();

        public User GenerateModel() => new User(_generator.GenerateRandomFirstAndLastName(), Guid.NewGuid());
    }
}
