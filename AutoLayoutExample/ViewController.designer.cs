// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace AutoLayoutExample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.NSLayoutConstraint ContainerViewConstraint { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint ContainerViewWidthConstraint { get; set; }

		[Action ("ChangeViewPressed:")]
		partial void ChangeViewPressed (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ContainerViewWidthConstraint != null) {
				ContainerViewWidthConstraint.Dispose ();
				ContainerViewWidthConstraint = null;
			}

			if (ContainerViewConstraint != null) {
				ContainerViewConstraint.Dispose ();
				ContainerViewConstraint = null;
			}
		}
	}
}
