using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s00130744Graphics.PostProcessors
{
    class AssignmentGrayScaleProcessor : AssignmentPostProcessor
    {
        public Color TintColor { get; set; }

        public AssignmentGrayScaleProcessor() : base()
        {

        }

        public override void LoadContent()
        {
            Effect = GameUtilities.Content.Load<Effect>("Effects\\GrayScaleEffect");
            base.LoadContent();
        }

        public override void Draw()
        {
            if (Effect.Parameters["Tint"] != null)
                Effect.Parameters["Tint"].SetValue(TintColor.ToVector3());
            base.Draw();
        }
    }
}