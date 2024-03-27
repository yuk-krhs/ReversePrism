using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Linear> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NumFiniteBucketsFieldNumber              int IL2CPP_TYPE_I4
    // 018 NumFiniteBuckets                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 WidthFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Width                                    0001865C2950 ModelPrimitiveType double double double Double
    // 000 OffsetFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Offset                                   0001865C2950 ModelPrimitiveType double double double Double
    public partial class Linear
    {
        public int                                      NumFiniteBuckets                        { get; set; }
        public double                                   Width                                   { get; set; }
        public double                                   Offset                                  { get; set; }

        public static Linear? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Linear();

            value.NumFiniteBuckets                          = GetInt32(new IntPtr(p + 0x018)); // 0270DA7950C0 0x18 NumFiniteBuckets            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Width                                     = GetDouble(new IntPtr(p + 0x020)); // 0270DA795100 0x20 Width                       ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.Offset                                    = GetDouble(new IntPtr(p + 0x028)); // 0270DA795140 0x28 Offset                      ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
