using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Shadows                                  ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer
    // 040 Midtones                                 ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer
    // 048 Highlights                               ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer
    // 050 ShadowsStart                             ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer
    // 058 ShadowsEnd                               ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer
    // 060 HighlightsStart                          ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer
    // 068 HighlightsEnd                            ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer
    public partial class ShadowsMidtonesHighlights : DataModel
    {
        public Vector4Parameter?                        Shadows                                 { get; set; }
        public Vector4Parameter?                        Midtones                                { get; set; }
        public Vector4Parameter?                        Highlights                              { get; set; }
        public MinFloatParameter?                       ShadowsStart                            { get; set; }
        public MinFloatParameter?                       ShadowsEnd                              { get; set; }
        public MinFloatParameter?                       HighlightsStart                         { get; set; }
        public MinFloatParameter?                       HighlightsEnd                           { get; set; }

        public static ShadowsMidtonesHighlights? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShadowsMidtonesHighlights() { Pointer= p0 };

            value.Shadows                                   = GetObject<Vector4Parameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.Vector4Parameter.FromPointer); // 0x38 Shadows                     ( ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer )
            value.Midtones                                  = GetObject<Vector4Parameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.Vector4Parameter.FromPointer); // 0x40 Midtones                    ( ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer )
            value.Highlights                                = GetObject<Vector4Parameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.Vector4Parameter.FromPointer); // 0x48 Highlights                  ( ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer )
            value.ShadowsStart                              = GetObject<MinFloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.MinFloatParameter.FromPointer); // 0x50 ShadowsStart                ( ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer )
            value.ShadowsEnd                                = GetObject<MinFloatParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.MinFloatParameter.FromPointer); // 0x58 ShadowsEnd                  ( ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer )
            value.HighlightsStart                           = GetObject<MinFloatParameter>(new IntPtr(p + 0x060), ReversePrism.DataModels.MinFloatParameter.FromPointer); // 0x60 HighlightsStart             ( ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer )
            value.HighlightsEnd                             = GetObject<MinFloatParameter>(new IntPtr(p + 0x068), ReversePrism.DataModels.MinFloatParameter.FromPointer); // 0x68 HighlightsEnd               ( ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer )

            return value;
        }
    }
}
