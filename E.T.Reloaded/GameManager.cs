﻿using Aiv.Fast2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.T.Reloaded
{
    public static class GameManager
    {
		public static Window window;
		static RigidBody p1;

        static GameManager()
        {
            window = new Window(1280, 720, "Animations");
			p1 = new RigidBody();
        }

        public static void Play()
        {
            while (window.opened)
            {
				p1.Update ();
				window.Update();
            }
        }
    }
}
