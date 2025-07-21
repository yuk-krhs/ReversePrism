using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<UInt64Value> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Value                                    ModelPrimitiveType ulong ulong ulong UInt64
    public partial class UInt64Value : DataModel
    {
        public ulong                                    Value                                   { get; set; }

        public static UInt64Value? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UInt64Value() { Pointer= p0 };

            value.Value                                     = GetUInt64(new IntPtr(p + 0x018)); // 0x18 Value                       ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
