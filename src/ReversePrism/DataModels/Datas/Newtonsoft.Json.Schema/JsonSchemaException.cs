using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 LineNumber                               0001865F4260 ModelPrimitiveType int int int Int32
    // 094 LinePosition                             0001865F4260 ModelPrimitiveType int int int Int32
    // 098 Path                                     000186672F10 ModelPrimitiveType string string string String
    public partial class JsonSchemaException : DataModel
    {
        public int                                      LineNumber                              { get; set; }
        public int                                      LinePosition                            { get; set; }
        public string                                   Path                                    { get; set; }

        public static JsonSchemaException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSchemaException() { Pointer= p0 };

            value.LineNumber                                = GetInt32(new IntPtr(p + 0x090)); // 02466873F750 0x90 LineNumber                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LinePosition                              = GetInt32(new IntPtr(p + 0x094)); // 02466873F770 0x94 LinePosition                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Path                                      = GetString(new IntPtr(p + 0x098)); // 02466873F790 0x98 Path                        ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
