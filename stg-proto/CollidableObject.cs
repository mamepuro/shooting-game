using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace stgproto
{
    public class CollidableObject:asd.TextureObject2D
    {
        public float Radius = 0.0f;

        public bool IsCollidable(CollidableObject o)//衝突しているか返す
        {
            return (o.Position - Position).Length < Radius + o.Radius;
        }


        public virtual void Oncollide(CollidableObject obj)//衝突時に実行するメソッド（継承先で実行内容を記述）
        {

        }

    }
}
