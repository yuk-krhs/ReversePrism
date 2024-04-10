using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Painter2D                              000186714D50 ModelClassType Painter2D Painter2D Painter2D Pointer
    // 000 s_AllocateMarker                         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 008 s_DrawVectorImageMarker                  ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 018 Painter                                  0001866626D0 ModelClassType IStylePainter IStylePainter IStylePainter Pointer
    public partial class MeshGenerationContext : DataModel
    {
        public Painter2D?                               M_Painter2D                             { get; set; }
        public IStylePainter?                           Painter                                 { get; set; }

        public static MeshGenerationContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshGenerationContext() { Pointer= p0 };

            value.M_Painter2D                               = GetObject<Painter2D>(new IntPtr(p + 0x010), ReversePrism.DataModels.Painter2D.FromPointer); // 0245A67AA5D8 0x10 M_Painter2D                 ( 000186714D50 ModelClassType Painter2D Painter2D Painter2D Pointer )
            value.Painter                                   = GetObject<IStylePainter>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStylePainter.FromPointer); // 0245A67AA638 0x18 Painter                     ( 0001866626D0 ModelClassType IStylePainter IStylePainter IStylePainter Pointer )

            return value;
        }
    }
}
