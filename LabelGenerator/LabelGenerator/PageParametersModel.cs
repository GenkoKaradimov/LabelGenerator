using System;
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
            ContentToLeftCellBorder = 45f;

            ContentToBottomCellBorder = 75f;

            CellWidth = 294.3f;

            CellHeight = 104.8f;

            TextHeight = 15f;

            ImageSize = 65f;

            DistanceImageToText = 15f;

            CorrectionImageVerticalPosition = -50f;
        }
    }
}
