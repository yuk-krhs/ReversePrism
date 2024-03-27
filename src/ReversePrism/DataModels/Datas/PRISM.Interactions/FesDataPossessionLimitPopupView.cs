using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtMessage                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtFesIdolCount                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtFesIdolLimit                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtFesUnitCount                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtFesUnitLimit                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 onClick                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 050 Title                                    000186671910 ModelPrimitiveType string string string String
    // 058 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class FesDataPossessionLimitPopupView
    {
        public UITextMeshProUGUI?                       TxtMessage                              { get; set; }
        public UITextMeshProUGUI?                       TxtFesIdolCount                         { get; set; }
        public UITextMeshProUGUI?                       TxtFesIdolLimit                         { get; set; }
        public UITextMeshProUGUI?                       TxtFesUnitCount                         { get; set; }
        public UITextMeshProUGUI?                       TxtFesUnitLimit                         { get; set; }
        public string                                   Title                                   { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static FesDataPossessionLimitPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesDataPossessionLimitPopupView();

            value.TxtMessage                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB507E48 0x20 TxtMessage                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFesIdolCount                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB507E68 0x28 TxtFesIdolCount             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFesIdolLimit                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB507E88 0x30 TxtFesIdolLimit             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFesUnitCount                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB507EA8 0x38 TxtFesUnitCount             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFesUnitLimit                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB507EC8 0x40 TxtFesUnitLimit             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Title                                     = GetString(new IntPtr(p + 0x050)); // 0270DB507F08 0x50 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB507F28 0x58 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
