﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelGenerator
{
    public class PageParametersModel
    {
        public float ContentToLeftCellBorder { get; set; }

        public float ContentToBottomCellBorder { get; set; }

        public float CellWidth { get; set; }

        public float CellHeight { get; set; }

        public float TextHeight { get; set; }

        public float ImageSize { get; set; }

        public float DistanceImageToText { get; set; }

        public float CorrectionImageVerticalPosition { get; set; }

        public PageParametersModel()
        {
            ContentToLeftCellBorder = 50;

            ContentToBottomCellBorder = 50;

            CellWidth = 250;

            CellHeight = 110;

            TextHeight = 15;

            ImageSize = 65;

            DistanceImageToText = 15;

            CorrectionImageVerticalPosition = -50;
        }
    }
}
