using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Forms.Views;
using MvvmCrossMoveParametersBetweenTabs.Core.ViewModels.Details;
using MvvmCrossMoveParametersBetweenTabs.Core.ViewModels.Home;
using Xamarin.Forms;

namespace MvvmCrossMoveParametersBetweenTabs.UI.Behavior
{
    public class HomeSecretBehavior : Behavior<MvxTabbedPage<HomeViewModel>>
    {
        public MvxTabbedPage<HomeViewModel> AssociatedObject { get; private set; }

        protected override void OnAttachedTo(MvxTabbedPage<HomeViewModel> bindable)
        {
            bindable.CurrentPageChanged += Bindable_CurrentPageChanged;
            base.OnAttachedTo(bindable);
            AssociatedObject = bindable;
        }
        protected override void OnDetachingFrom(MvxTabbedPage<HomeViewModel> bindable)
        {
            bindable.CurrentPageChanged -= Bindable_CurrentPageChanged;
            base.OnDetachingFrom(bindable);
            AssociatedObject = null;
        }

        private void Bindable_CurrentPageChanged(object sender, EventArgs e)
        {
            if (AssociatedObject?.ViewModel == null || !(AssociatedObject.CurrentPage is IMvxPage p))
                return;

            AssociatedObject.ViewModel.OnSelectedTabChanged(p.ViewModel);
        }
    }
}
