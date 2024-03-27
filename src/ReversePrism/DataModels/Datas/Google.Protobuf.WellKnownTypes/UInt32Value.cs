using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<UInt32Value> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Value                                    000186698B70 ModelPrimitiveType uint uint uint UInt32
    public partial class UInt32Value
    {
        public uint                                     Value                                   { get; set; }

        public static UInt32Value? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UInt32Value();

            value.Value                                     = GetUInt32(new IntPtr(p + 0x018)); // 0270DA4D5A18 0x18 Value                       ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
