using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BufferedToken                            000186761C90 ModelClassType JsonToken JsonToken JsonToken Pointer
    // 018 ObjectDepth                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class JsonTokenizer : DataModel
    {
        public JsonToken?                               BufferedToken                           { get; set; }
        public int                                      ObjectDepth                             { get; set; }

        public static JsonTokenizer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonTokenizer() { Pointer= p0 };

            value.BufferedToken                             = GetObject<JsonToken>(new IntPtr(p + 0x010), ReversePrism.DataModels.JsonToken.FromPointer); // 02466A477000 0x10 BufferedToken               ( 000186761C90 ModelClassType JsonToken JsonToken JsonToken Pointer )
            value.ObjectDepth                               = GetInt32(new IntPtr(p + 0x018)); // 02466A477020 0x18 ObjectDepth                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
