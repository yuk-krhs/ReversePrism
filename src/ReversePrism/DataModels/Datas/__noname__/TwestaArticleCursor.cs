using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 initialCursor                            string IL2CPP_TYPE_STRING
    // 010 IsCursorUpdated                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Value                                    000186671910 ModelPrimitiveType string string string String
    public partial class TwestaArticleCursor
    {
        public bool                                     IsCursorUpdated                         { get; set; }
        public string                                   Value                                   { get; set; }

        public static TwestaArticleCursor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleCursor();

            value.IsCursorUpdated                           = GetBool(new IntPtr(p + 0x010)); // 0270DAE490A8 0x10 IsCursorUpdated             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 0270DAE490C8 0x18 Value                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
