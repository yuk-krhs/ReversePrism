using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RangeStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MinFieldNumber                           int IL2CPP_TYPE_I4
    // 018 Min                                      ModelPrimitiveType int int int Int32
    // 000 MaxFieldNumber                           int IL2CPP_TYPE_I4
    // 01C Max                                      ModelPrimitiveType int int int Int32
    public partial class RangeStatus : DataModel
    {
        public int                                      Min                                     { get; set; }
        public int                                      Max                                     { get; set; }

        public static RangeStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RangeStatus() { Pointer= p0 };

            value.Min                                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 Min                         ( ModelPrimitiveType int int int Int32 )
            value.Max                                       = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Max                         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
