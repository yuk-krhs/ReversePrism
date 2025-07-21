using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 InnerReader                              ModelClassType JsonReader JsonReader JsonReader Pointer
    // 080 TextWriter                               ModelClassType JsonTextWriter JsonTextWriter JsonTextWriter Pointer
    // 088 Sw                                       ModelClassType StringWriter StringWriter StringWriter Pointer
    public partial class TraceJsonReader : DataModel
    {
        public JsonReader?                              InnerReader                             { get; set; }
        public JsonTextWriter?                          TextWriter                              { get; set; }
        public StringWriter?                            Sw                                      { get; set; }

        public static TraceJsonReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TraceJsonReader() { Pointer= p0 };

            value.InnerReader                               = GetObject<JsonReader>(new IntPtr(p + 0x078), ReversePrism.DataModels.JsonReader.FromPointer); // 0x78 InnerReader                 ( ModelClassType JsonReader JsonReader JsonReader Pointer )
            value.TextWriter                                = GetObject<JsonTextWriter>(new IntPtr(p + 0x080), ReversePrism.DataModels.JsonTextWriter.FromPointer); // 0x80 TextWriter                  ( ModelClassType JsonTextWriter JsonTextWriter JsonTextWriter Pointer )
            value.Sw                                        = GetObject<StringWriter>(new IntPtr(p + 0x088), ReversePrism.DataModels.StringWriter.FromPointer); // 0x88 Sw                          ( ModelClassType StringWriter StringWriter StringWriter Pointer )

            return value;
        }
    }
}
