using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Text                                     0001865DAE40 ModelEnumType Substring Substring Substring Int32
    // 020 HasEscapes                               000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class JsonString
    {
        public Substring                                Text                                    { get; set; }
        public bool                                     HasEscapes                              { get; set; }

        public static JsonString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonString();

            value.Text                                      = (Substring)GetInt32(new IntPtr(p + 0x010)); // 0270D78B24D0 0x10 Text                        ( 0001865DAE40 ModelEnumType Substring Substring Substring Int32 )
            value.HasEscapes                                = GetBool(new IntPtr(p + 0x020)); // 0270D78B24F0 0x20 HasEscapes                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
