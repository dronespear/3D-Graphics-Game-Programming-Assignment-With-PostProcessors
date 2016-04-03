using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s00130744Graphics.PostProcessors
{
    class AssignmentBlendTextureProcessor : AssignmentPostProcessor
    {
        public AssignmentBlendTextureProcessor() : base()
        {

        }

        public override void LoadContent()
        {
            Effect = GameUtilities.Content.Load<Effect>("Effects\\TintEffect");
            Texture = GameUtilities.Content.Load<Texture2D>("Texture\\Noise");
            base.LoadContent();
        }

        public override void Draw()
        {

            if (Effect.Parameters["BlendTexture"] != null)
                Effect.Parameters["BlendTexture"].SetValue(Texture);
            base.Draw();
        }
    }
}
