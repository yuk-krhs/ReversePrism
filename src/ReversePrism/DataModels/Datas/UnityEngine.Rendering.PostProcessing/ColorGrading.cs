using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 GradingMode                              000186690EB0 ModelClassType GradingModeParameter GradingModeParameter GradingModeParameter Pointer
    // 038 ExternalLut                              0001866553C0 ModelClassType TextureParameter TextureParameter TextureParameter Pointer
    // 040 Tonemapper                               00018668B0B0 ModelClassType TonemapperParameter TonemapperParameter TonemapperParameter Pointer
    // 048 ToneCurveToeStrength                     0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 050 ToneCurveToeLength                       0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 058 ToneCurveShoulderStrength                0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 060 ToneCurveShoulderLength                  0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 068 ToneCurveShoulderAngle                   0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 070 ToneCurveGamma                           0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 078 LdrLut                                   0001866553C0 ModelClassType TextureParameter TextureParameter TextureParameter Pointer
    // 080 LdrLutContribution                       0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 088 ColorFilter                              0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 090 HueShift                                 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 098 Saturation                               0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 0A0 Brightness                               0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 0A8 PostExposure                             0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 0B0 Contrast                                 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 0B8 Lift                                     000186779F30 ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer
    // 0C0 Gamma                                    000186779F30 ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer
    // 0C8 Gain                                     000186779F30 ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer
    // 0D0 MasterCurve                              00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer
    // 0D8 RedCurve                                 00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer
    // 0E0 GreenCurve                               00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer
    // 0E8 BlueCurve                                00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer
    // 0F0 HueVsHueCurve                            00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer
    // 0F8 HueVsSatCurve                            00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer
    // 100 SatVsSatCurve                            00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer
    // 108 LumVsSatCurve                            00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer
    public partial class ColorGrading
    {
        public GradingModeParameter?                    GradingMode                             { get; set; }
        public TextureParameter?                        ExternalLut                             { get; set; }
        public TonemapperParameter?                     Tonemapper                              { get; set; }
        public FloatParameter?                          ToneCurveToeStrength                    { get; set; }
        public FloatParameter?                          ToneCurveToeLength                      { get; set; }
        public FloatParameter?                          ToneCurveShoulderStrength               { get; set; }
        public FloatParameter?                          ToneCurveShoulderLength                 { get; set; }
        public FloatParameter?                          ToneCurveShoulderAngle                  { get; set; }
        public FloatParameter?                          ToneCurveGamma                          { get; set; }
        public TextureParameter?                        LdrLut                                  { get; set; }
        public FloatParameter?                          LdrLutContribution                      { get; set; }
        public ColorParameter?                          ColorFilter                             { get; set; }
        public FloatParameter?                          HueShift                                { get; set; }
        public FloatParameter?                          Saturation                              { get; set; }
        public FloatParameter?                          Brightness                              { get; set; }
        public FloatParameter?                          PostExposure                            { get; set; }
        public FloatParameter?                          Contrast                                { get; set; }
        public Vector4Parameter?                        Lift                                    { get; set; }
        public Vector4Parameter?                        Gamma                                   { get; set; }
        public Vector4Parameter?                        Gain                                    { get; set; }
        public SplineParameter?                         MasterCurve                             { get; set; }
        public SplineParameter?                         RedCurve                                { get; set; }
        public SplineParameter?                         GreenCurve                              { get; set; }
        public SplineParameter?                         BlueCurve                               { get; set; }
        public SplineParameter?                         HueVsHueCurve                           { get; set; }
        public SplineParameter?                         HueVsSatCurve                           { get; set; }
        public SplineParameter?                         SatVsSatCurve                           { get; set; }
        public SplineParameter?                         LumVsSatCurve                           { get; set; }

        public static ColorGrading? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorGrading();

            value.GradingMode                               = GetObject<GradingModeParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.GradingModeParameter.FromPointer); // 027006123AF0 0x30 GradingMode                 ( 000186690EB0 ModelClassType GradingModeParameter GradingModeParameter GradingModeParameter Pointer )
            value.ExternalLut                               = GetObject<TextureParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.TextureParameter.FromPointer); // 027006123B10 0x38 ExternalLut                 ( 0001866553C0 ModelClassType TextureParameter TextureParameter TextureParameter Pointer )
            value.Tonemapper                                = GetObject<TonemapperParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.TonemapperParameter.FromPointer); // 027006123B30 0x40 Tonemapper                  ( 00018668B0B0 ModelClassType TonemapperParameter TonemapperParameter TonemapperParameter Pointer )
            value.ToneCurveToeStrength                      = GetObject<FloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.FloatParameter.FromPointer); // 027006123B50 0x48 ToneCurveToeStrength        ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.ToneCurveToeLength                        = GetObject<FloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.FloatParameter.FromPointer); // 027006123B70 0x50 ToneCurveToeLength          ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.ToneCurveShoulderStrength                 = GetObject<FloatParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.FloatParameter.FromPointer); // 027006123B90 0x58 ToneCurveShoulderStrength   ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.ToneCurveShoulderLength                   = GetObject<FloatParameter>(new IntPtr(p + 0x060), ReversePrism.DataModels.FloatParameter.FromPointer); // 027006123BB0 0x60 ToneCurveShoulderLength     ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.ToneCurveShoulderAngle                    = GetObject<FloatParameter>(new IntPtr(p + 0x068), ReversePrism.DataModels.FloatParameter.FromPointer); // 027006123BD0 0x68 ToneCurveShoulderAngle      ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.ToneCurveGamma                            = GetObject<FloatParameter>(new IntPtr(p + 0x070), ReversePrism.DataModels.FloatParameter.FromPointer); // 027006123BF0 0x70 ToneCurveGamma              ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.LdrLut                                    = GetObject<TextureParameter>(new IntPtr(p + 0x078), ReversePrism.DataModels.TextureParameter.FromPointer); // 027006123C10 0x78 LdrLut                      ( 0001866553C0 ModelClassType TextureParameter TextureParameter TextureParameter Pointer )
            value.LdrLutContribution                        = GetObject<FloatParameter>(new IntPtr(p + 0x080), ReversePrism.DataModels.FloatParameter.FromPointer); // 027006123C30 0x80 LdrLutContribution          ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.ColorFilter                               = GetObject<ColorParameter>(new IntPtr(p + 0x088), ReversePrism.DataModels.ColorParameter.FromPointer); // 027006123C50 0x88 ColorFilter                 ( 0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.HueShift                                  = GetObject<FloatParameter>(new IntPtr(p + 0x090), ReversePrism.DataModels.FloatParameter.FromPointer); // 027006123C70 0x90 HueShift                    ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Saturation                                = GetObject<FloatParameter>(new IntPtr(p + 0x098), ReversePrism.DataModels.FloatParameter.FromPointer); // 027006123C90 0x98 Saturation                  ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Brightness                                = GetObject<FloatParameter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.FloatParameter.FromPointer); // 027006123CB0 0xA0 Brightness                  ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.PostExposure                              = GetObject<FloatParameter>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.FloatParameter.FromPointer); // 027006123CD0 0xA8 PostExposure                ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Contrast                                  = GetObject<FloatParameter>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.FloatParameter.FromPointer); // 027006123CF0 0xB0 Contrast                    ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Lift                                      = GetObject<Vector4Parameter>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Vector4Parameter.FromPointer); // 027006123D10 0xB8 Lift                        ( 000186779F30 ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer )
            value.Gamma                                     = GetObject<Vector4Parameter>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Vector4Parameter.FromPointer); // 027006123D30 0xC0 Gamma                       ( 000186779F30 ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer )
            value.Gain                                      = GetObject<Vector4Parameter>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Vector4Parameter.FromPointer); // 027006123D50 0xC8 Gain                        ( 000186779F30 ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer )
            value.MasterCurve                               = GetObject<SplineParameter>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.SplineParameter.FromPointer); // 027006123D70 0xD0 MasterCurve                 ( 00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer )
            value.RedCurve                                  = GetObject<SplineParameter>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.SplineParameter.FromPointer); // 027006123D90 0xD8 RedCurve                    ( 00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer )
            value.GreenCurve                                = GetObject<SplineParameter>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.SplineParameter.FromPointer); // 027006123DB0 0xE0 GreenCurve                  ( 00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer )
            value.BlueCurve                                 = GetObject<SplineParameter>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.SplineParameter.FromPointer); // 027006123DD0 0xE8 BlueCurve                   ( 00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer )
            value.HueVsHueCurve                             = GetObject<SplineParameter>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.SplineParameter.FromPointer); // 027006123DF0 0xF0 HueVsHueCurve               ( 00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer )
            value.HueVsSatCurve                             = GetObject<SplineParameter>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.SplineParameter.FromPointer); // 027006123E10 0xF8 HueVsSatCurve               ( 00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer )
            value.SatVsSatCurve                             = GetObject<SplineParameter>(new IntPtr(p + 0x100), ReversePrism.DataModels.SplineParameter.FromPointer); // 027006123E30 0x100 SatVsSatCurve               ( 00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer )
            value.LumVsSatCurve                             = GetObject<SplineParameter>(new IntPtr(p + 0x108), ReversePrism.DataModels.SplineParameter.FromPointer); // 027006123E50 0x108 LumVsSatCurve               ( 00018654DBF0 ModelClassType SplineParameter SplineParameter SplineParameter Pointer )

            return value;
        }
    }
}
