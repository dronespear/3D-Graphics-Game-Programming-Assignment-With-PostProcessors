

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s00130744Graphics.PostProcessors
{
    class AssignmentColorTintProcessor : AssignmentPostProcessor
    {
        public Color TintColor { get; set; }

        public AssignmentColorTintProcessor(Color color) : base()
        {
            TintColor = color;
        }

        public override void LoadContent()
        {
            Effect = GameUtilities.Content.Load<Effect>("Effects\\TintEffect");
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
