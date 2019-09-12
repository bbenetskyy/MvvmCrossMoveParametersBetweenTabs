using System.Collections.Generic;
using System.Text;

namespace MvvmCrossMoveParametersBetweenTabs.Core.Services
{
    public interface IModelGenerator<T> where T : class
    {
        T GenerateModel();
    }
}
