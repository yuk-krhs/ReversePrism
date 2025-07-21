using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProducerNameText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 030 ProducerName                             ModelPrimitiveType string string string String
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileEditPlayerNameConfirmPopupView : DataModel
    {
        public UITextMeshProUGUI?                       ProducerNameText                        { get; set; }
        public string                                   ProducerName                            { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileEditPlayerNameConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEditPlayerNameConfirmPopupView() { Pointer= p0 };

            value.ProducerNameText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 ProducerNameText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProducerName                              = GetString(new IntPtr(p + 0x030)); // 0x30 ProducerName                ( ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
