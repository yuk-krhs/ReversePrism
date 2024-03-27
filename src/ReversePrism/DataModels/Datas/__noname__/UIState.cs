using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mode                                     000186581980 ModelEnumType UIMode UIMode UIMode Int32
    // 014 M_Open                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class UIState
    {
        public UIMode                                   Mode                                    { get; set; }
        public bool                                     M_Open                                  { get; set; }

        public static UIState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIState();

            value.Mode                                      = (UIMode)GetInt32(new IntPtr(p + 0x010)); // 0270D9162C80 0x10 Mode                        ( 000186581980 ModelEnumType UIMode UIMode UIMode Int32 )
            value.M_Open                                    = GetBool(new IntPtr(p + 0x014)); // 0270D9162CA0 0x14 M_Open                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
