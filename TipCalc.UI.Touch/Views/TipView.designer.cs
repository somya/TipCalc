// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace TipCalc.UI.Touch
{
	[Register ("TipView")]
	partial class TipView
	{
		[Outlet]
		MonoTouch.UIKit.UISlider GenerosiySlider { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField SubTotalTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TipLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (SubTotalTextField != null) {
				SubTotalTextField.Dispose ();
				SubTotalTextField = null;
			}

			if (GenerosiySlider != null) {
				GenerosiySlider.Dispose ();
				GenerosiySlider = null;
			}

			if (TipLabel != null) {
				TipLabel.Dispose ();
				TipLabel = null;
			}
		}
	}
}
