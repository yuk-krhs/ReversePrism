using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtComment                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TmpInputField                            ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 030 TxtCharacterCount                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 onClick                                  Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 040 CurrentName                              ModelPrimitiveType string string string String
    // 048 CharacterLimit                           ModelPrimitiveType string string string String
    // 050 ForProduce                               ModelPrimitiveType bool bool bool Bool
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class EditUnitNamePopupView : DataModel
    {
        public UITextMeshProUGUI?                       TxtComment                              { get; set; }
        public CommonInputFieldTMP?                     TmpInputField                           { get; set; }
        public UITextMeshProUGUI?                       TxtCharacterCount                       { get; set; }
        public string                                   CurrentName                             { get; set; }
        public string                                   CharacterLimit                          { get; set; }
        public bool                                     ForProduce                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static EditUnitNamePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditUnitNamePopupView() { Pointer= p0 };

            value.TxtComment                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtComment                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TmpInputField                             = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0x28 TmpInputField               ( ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.TxtCharacterCount                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtCharacterCount           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CurrentName                               = GetString(new IntPtr(p + 0x040)); // 0x40 CurrentName                 ( ModelPrimitiveType string string string String )
            value.CharacterLimit                            = GetString(new IntPtr(p + 0x048)); // 0x48 CharacterLimit              ( ModelPrimitiveType string string string String )
            value.ForProduce                                = GetBool(new IntPtr(p + 0x050)); // 0x50 ForProduce                  ( ModelPrimitiveType bool bool bool Bool )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
