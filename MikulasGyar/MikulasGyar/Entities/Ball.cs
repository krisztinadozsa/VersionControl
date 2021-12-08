﻿using MikulasGyar.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikulasGyar.Entities
{
    public class Ball : Toy
    {
        public SolidBrush BallBrush { get; private set; }

        public Ball(Color kívantszín)
        {
            BallBrush = new SolidBrush(kívantszín);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(BallBrush, 0, 0, Width, Height);
        }
        
            
        

        
    }
}
