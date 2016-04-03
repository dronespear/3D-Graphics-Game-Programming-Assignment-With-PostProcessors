using Microsoft.Xna.Framework.Graphics;
using Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s00130744Graphics.PostProcessors
{
    class AssignmentSceneCapture
    {
        RenderTarget2D RenderTarget;

        public AssignmentSceneCapture()
        {
            RenderTarget = new RenderTarget2D(
                GameUtilities.GraphicsDevice,
                GameUtilities.GraphicsDevice.PresentationParameters.BackBufferWidth,
                GameUtilities.GraphicsDevice.PresentationParameters.BackBufferHeight,
                false,
                SurfaceFormat.Color,
                DepthFormat.Depth24);
        }

        public void Begin()
        {
            GameUtilities.GraphicsDevice.SetRenderTarget(RenderTarget);
        }

        public void End()
        {
            GameUtilities.GraphicsDevice.SetRenderTarget(null);
        }

        public Texture GetTexture()
        {
            return RenderTarget;
        }
    }
}
