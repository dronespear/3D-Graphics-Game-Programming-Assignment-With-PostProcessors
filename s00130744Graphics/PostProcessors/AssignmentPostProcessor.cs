using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s00130744Graphics.PostProcessors
{
    class AssignmentPostProcessor
    {
        //pixel shader effect
        public Effect Effect { get; set; }

        public Texture2D InputTexture { get; set; }
        protected static SpriteBatch sbatch { get; set; }

        public AssignmentPostProcessor()
        {
            if (sbatch != null)
                sbatch = new SpriteBatch(GameUtilities.GraphicsDevice);
        }

        public virtual void LoadContent()
        {

        }

        public virtual void Draw()
        {
            sbatch.Begin(SpriteSortMode.Immediate, BlendState.Opaque);

            Effect.CurrentTechnique.Passes[0].Apply();

            sbatch.Draw
                (InputTexture,
                GameUtilities.GraphicsDevice.Viewport.Bounds,
                Color.White);

            sbatch.End();

            GameUtilities.SetGraphicsDeviceFor3D();
        }
    }
}
