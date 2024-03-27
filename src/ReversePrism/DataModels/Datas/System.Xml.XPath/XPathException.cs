using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Res                                      000186671910 ModelPrimitiveType string string string String
    // 098 Args                                     000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A0 Message                                  000186671910 ModelPrimitiveType string string string String
    public partial class XPathException
    {
        public string                                   Res                                     { get; set; }
        public List<string>?                            Args                                    { get; set; }
        public string                                   Message                                 { get; set; }

        public static XPathException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XPathException();

            value.Res                                       = GetString(new IntPtr(p + 0x090)); // 0270D749D9E8 0x90 Res                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Args                                      = GetStringList(new IntPtr(p + 0x098)); // 0270D749DA08 0x98 Args                        ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Message                                   = GetString(new IntPtr(p + 0x0A0)); // 0270D749DA28 0xA0 Message                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
