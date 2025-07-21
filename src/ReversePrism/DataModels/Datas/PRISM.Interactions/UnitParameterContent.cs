using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 VocalRankTextImage                       ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 VocalValueText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 DanceRankTextImage                       ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 038 DanceValueText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 VisualRankTextImage                      ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 048 VisualValueText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 MentalRankTextImage                      ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 058 MentalValueText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class UnitParameterContent : DataModel
    {
        public UIRawImage?                              VocalRankTextImage                      { get; set; }
        public UITextMeshProUGUI?                       VocalValueText                          { get; set; }
        public UIRawImage?                              DanceRankTextImage                      { get; set; }
        public UITextMeshProUGUI?                       DanceValueText                          { get; set; }
        public UIRawImage?                              VisualRankTextImage                     { get; set; }
        public UITextMeshProUGUI?                       VisualValueText                         { get; set; }
        public UIRawImage?                              MentalRankTextImage                     { get; set; }
        public UITextMeshProUGUI?                       MentalValueText                         { get; set; }

        public static UnitParameterContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitParameterContent() { Pointer= p0 };

            value.VocalRankTextImage                        = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x20 VocalRankTextImage          ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.VocalValueText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 VocalValueText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DanceRankTextImage                        = GetObject<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x30 DanceRankTextImage          ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.DanceValueText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 DanceValueText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VisualRankTextImage                       = GetObject<UIRawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x40 VisualRankTextImage         ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.VisualValueText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 VisualValueText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MentalRankTextImage                       = GetObject<UIRawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x50 MentalRankTextImage         ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MentalValueText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 MentalValueText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
