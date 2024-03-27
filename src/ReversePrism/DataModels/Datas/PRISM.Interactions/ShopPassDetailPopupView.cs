using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DescriptionText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 CautionView                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 CautionText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 CautionStr                               000186671910 ModelPrimitiveType string string string String
    // 040 MstId                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 TitleName                                000186671910 ModelPrimitiveType string string string String
    // 050 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ShopPassDetailPopupView
    {
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public GameObject?                              CautionView                             { get; set; }
        public UITextMeshProUGUI?                       CautionText                             { get; set; }
        public string                                   CautionStr                              { get; set; }
        public int                                      MstId                                   { get; set; }
        public string                                   TitleName                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ShopPassDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPassDetailPopupView();

            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB7E7708 0x20 DescriptionText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CautionView                               = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB7E7728 0x28 CautionView                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB7E7748 0x30 CautionText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CautionStr                                = GetString(new IntPtr(p + 0x038)); // 0270DB7E7768 0x38 CautionStr                  ( 000186671910 ModelPrimitiveType string string string String )
            value.MstId                                     = GetInt32(new IntPtr(p + 0x040)); // 0270DB7E7788 0x40 MstId                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TitleName                                 = GetString(new IntPtr(p + 0x048)); // 0270DB7E77A8 0x48 TitleName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB7E77E8 0x58 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
