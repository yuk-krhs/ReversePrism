using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CanvasPrefab                             ModelClassType Canvas Canvas Canvas Pointer
    // 018 CanvasManager                            ModelClassType UICanvasManager UICanvasManager UICanvasManager Pointer
    public partial class DividedCanvasInstantiator : DataModel
    {
        public Canvas?                                  CanvasPrefab                            { get; set; }
        public UICanvasManager?                         CanvasManager                           { get; set; }

        public static DividedCanvasInstantiator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DividedCanvasInstantiator() { Pointer= p0 };

            value.CanvasPrefab                              = GetObject<Canvas>(new IntPtr(p + 0x010), ReversePrism.DataModels.Canvas.FromPointer); // 0x10 CanvasPrefab                ( ModelClassType Canvas Canvas Canvas Pointer )
            value.CanvasManager                             = GetObject<UICanvasManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.UICanvasManager.FromPointer); // 0x18 CanvasManager               ( ModelClassType UICanvasManager UICanvasManager UICanvasManager Pointer )

            return value;
        }
    }
}
