using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 098 IsChange                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A0 InputString                              000186671910 ModelPrimitiveType string string string String
    public partial class PlayerNameInputContent
    {
        public bool                                     IsChange                                { get; set; }
        public string                                   InputString                             { get; set; }

        public static PlayerNameInputContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerNameInputContent();

            value.IsChange                                  = GetBool(new IntPtr(p + 0x098)); // 0270043958F0 0x98 IsChange                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InputString                               = GetString(new IntPtr(p + 0x0A0)); // 027004395910 0xA0 InputString                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
