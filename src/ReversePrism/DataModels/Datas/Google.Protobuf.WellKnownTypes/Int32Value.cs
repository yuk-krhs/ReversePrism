using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Int32Value> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Value                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Int32Value
    {
        public int                                      Value                                   { get; set; }

        public static Int32Value? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Int32Value();

            value.Value                                     = GetInt32(new IntPtr(p + 0x018)); // 0270DA4D4370 0x18 Value                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
