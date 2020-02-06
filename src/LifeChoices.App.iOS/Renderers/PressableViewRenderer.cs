﻿using System;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using LifeChoices.App.Content.Scenarios.OtherLogin.Controls;
using LifeChoices.App.iOS.Renderers;

[assembly: ExportRenderer(typeof(PressableView), typeof(PressableViewRenderer))]

namespace LifeChoices.App.iOS.Renderers
{
    public class PressableViewRenderer : VisualElementRenderer<PressableView>
    {
        public PressableViewRenderer()
        {
            UserInteractionEnabled = true;
        }

        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);

            Element?.RaisePressed();
        }

        public override void TouchesCancelled(NSSet touches, UIEvent evt)
        {
            base.TouchesCancelled(touches, evt);

            Element?.RaiseReleased();
        }

        public override void TouchesEnded(NSSet touches, UIEvent evt)
        {
            base.TouchesEnded(touches, evt);

            Element?.RaiseReleased();
        }
    }
}
