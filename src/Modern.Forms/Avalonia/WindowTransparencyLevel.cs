﻿#nullable disable

namespace Avalonia.Controls
{
    internal enum WindowTransparencyLevel
    {
        /// <summary>
        /// The window background is Black where nothing is drawn in the window.
        /// </summary>
        None,

        /// <summary>
        /// The window background is Transparent where nothing is drawn in the window.
        /// </summary>
        Transparent,

        /// <summary>
        /// The window background is a blur-behind where nothing is drawn in the window.
        /// </summary>
        Blur,

        /// <summary>
        /// The window background is a blur-behind with a high blur radius. This level may fallback to Blur.
        /// </summary>
        AcrylicBlur
    }
}
