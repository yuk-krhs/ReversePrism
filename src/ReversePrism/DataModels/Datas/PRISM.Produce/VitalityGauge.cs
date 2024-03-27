using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackVitalityGauge                        0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 FrontVitalityGauge                       0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 FrontFillVitalityGauge                   0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 038 Vitality                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 NormalColor                              0001865AA8E0 ModelEnumType Color Color Color Int32
    // 050 EstimateColor                            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 060 BaseScheduleColor                        0001865AA8E0 ModelEnumType Color Color Color Int32
    // 070 NormalColorStringHexTag                  000186671910 ModelPrimitiveType string string string String
    // 078 EstimateColorStringHexTag                000186671910 ModelPrimitiveType string string string String
    // 080 BaseScheduleColorStringHexTag            000186671910 ModelPrimitiveType string string string String
    // 000 SeChangeLimit                            int IL2CPP_TYPE_I4
    // 000 SeBigCrease                              string IL2CPP_TYPE_STRING
    // 000 SeLittleCrease                           string IL2CPP_TYPE_STRING
    // 000 SeBigDecrease                            string IL2CPP_TYPE_STRING
    // 000 SeLittleDecrease                         string IL2CPP_TYPE_STRING
    public partial class VitalityGauge
    {
        public UIImage?                                 BackVitalityGauge                       { get; set; }
        public UIImage?                                 FrontVitalityGauge                      { get; set; }
        public UIImage?                                 FrontFillVitalityGauge                  { get; set; }
        public UITextMeshProUGUI?                       Vitality                                { get; set; }
        public Color                                    NormalColor                             { get; set; }
        public Color                                    EstimateColor                           { get; set; }
        public Color                                    BaseScheduleColor                       { get; set; }
        public string                                   NormalColorStringHexTag                 { get; set; }
        public string                                   EstimateColorStringHexTag               { get; set; }
        public string                                   BaseScheduleColorStringHexTag           { get; set; }

        public static VitalityGauge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VitalityGauge();

            value.BackVitalityGauge                         = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0270D4BADF70 0x20 BackVitalityGauge           ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.FrontVitalityGauge                        = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270D4BADF90 0x28 FrontVitalityGauge          ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.FrontFillVitalityGauge                    = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0270D4BADFB0 0x30 FrontFillVitalityGauge      ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.Vitality                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4BADFD0 0x38 Vitality                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NormalColor                               = (Color)GetInt32(new IntPtr(p + 0x040)); // 0270D4BADFF0 0x40 NormalColor                 ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.EstimateColor                             = (Color)GetInt32(new IntPtr(p + 0x050)); // 0270D4BAE010 0x50 EstimateColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.BaseScheduleColor                         = (Color)GetInt32(new IntPtr(p + 0x060)); // 0270D4BAE030 0x60 BaseScheduleColor           ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.NormalColorStringHexTag                   = GetString(new IntPtr(p + 0x070)); // 0270D4BAE050 0x70 NormalColorStringHexTag     ( 000186671910 ModelPrimitiveType string string string String )
            value.EstimateColorStringHexTag                 = GetString(new IntPtr(p + 0x078)); // 0270D4BAE070 0x78 EstimateColorStringHexTag   ( 000186671910 ModelPrimitiveType string string string String )
            value.BaseScheduleColorStringHexTag             = GetString(new IntPtr(p + 0x080)); // 0270D4BAE090 0x80 BaseScheduleColorStringHexTag ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
