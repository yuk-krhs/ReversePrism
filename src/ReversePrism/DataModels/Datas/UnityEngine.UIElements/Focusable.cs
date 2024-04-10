using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _Focusable                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 024 TabIndex                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_DelegatesFocus                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 M_ExcludeFromFocusRing                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Focusable : DataModel
    {
        public bool                                     _Focusable                              { get; set; }
        public int                                      TabIndex                                { get; set; }
        public bool                                     M_DelegatesFocus                        { get; set; }
        public bool                                     M_ExcludeFromFocusRing                  { get; set; }

        public static Focusable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Focusable() { Pointer= p0 };

            value._Focusable                                = GetBool(new IntPtr(p + 0x020)); // 0245A3F08070 0x20 _Focusable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TabIndex                                  = GetInt32(new IntPtr(p + 0x024)); // 0245A3F08090 0x24 TabIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_DelegatesFocus                          = GetBool(new IntPtr(p + 0x028)); // 0245A3F080B0 0x28 M_DelegatesFocus            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ExcludeFromFocusRing                    = GetBool(new IntPtr(p + 0x029)); // 0245A3F080D0 0x29 M_ExcludeFromFocusRing      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
