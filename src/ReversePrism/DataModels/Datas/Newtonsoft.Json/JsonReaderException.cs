using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 LineNumber                               ModelPrimitiveType int int int Int32
    // 094 LinePosition                             ModelPrimitiveType int int int Int32
    // 098 Path                                     ModelPrimitiveType string string string String
    public partial class JsonReaderException : DataModel
    {
        public int                                      LineNumber                              { get; set; }
        public int                                      LinePosition                            { get; set; }
        public string                                   Path                                    { get; set; }

        public static JsonReaderException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonReaderException() { Pointer= p0 };

            value.LineNumber                                = GetInt32(new IntPtr(p + 0x090)); // 0x90 LineNumber                  ( ModelPrimitiveType int int int Int32 )
            value.LinePosition                              = GetInt32(new IntPtr(p + 0x094)); // 0x94 LinePosition                ( ModelPrimitiveType int int int Int32 )
            value.Path                                      = GetString(new IntPtr(p + 0x098)); // 0x98 Path                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
