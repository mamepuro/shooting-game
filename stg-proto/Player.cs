using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace stgproto
{
    public class Player : CollidableObject
    {
        private int boxcount;
        public int Boxcount//プロパティの宣言
        {
            set  { boxcount = value;}
            get { return boxcount; }

        }

        public Player()//constructor
        {
            Texture = asd.Engine.Graphics.CreateTexture2D("Resources/player.png");
            CenterPosition = new asd.Vector2DF(Texture.Size.X / 2.0f, Texture.Size.Y / 2.0f);
            Position = new asd.Vector2DF(Texture.Size.X / 2.0f, asd.Engine.WindowSize.Y/2.0f);
            Radius = Texture.Size.Y / 2.0f;
        }
        //Move method
        public void Move()
        {

            if (asd.Engine.Keyboard.GetKeyState(asd.Keys.Up) == asd.KeyState.Hold)
            {
                this.Position = Position + new asd.Vector2DF(0, -3);
            }
            if (asd.Engine.Keyboard.GetKeyState(asd.Keys.Down) == asd.KeyState.Hold)
            {
                Position = Position + new asd.Vector2DF(0, 3);
            }
            if (asd.Engine.Keyboard.GetKeyState(asd.Keys.Left) == asd.KeyState.Hold)
            {
                Position = Position + new asd.Vector2DF(-3, 0);
            }
            if (asd.Engine.Keyboard.GetKeyState(asd.Keys.Right) == asd.KeyState.Hold)
            {
                Position = Position + new asd.Vector2DF(3, 0);
            }
            asd.Vector2DF potision = Position;//変数potisionの定義 asd.Vector2DFは型？？

            potision.X = asd.MathHelper.Clamp(potision.X, asd.Engine.WindowSize.X - Texture.Size.X / 2.0f, Texture.Size.X / 2.0f);//asd.MathHelper.Clamp(制御したい変数,最大値,最小値)
            potision.Y = asd.MathHelper.Clamp(potision.Y, asd.Engine.WindowSize.Y - Texture.Size.Y / 2.0f, Texture.Size.Y / 2.0f);

            this.Position = potision;//Potisionプロパティに変数potisionの値をいれるよ           
        }
        //衝突時の動作
        public override void Oncollide(CollidableObject obj)
        {
            base.Oncollide(obj);
            Dispose();
        }
    }
}
