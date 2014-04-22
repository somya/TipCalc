using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using TipCalc.Core;

namespace TipCalc.UI.Touch
{
	public partial class TipView : MvxViewController
	{
		public TipView() : base( "TipView", null )
		{
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			

			var set = this.CreateBindingSet<TipView, TipViewModel>();
			set.Bind(SubTotalTextField).To(vm => vm.SubTotal);
			set.Bind(GenerosiySlider).To(vm => vm.Generosity);
			set.Bind(TipLabel).To(vm => vm.Generosity);
			set.Apply();

			this.EdgesForExtendedLayout = UIRectEdge.None;
		}
	}
}

