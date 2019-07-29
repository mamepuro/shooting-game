using System;
namespace stgproto
{
    public class StraightMoveEnermyBullet:EnermyBullet
    {
        private asd.Vector2DF MoveVelocity;
        public StraightMoveEnermyBullet(asd.Vector2DF pos,asd.Vector2DF movevelocity)
            :base(pos)//基底クラス（EnermyBilletクラス)からposを引数として受け取る
        {
            MoveVelocity = movevelocity;
        }
        protected override void OnUpdate()
        {
            this.Position += MoveVelocity;
            DisposeFromGame();
            base.OnUpdate();
        }
    }
}
