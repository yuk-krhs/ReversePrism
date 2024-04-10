using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 InnerWriter                              000186764290 ModelClassType JsonWriter JsonWriter JsonWriter Pointer
    // 068 TextWriter                               000186761790 ModelClassType JsonTextWriter JsonTextWriter JsonTextWriter Pointer
    // 070 Sw                                       000186678A40 ModelClassType StringWriter StringWriter StringWriter Pointer
    public partial class TraceJsonWriter : DataModel
    {
        public JsonWriter?                              InnerWriter                             { get; set; }
        public JsonTextWriter?                          TextWriter                              { get; set; }
        public StringWriter?                            Sw                                      { get; set; }

        public static TraceJsonWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TraceJsonWriter() { Pointer= p0 };

            value.InnerWriter                               = GetObject<JsonWriter>(new IntPtr(p + 0x060), ReversePrism.DataModels.JsonWriter.FromPointer); // 0245A6671760 0x60 InnerWriter                 ( 000186764290 ModelClassType JsonWriter JsonWriter JsonWriter Pointer )
            value.TextWriter                                = GetObject<JsonTextWriter>(new IntPtr(p + 0x068), ReversePrism.DataModels.JsonTextWriter.FromPointer); // 0245A6671780 0x68 TextWriter                  ( 000186761790 ModelClassType JsonTextWriter JsonTextWriter JsonTextWriter Pointer )
            value.Sw                                        = GetObject<StringWriter>(new IntPtr(p + 0x070), ReversePrism.DataModels.StringWriter.FromPointer); // 0245A66717A0 0x70 Sw                          ( 000186678A40 ModelClassType StringWriter StringWriter StringWriter Pointer )

            return value;
        }
    }
}
