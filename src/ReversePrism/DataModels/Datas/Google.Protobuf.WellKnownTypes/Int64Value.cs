using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Int64Value> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Value                                    ModelPrimitiveType long long long Int64
    public partial class Int64Value : DataModel
    {
        public long                                     Value                                   { get; set; }

        public static Int64Value? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Int64Value() { Pointer= p0 };

            value.Value                                     = GetInt64(new IntPtr(p + 0x018)); // 0x18 Value                       ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
