using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001865158C0 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 GrayOutController                        0001866EA6A0 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 030 ErrorModalMessage                        000186671E00 ModelPrimitiveType string string string String
    // 038 clickSubject                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class GrayOutErrorModalButton
    {
        public ButtonBase?                              Button                                  { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public string                                   ErrorModalMessage                       { get; set; }

        public static GrayOutErrorModalButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GrayOutErrorModalButton();

            value.Button                                    = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D4EDBF70 0x20 Button                      ( 0001865158C0 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270D4EDBF90 0x28 GrayOutController           ( 0001866EA6A0 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.ErrorModalMessage                         = GetString(new IntPtr(p + 0x030)); // 0270D4EDBFB0 0x30 ErrorModalMessage           ( 000186671E00 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
