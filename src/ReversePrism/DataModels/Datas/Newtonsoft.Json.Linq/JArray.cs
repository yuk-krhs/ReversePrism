using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 Values                                   000185CEE818 ModelClassListType List`1<JToken> List`1<JToken> List<JToken> Pointer
    public partial class JArray
    {
        public List<JToken>?                            Values                                  { get; set; }

        public static JArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JArray();

            value.Values                                    = GetObjectList<JToken>(new IntPtr(p + 0x058), ReversePrism.DataModels.JToken.FromPointer); // 0270D87DE120 0x58 Values                      ( 000185CEE818 ModelClassListType List`1<JToken> List`1<JToken> List<JToken> Pointer )

            return value;
        }
    }
}
