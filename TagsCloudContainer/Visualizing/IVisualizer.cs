﻿using System.Collections.Generic;
using System.Drawing;

namespace TagsCloudContainer.Visualizing
{
    public interface IVisualizer
    {
        Bitmap GetLayoutBitmap(IEnumerable<(string, Rectangle)> wordsInRectangles, List<Color> colors, Font font,
            Size imageSize);
    }
}