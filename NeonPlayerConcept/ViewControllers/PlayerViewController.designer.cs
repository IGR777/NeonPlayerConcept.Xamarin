// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NeonPlayerConcept.iOS.ViewControllers
{
    [Register ("PlayerViewController")]
    partial class PlayerViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView PlayerScreenImage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (PlayerScreenImage != null) {
                PlayerScreenImage.Dispose ();
                PlayerScreenImage = null;
            }
        }
    }
}