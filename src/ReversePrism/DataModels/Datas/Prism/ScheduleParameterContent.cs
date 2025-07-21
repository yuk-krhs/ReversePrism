using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 VoRankImage                              ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 VoValueText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 VoValiableText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 DaRankImage                              ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 040 DaValueText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 DaValiableText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ViRankImage                              ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 058 ViValueText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ViValiableText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 MeRankImage                              ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 070 MeValueText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 MeValiableText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ScheduleParameterContent : DataModel
    {
        public UIRawImage?                              VoRankImage                             { get; set; }
        public UITextMeshProUGUI?                       VoValueText                             { get; set; }
        public UITextMeshProUGUI?                       VoValiableText                          { get; set; }
        public UIRawImage?                              DaRankImage                             { get; set; }
        public UITextMeshProUGUI?                       DaValueText                             { get; set; }
        public UITextMeshProUGUI?                       DaValiableText                          { get; set; }
        public UIRawImage?                              ViRankImage                             { get; set; }
        public UITextMeshProUGUI?                       ViValueText                             { get; set; }
        public UITextMeshProUGUI?                       ViValiableText                          { get; set; }
        public UIRawImage?                              MeRankImage                             { get; set; }
        public UITextMeshProUGUI?                       MeValueText                             { get; set; }
        public UITextMeshProUGUI?                       MeValiableText                          { get; set; }

        public static ScheduleParameterContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleParameterContent() { Pointer= p0 };

            value.VoRankImage                               = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x20 VoRankImage                 ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.VoValueText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 VoValueText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoValiableText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 VoValiableText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DaRankImage                               = GetObject<UIRawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x38 DaRankImage                 ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.DaValueText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 DaValueText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DaValiableText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 DaValiableText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViRankImage                               = GetObject<UIRawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x50 ViRankImage                 ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.ViValueText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 ViValueText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViValiableText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 ViValiableText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MeRankImage                               = GetObject<UIRawImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x68 MeRankImage                 ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MeValueText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 MeValueText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MeValiableText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 MeValiableText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
