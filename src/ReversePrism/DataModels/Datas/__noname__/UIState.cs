using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mode                                     ModelEnumType UIMode UIMode UIMode Int32
    // 014 M_Open                                   ModelPrimitiveType bool bool bool Bool
    public partial class UIState : DataModel
    {
        public UIMode                                   Mode                                    { get; set; }
        public bool                                     M_Open                                  { get; set; }

        public static UIState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIState() { Pointer= p0 };

            value.Mode                                      = (UIMode)GetInt32(new IntPtr(p + 0x010)); // 0x10 Mode                        ( ModelEnumType UIMode UIMode UIMode Int32 )
            value.M_Open                                    = GetBool(new IntPtr(p + 0x014)); // 0x14 M_Open                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
