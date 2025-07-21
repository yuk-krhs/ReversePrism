using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackVitalityGauge                        ModelClassType UIImage UIImage UIImage Pointer
    // 028 FrontVitalityGauge                       ModelClassType UIImage UIImage UIImage Pointer
    // 030 FrontFillVitalityGauge                   ModelClassType UIImage UIImage UIImage Pointer
    // 038 Vitality                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 NormalColor                              ModelEnumType Color Color Color Int32
    // 050 EstimateColor                            ModelEnumType Color Color Color Int32
    // 060 BaseScheduleColor                        ModelEnumType Color Color Color Int32
    // 070 NormalColorStringHexTag                  ModelPrimitiveType string string string String
    // 078 EstimateColorStringHexTag                ModelPrimitiveType string string string String
    // 080 BaseScheduleColorStringHexTag            ModelPrimitiveType string string string String
    // 000 SeChangeLimit                            int IL2CPP_TYPE_I4
    // 000 SeBigCrease                              string IL2CPP_TYPE_STRING
    // 000 SeLittleCrease                           string IL2CPP_TYPE_STRING
    // 000 SeBigDecrease                            string IL2CPP_TYPE_STRING
    // 000 SeLittleDecrease                         string IL2CPP_TYPE_STRING
    public partial class VitalityGauge : DataModel
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
            var value   = new VitalityGauge() { Pointer= p0 };

            value.BackVitalityGauge                         = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 BackVitalityGauge           ( ModelClassType UIImage UIImage UIImage Pointer )
            value.FrontVitalityGauge                        = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 FrontVitalityGauge          ( ModelClassType UIImage UIImage UIImage Pointer )
            value.FrontFillVitalityGauge                    = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0x30 FrontFillVitalityGauge      ( ModelClassType UIImage UIImage UIImage Pointer )
            value.Vitality                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 Vitality                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NormalColor                               = (Color)GetInt32(new IntPtr(p + 0x040)); // 0x40 NormalColor                 ( ModelEnumType Color Color Color Int32 )
            value.EstimateColor                             = (Color)GetInt32(new IntPtr(p + 0x050)); // 0x50 EstimateColor               ( ModelEnumType Color Color Color Int32 )
            value.BaseScheduleColor                         = (Color)GetInt32(new IntPtr(p + 0x060)); // 0x60 BaseScheduleColor           ( ModelEnumType Color Color Color Int32 )
            value.NormalColorStringHexTag                   = GetString(new IntPtr(p + 0x070)); // 0x70 NormalColorStringHexTag     ( ModelPrimitiveType string string string String )
            value.EstimateColorStringHexTag                 = GetString(new IntPtr(p + 0x078)); // 0x78 EstimateColorStringHexTag   ( ModelPrimitiveType string string string String )
            value.BaseScheduleColorStringHexTag             = GetString(new IntPtr(p + 0x080)); // 0x80 BaseScheduleColorStringHexTag ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
