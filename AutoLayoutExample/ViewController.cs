using System;

using UIKit;
using Pop;
using Foundation;

namespace AutoLayoutExample
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void ChangeViewPressed (Foundation.NSObject sender)
        {
            var button = sender as UIButton;
            button.Selected = !button.Selected;


            var animation = POPSpringAnimation.AnimationWithPropertyNamed (POPAnimation.LayoutConstraintConstant);
            animation.ToValue = new NSNumber(button.Selected ? (ContainerViewWidthConstraint.Constant + 16) * -1 : 0);
            ContainerViewConstraint.AddAnimation (animation, "constraint");
        }
    }
}

