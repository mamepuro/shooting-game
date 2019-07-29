using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace stgproto
{
    public class GameScene:asd.Scene
    {
        public GameScene()
        { }

            protected override void OnRegistered()
            {
                asd.Layer2D layer = new asd.Layer2D();
                AddLayer(layer);
                Player player = new Player();
                layer.AddObject(player);
                base.OnRegistered();
            layer.AddObject(new NomalEnermy(new asd.Vector2DF(320.0f, 400.0f), new asd.Vector2DF(3.0f,0),player));
            }
        protected override void OnUpdated()
        {
            base.OnUpdated();
        }
    }
}
