using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _Focusable                               ModelPrimitiveType bool bool bool Bool
    // 024 TabIndex                                 ModelPrimitiveType int int int Int32
    // 028 M_DelegatesFocus                         ModelPrimitiveType bool bool bool Bool
    // 029 M_ExcludeFromFocusRing                   ModelPrimitiveType bool bool bool Bool
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

            value._Focusable                                = GetBool(new IntPtr(p + 0x020)); // 0x20 _Focusable                  ( ModelPrimitiveType bool bool bool Bool )
            value.TabIndex                                  = GetInt32(new IntPtr(p + 0x024)); // 0x24 TabIndex                    ( ModelPrimitiveType int int int Int32 )
            value.M_DelegatesFocus                          = GetBool(new IntPtr(p + 0x028)); // 0x28 M_DelegatesFocus            ( ModelPrimitiveType bool bool bool Bool )
            value.M_ExcludeFromFocusRing                    = GetBool(new IntPtr(p + 0x029)); // 0x29 M_ExcludeFromFocusRing      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
