using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 030 ErrorModalMessage                        ModelPrimitiveType string string string String
    // 038 clickSubject                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class GrayOutErrorModalButton : DataModel
    {
        public ButtonBase?                              Button                                  { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public string                                   ErrorModalMessage                       { get; set; }

        public static GrayOutErrorModalButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GrayOutErrorModalButton() { Pointer= p0 };

            value.Button                                    = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x20 Button                      ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x28 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.ErrorModalMessage                         = GetString(new IntPtr(p + 0x030)); // 0x30 ErrorModalMessage           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
