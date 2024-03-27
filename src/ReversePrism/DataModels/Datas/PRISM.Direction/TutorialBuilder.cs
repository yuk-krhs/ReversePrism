using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ViewKey                                  string IL2CPP_TYPE_STRING
    // 010 UiCanvasManager                          0001866E22B0 ModelClassType UICanvasManager UICanvasManager UICanvasManager Pointer
    public partial class TutorialBuilder
    {
        public UICanvasManager?                         UiCanvasManager                         { get; set; }

        public static TutorialBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialBuilder();

            value.UiCanvasManager                           = GetObject<UICanvasManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.UICanvasManager.FromPointer); // 027003A65BC0 0x10 UiCanvasManager             ( 0001866E22B0 ModelClassType UICanvasManager UICanvasManager UICanvasManager Pointer )

            return value;
        }
    }
}
