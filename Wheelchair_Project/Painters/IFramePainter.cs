﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheelchair_Project.Painters
{
    public interface IFramePainter
    {
        public string PaintColorName { get; set; }
        public int Cyan { get; set; }
        public int Magenta { get; set; }
        public int Yellow { get; set; }
        public int Black { get; set; }

        public void MixPaint();
        public void PaintFrame();
        public void ApplyTopCoat();
    }
}
