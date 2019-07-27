using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace stgproto
{
    public class Box:CollidableObject
    {
        //constructor
        public Box()
        {
            Texture = asd.Engine.Graphics.CreateTexture2D("Resources/box.png");
            CenterPosition = new asd.Vector2DF(Texture.Size.X / 2.0f, Texture.Size.Y / 2.0f);
            Position = new asd.Vector2DF(asd.Engine.WindowSize.X / 2.0f, asd.Engine.WindowSize.Y / 2.0f);
            Radius = Texture.Size.Y / 2.0f;

        }

        //衝突時の動作
        public override void Oncollide(CollidableObject obj)
        {
            base.Oncollide(obj);
            Dispose();
        }

        //自機との当たり判定を管理するメソッド
        public void CollideWith(CollidableObject obj)
        {
            if (obj == null)//衝突判定するオブジェクトがなければ何も無し
                return;

            if(obj is Player)
            {
                CollidableObject player = obj;//playerが衝突したオブジェクトであることを明示


                if (IsCollidable(player))
                {
                    Oncollide(this);//BoxにOncollideメッソドを適用する
                }
            }
        }

        //Altseedを更新した時に動くメソッド
        protected override void OnUpdate()
        {
            foreach (var obj in Layer.Objects)
                CollideWith(obj as CollidableObject);
        }

    }
}
