using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Asset                                  ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer
    // 018 M_ControlSchemeIndex                     ModelPrimitiveType int int int Int32
    // 020 M_ControlScheme                          ModelEnumType InputControlScheme InputControlScheme InputControlScheme Int32
    public partial class ControlSchemeSyntax : DataModel
    {
        public InputActionAsset?                        M_Asset                                 { get; set; }
        public int                                      M_ControlSchemeIndex                    { get; set; }
        public InputControlScheme                       M_ControlScheme                         { get; set; }

        public static ControlSchemeSyntax? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ControlSchemeSyntax() { Pointer= p0 };

            value.M_Asset                                   = GetObject<InputActionAsset>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputActionAsset.FromPointer); // 0x10 M_Asset                     ( ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer )
            value.M_ControlSchemeIndex                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_ControlSchemeIndex        ( ModelPrimitiveType int int int Int32 )
            value.M_ControlScheme                           = (InputControlScheme)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_ControlScheme             ( ModelEnumType InputControlScheme InputControlScheme InputControlScheme Int32 )

            return value;
        }
    }
}
