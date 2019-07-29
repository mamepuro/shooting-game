using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace stgproto
{
    public class NomalEnermy:Enermy
    {
        private asd.Vector2DF MoveVector;
        public NomalEnermy(asd.Vector2DF pos, asd.Vector2DF movevector, Player player)
            : base(pos, player)
        {
            MoveVector = movevector;//MoveVectorプロパティにmovevelocity変数を入れる
        }

        protected override void OnUpdate()
        {
            this.Position += this.MoveVector;
            DisposeFromgame();
            if(count % 60 == 0)
            {
                asd.Vector2DF direction = player.Position - this.Position;
                asd.Vector2DF MoveVelocity = direction.Normal * 1.5f;
                asd.Engine.AddObject2D(new StraightMoveEnermyBullet(this.Position, MoveVelocity));
            }
            base.OnUpdate();
        }
    }
}
