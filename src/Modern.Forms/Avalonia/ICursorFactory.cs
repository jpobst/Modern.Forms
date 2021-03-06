#nullable disable

using Avalonia.Input;

#nullable enable

namespace Avalonia.Platform
{
    internal interface ICursorFactory
    {
        ICursorImpl GetCursor(StandardCursorType cursorType);
        ICursorImpl CreateCursor(IBitmapImpl cursor, PixelPoint hotSpot);
    }
}
