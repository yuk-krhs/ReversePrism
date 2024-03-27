using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LimitedValueStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CurrentFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Current                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 LimitFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Limit                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LimitedValueStatus
    {
        public int                                      Current                                 { get; set; }
        public int                                      Limit                                   { get; set; }

        public static LimitedValueStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimitedValueStatus();

            value.Current                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D0F5AB78 0x18 Current                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Limit                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D0F5ABB8 0x1C Limit                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
