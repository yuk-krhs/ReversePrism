using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MFovSoftGuideRect                        ModelEnumType Rect Rect Rect Int32
    // 020 MFovHardGuideRect                        ModelEnumType Rect Rect Rect Int32
    // 030 MFovH                                    ModelPrimitiveType float float float Single
    // 034 MFov                                     ModelPrimitiveType float float float Single
    // 038 MOrthoSizeOverDistance                   ModelPrimitiveType float float float Single
    // 03C MAspect                                  ModelPrimitiveType float float float Single
    // 040 MSoftGuideRect                           ModelEnumType Rect Rect Rect Int32
    // 050 MHardGuideRect                           ModelEnumType Rect Rect Rect Int32
    public partial class FovCache : DataModel
    {
        public Rect                                     MFovSoftGuideRect                       { get; set; }
        public Rect                                     MFovHardGuideRect                       { get; set; }
        public float                                    MFovH                                   { get; set; }
        public float                                    MFov                                    { get; set; }
        public float                                    MOrthoSizeOverDistance                  { get; set; }
        public float                                    MAspect                                 { get; set; }
        public Rect                                     MSoftGuideRect                          { get; set; }
        public Rect                                     MHardGuideRect                          { get; set; }

        public static FovCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FovCache() { Pointer= p0 };

            value.MFovSoftGuideRect                         = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0x10 MFovSoftGuideRect           ( ModelEnumType Rect Rect Rect Int32 )
            value.MFovHardGuideRect                         = (Rect)GetInt32(new IntPtr(p + 0x020)); // 0x20 MFovHardGuideRect           ( ModelEnumType Rect Rect Rect Int32 )
            value.MFovH                                     = GetSingle(new IntPtr(p + 0x030)); // 0x30 MFovH                       ( ModelPrimitiveType float float float Single )
            value.MFov                                      = GetSingle(new IntPtr(p + 0x034)); // 0x34 MFov                        ( ModelPrimitiveType float float float Single )
            value.MOrthoSizeOverDistance                    = GetSingle(new IntPtr(p + 0x038)); // 0x38 MOrthoSizeOverDistance      ( ModelPrimitiveType float float float Single )
            value.MAspect                                   = GetSingle(new IntPtr(p + 0x03C)); // 0x3C MAspect                     ( ModelPrimitiveType float float float Single )
            value.MSoftGuideRect                            = (Rect)GetInt32(new IntPtr(p + 0x040)); // 0x40 MSoftGuideRect              ( ModelEnumType Rect Rect Rect Int32 )
            value.MHardGuideRect                            = (Rect)GetInt32(new IntPtr(p + 0x050)); // 0x50 MHardGuideRect              ( ModelEnumType Rect Rect Rect Int32 )

            return value;
        }
    }
}
