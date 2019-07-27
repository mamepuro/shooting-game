﻿using System;
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
            // Altseedを初期化する。
            asd.Engine.Initialize("STG", 640, 480, new asd.EngineOption());

            // プレイヤーのインスタンスを生成する。
            asd.TextureObject2D player = new asd.TextureObject2D();

            // 画像を読み込み、プレイヤーのインスタンスに画像を設定する。
            player.Texture = asd.Engine.Graphics.CreateTexture2D("Resources/Player.png");

            // エンジンにプレイヤーのインスタンスを追加する。
            asd.Engine.AddObject2D(player);


            // Altseedのウインドウが閉じられていないか確認する。
            while (asd.Engine.DoEvents())
            {
                // もし、Escキーが押されていたらwhileループを抜ける。
                if (asd.Engine.Keyboard.GetKeyState(asd.Keys.Escape) == asd.KeyState.Push)
                {
                    break;
                }

                // Altseedを更新する。
                asd.Engine.Update();
            }
        }
    }
}
