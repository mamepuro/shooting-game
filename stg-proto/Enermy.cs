using System;
namespace stgproto
{
    public abstract class Enermy:CollidableObject
    {
        protected int count;

        protected Player player;//playerインスタンスへの参照（playerの座標等を受け取る）

        public Enermy(asd.Vector2DF pos, Player player)//引数として継承先のenermyインスタンスの座標とplayerの情報を入れる
            :base()//基底クラスであることを明示
        {
            Position = pos;//変数posをプロパティにPostisionプロパティに入れる
            Texture = asd.Engine.Graphics.CreateTexture2D("Resources/Enermy.png");
            CenterPosition = new asd.Vector2DF(Texture.Size.X/2.0f, Texture.Size.Y/2.0f);

        }

        //衝突時の処理
        public override void Oncollide(CollidableObject obj)
        {
            base.Oncollide(obj);
            Dispose();
        }

        public void CollideWith(CollidableObject obj)
        {
            if (obj == null)
                return;

            if(obj is Player)
            {
                CollidableObject player = obj;//

                if (IsCollidable(player))
                {
                    Oncollide(player);
                    Oncollide(this);
                }
            }
        }

        protected override void OnUpdate()
        {
            foreach(obj)
        }
    }
}
