using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ActiveButton                             ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 InactiveButton                           ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 IsOn                                     ModelPrimitiveType bool bool bool Bool
    // 038 statusChangeSubject                      Subject`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class UISwitch : DataModel
    {
        public ButtonBase?                              ActiveButton                            { get; set; }
        public ButtonBase?                              InactiveButton                          { get; set; }
        public bool                                     IsOn                                    { get; set; }

        public static UISwitch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UISwitch() { Pointer= p0 };

            value.ActiveButton                              = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x20 ActiveButton                ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.InactiveButton                            = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x28 InactiveButton              ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.IsOn                                      = GetBool(new IntPtr(p + 0x030)); // 0x30 IsOn                        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
