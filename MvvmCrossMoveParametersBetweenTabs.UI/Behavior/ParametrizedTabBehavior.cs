using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Forms.Views;
using MvvmCrossMoveParametersBetweenTabs.Core.ViewModels.Details;
using MvvmCrossMoveParametersBetweenTabs.Core.ViewModels.Home;
using Xamarin.Forms;
using MvvmCross.ViewModels;

namespace MvvmCrossMoveParametersBetweenTabs.UI.Behavior
{
    public class ParametrizedTabBehavior : Behavior<MvxTabbedPage>
    {
        public MvxTabbedPage AssociatedObject { get; private set; }
        private IParametrizedViewModel _currentViewModel;

        protected override void OnAttachedTo(MvxTabbedPage bindable)
        {
            bindable.CurrentPageChanged += Bindable_CurrentPageChanged;
            base.OnAttachedTo(bindable);
            AssociatedObject = bindable;
        }
        protected override void OnDetachingFrom(MvxTabbedPage bindable)
        {
            bindable.CurrentPageChanged -= Bindable_CurrentPageChanged;
            base.OnDetachingFrom(bindable);
            AssociatedObject = null;
        }

        private void Bindable_CurrentPageChanged(object sender, EventArgs e)
        {
            if (!(AssociatedObject?.CurrentPage is IMvxPage p))
                return;

            if (!(p.ViewModel is IParametrizedViewModel newViewModel))
                return;

            if (_currentViewModel != null)
            {
                newViewModel.UserCollection = _currentViewModel.UserCollection;
            }

            _currentViewModel = newViewModel;
        }

    }
}
