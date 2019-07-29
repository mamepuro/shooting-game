using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace stgproto
{
    public class EnermyBullet : CollidableObject
    {


        public EnermyBullet(asd.Vector2DF pos)
            : base()
        {
            Texture = asd.Engine.Graphics.CreateTexture2D("Resources/EnermyBullet");
            CenterPosition = new asd.Vector2DF(Texture.Size.X / 2.0f, Texture.Size.Y / 2.0f);
            this.Position = pos;
        }
        protected void DisposeFromGame()
        {
            var WindowSise = asd.Engine.WindowSize;//変数WindowSizeを宣言
            if (this.Position.Y < -Texture.Size.Y || this.Position.Y > Texture.Size.Y + asd.Engine.WindowSize.Y || this.Position.X < -asd.Engine.WindowSize.X || this.Position.X > this.Texture.Size.X + asd.Engine.WindowSize.X)
            {
                Dispose();
            }
            base.OnUpdate();
        }
    }
}
