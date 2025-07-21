using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 Name                                     ModelPrimitiveType string string string String
    // 060 Values                                   ModelClassListType List`1<JToken> List`1<JToken> List<JToken> Pointer
    public partial class JConstructor : DataModel
    {
        public string                                   Name                                    { get; set; }
        public List<JToken>?                            Values                                  { get; set; }

        public static JConstructor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JConstructor() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x058)); // 0x58 Name                        ( ModelPrimitiveType string string string String )
            value.Values                                    = GetObjectList<JToken>(new IntPtr(p + 0x060), ReversePrism.DataModels.JToken.FromPointer); // 0x60 Values                      ( ModelClassListType List`1<JToken> List`1<JToken> List<JToken> Pointer )

            return value;
        }
    }
}
