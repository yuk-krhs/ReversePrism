using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Quaternion> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 XFieldNumber                             int IL2CPP_TYPE_I4
    // 018 X                                        0001865C2950 ModelPrimitiveType double double double Double
    // 000 YFieldNumber                             int IL2CPP_TYPE_I4
    // 020 Y                                        0001865C2950 ModelPrimitiveType double double double Double
    // 000 ZFieldNumber                             int IL2CPP_TYPE_I4
    // 028 Z                                        0001865C2950 ModelPrimitiveType double double double Double
    // 000 WFieldNumber                             int IL2CPP_TYPE_I4
    // 030 W                                        0001865C2950 ModelPrimitiveType double double double Double
    public partial class Quaternion
    {
        public double                                   X                                       { get; set; }
        public double                                   Y                                       { get; set; }
        public double                                   Z                                       { get; set; }
        public double                                   W                                       { get; set; }

        public static Quaternion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Quaternion();

            value.X                                         = GetDouble(new IntPtr(p + 0x018)); // 0270DA6AFE78 0x18 X                           ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.Y                                         = GetDouble(new IntPtr(p + 0x020)); // 0270DA6AFEB8 0x20 Y                           ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.Z                                         = GetDouble(new IntPtr(p + 0x028)); // 0270DA6AFEF8 0x28 Z                           ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.W                                         = GetDouble(new IntPtr(p + 0x030)); // 0270DA6AFF38 0x30 W                           ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
