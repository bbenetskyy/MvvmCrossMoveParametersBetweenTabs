using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossMoveParametersBetweenTabs.Core.Models
{
    public class User
    {
        public string FullName { get; }
        public Guid Id { get; }
        public string IdString => Id.ToString();

        public User(string fullName, Guid id)
        {
            FullName = fullName;
            Id = id;
        }
    }
}
