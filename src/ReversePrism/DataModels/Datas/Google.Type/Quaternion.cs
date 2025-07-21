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
    // 018 X                                        ModelPrimitiveType double double double Double
    // 000 YFieldNumber                             int IL2CPP_TYPE_I4
    // 020 Y                                        ModelPrimitiveType double double double Double
    // 000 ZFieldNumber                             int IL2CPP_TYPE_I4
    // 028 Z                                        ModelPrimitiveType double double double Double
    // 000 WFieldNumber                             int IL2CPP_TYPE_I4
    // 030 W                                        ModelPrimitiveType double double double Double
    public partial class Quaternion : DataModel
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
            var value   = new Quaternion() { Pointer= p0 };

            value.X                                         = GetDouble(new IntPtr(p + 0x018)); // 0x18 X                           ( ModelPrimitiveType double double double Double )
            value.Y                                         = GetDouble(new IntPtr(p + 0x020)); // 0x20 Y                           ( ModelPrimitiveType double double double Double )
            value.Z                                         = GetDouble(new IntPtr(p + 0x028)); // 0x28 Z                           ( ModelPrimitiveType double double double Double )
            value.W                                         = GetDouble(new IntPtr(p + 0x030)); // 0x30 W                           ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
