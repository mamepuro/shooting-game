using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stgproto
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            asd.Engine.Initialize("Stgproto", 800, 600,new asd.EngineOption());
            TitleScene title = new TitleScene();
            asd.Engine.ChangeSceneWithTransition(title, new asd.TransitionFade(1.0f, 1.0f));
            while (asd.Engine.DoEvents())
            {
                
                if (asd.Engine.Keyboard.GetKeyState(asd.Keys.Escape) == asd.KeyState.Push)
                {
                    break;
                }
                
                //player.Move();

                // Altseedを更新する。
                asd.Engine.Update();
            }




           // Altseedの終了処理をする。
            asd.Engine.Terminate();



        }
    }
}
