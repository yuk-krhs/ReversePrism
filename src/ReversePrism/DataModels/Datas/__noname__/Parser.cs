using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 WORD_BREAK                               string IL2CPP_TYPE_STRING
    // 010 Json                                     0001865C1E60 ModelClassType StringReader StringReader StringReader Pointer
    public partial class Parser
    {
        public StringReader?                            Json                                    { get; set; }

        public static Parser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Parser();

            value.Json                                      = GetObject<StringReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringReader.FromPointer); // 02700698EAC8 0x10 Json                        ( 0001865C1E60 ModelClassType StringReader StringReader StringReader Pointer )

            return value;
        }
    }
}
