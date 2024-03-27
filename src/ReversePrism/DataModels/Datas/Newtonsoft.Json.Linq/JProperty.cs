using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 Content                                  000186658980 ModelClassType JPropertyList JPropertyList JPropertyList Pointer
    // 060 Name                                     000186672F10 ModelPrimitiveType string string string String
    public partial class JProperty
    {
        public JPropertyList?                           Content                                 { get; set; }
        public string                                   Name                                    { get; set; }

        public static JProperty? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JProperty();

            value.Content                                   = GetObject<JPropertyList>(new IntPtr(p + 0x058), ReversePrism.DataModels.JPropertyList.FromPointer); // 0270D87D87E8 0x58 Content                     ( 000186658980 ModelClassType JPropertyList JPropertyList JPropertyList Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x060)); // 0270D87D8808 0x60 Name                        ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
