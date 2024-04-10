using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Token                                    000186600110 ModelClassType JToken JToken JToken Pointer
    public partial class JPropertyList : DataModel
    {
        public JToken?                                  Token                                   { get; set; }

        public static JPropertyList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JPropertyList() { Pointer= p0 };

            value.Token                                     = GetObject<JToken>(new IntPtr(p + 0x010), ReversePrism.DataModels.JToken.FromPointer); // 024668866168 0x10 Token                       ( 000186600110 ModelClassType JToken JToken JToken Pointer )

            return value;
        }
    }
}
