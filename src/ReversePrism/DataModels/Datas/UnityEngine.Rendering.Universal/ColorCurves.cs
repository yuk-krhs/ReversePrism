using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Master                                   ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer
    // 040 Red                                      ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer
    // 048 Green                                    ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer
    // 050 Blue                                     ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer
    // 058 HueVsHue                                 ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer
    // 060 HueVsSat                                 ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer
    // 068 SatVsSat                                 ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer
    // 070 LumVsSat                                 ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer
    public partial class ColorCurves : DataModel
    {
        public TextureCurveParameter?                   Master                                  { get; set; }
        public TextureCurveParameter?                   Red                                     { get; set; }
        public TextureCurveParameter?                   Green                                   { get; set; }
        public TextureCurveParameter?                   Blue                                    { get; set; }
        public TextureCurveParameter?                   HueVsHue                                { get; set; }
        public TextureCurveParameter?                   HueVsSat                                { get; set; }
        public TextureCurveParameter?                   SatVsSat                                { get; set; }
        public TextureCurveParameter?                   LumVsSat                                { get; set; }

        public static ColorCurves? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorCurves() { Pointer= p0 };

            value.Master                                    = GetObject<TextureCurveParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.TextureCurveParameter.FromPointer); // 0x38 Master                      ( ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer )
            value.Red                                       = GetObject<TextureCurveParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextureCurveParameter.FromPointer); // 0x40 Red                         ( ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer )
            value.Green                                     = GetObject<TextureCurveParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.TextureCurveParameter.FromPointer); // 0x48 Green                       ( ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer )
            value.Blue                                      = GetObject<TextureCurveParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.TextureCurveParameter.FromPointer); // 0x50 Blue                        ( ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer )
            value.HueVsHue                                  = GetObject<TextureCurveParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.TextureCurveParameter.FromPointer); // 0x58 HueVsHue                    ( ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer )
            value.HueVsSat                                  = GetObject<TextureCurveParameter>(new IntPtr(p + 0x060), ReversePrism.DataModels.TextureCurveParameter.FromPointer); // 0x60 HueVsSat                    ( ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer )
            value.SatVsSat                                  = GetObject<TextureCurveParameter>(new IntPtr(p + 0x068), ReversePrism.DataModels.TextureCurveParameter.FromPointer); // 0x68 SatVsSat                    ( ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer )
            value.LumVsSat                                  = GetObject<TextureCurveParameter>(new IntPtr(p + 0x070), ReversePrism.DataModels.TextureCurveParameter.FromPointer); // 0x70 LumVsSat                    ( ModelClassType TextureCurveParameter TextureCurveParameter TextureCurveParameter Pointer )

            return value;
        }
    }
}
