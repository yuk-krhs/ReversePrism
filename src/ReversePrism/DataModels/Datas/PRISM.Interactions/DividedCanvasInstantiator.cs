using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CanvasPrefab                             000186540570 ModelClassType Canvas Canvas Canvas Pointer
    // 018 CanvasManager                            0001866E22B0 ModelClassType UICanvasManager UICanvasManager UICanvasManager Pointer
    public partial class DividedCanvasInstantiator
    {
        public Canvas?                                  CanvasPrefab                            { get; set; }
        public UICanvasManager?                         CanvasManager                           { get; set; }

        public static DividedCanvasInstantiator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DividedCanvasInstantiator();

            value.CanvasPrefab                              = GetObject<Canvas>(new IntPtr(p + 0x010), ReversePrism.DataModels.Canvas.FromPointer); // 027003A32A38 0x10 CanvasPrefab                ( 000186540570 ModelClassType Canvas Canvas Canvas Pointer )
            value.CanvasManager                             = GetObject<UICanvasManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.UICanvasManager.FromPointer); // 027003A32A58 0x18 CanvasManager               ( 0001866E22B0 ModelClassType UICanvasManager UICanvasManager UICanvasManager Pointer )

            return value;
        }
    }
}
