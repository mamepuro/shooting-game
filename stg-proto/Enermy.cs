using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace stgproto
{
    public abstract class Enermy:CollidableObject
    {
        protected int count;
        protected Player player;//playerインスタンスへの参照（playerの座標等を受け取る)
        public Enermy(asd.Vector2DF pos, Player player)//引数として継承先のenermyインスタンスの座標とplayerの情報を入れる
            :base()//基底クラスから何を引数として受け取るか指定
        {
            Position = pos;//変数posをプロパティにPostisionプロパティに入れる
            Texture = asd.Engine.Graphics.CreateTexture2D("Resources/Enermy.png");
            CenterPosition = new asd.Vector2DF(Texture.Size.X/2.0f, Texture.Size.Y/2.0f);
            count = 0;
            this.player = player;//Enermyクラスで使うplayer参照は、インスタンスplayerの情報（インスタンスの情報は引数として既に受け取っている）
        }

        //衝突時の処理
        public override void Oncollide(CollidableObject obj)
        {
            base.Oncollide(obj);
            Dispose();
        }

        public void CollideWith(CollidableObject obj)//衝突の判定メソッド
        {
            if (obj == null)
                return;

            if(obj is Player)
            {
                CollidableObject player = obj;//衝突したオブジェクトがplayerであることを明示

                if (IsCollidable(player))
                {
                    Oncollide(player);
                    Oncollide(this);
                }
            }
        }

        protected override void OnUpdate()//Altseedアップデート時に実行されるメソッド
        {
            foreach (var obj in Layer.Objects)
                CollideWith(obj as CollidableObject);

            count++;
        }

        //画面外に出たら削除するメソッド
        protected  void DisposeFromgame()
        {
            var WindowSise = asd.Engine.WindowSize;//変数WindowSizeを宣言
            if (this.Position.Y < -Texture.Size.Y || this.Position.Y > Texture.Size.Y + asd.Engine.WindowSize.Y || this.Position.X < -asd.Engine.WindowSize.X || this.Position.X > this.Texture.Size.X + asd.Engine.WindowSize.X)
            {
                Dispose();
            }
        }
    }
}
