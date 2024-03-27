using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kEpsilon                                 float IL2CPP_TYPE_R4
    // 010 X                                        000186666050 ModelPrimitiveType float float float Single
    // 014 Y                                        000186666050 ModelPrimitiveType float float float Single
    // 018 Z                                        000186666050 ModelPrimitiveType float float float Single
    // 01C W                                        000186666050 ModelPrimitiveType float float float Single
    // 000 zeroVector                               Vector4 IL2CPP_TYPE_VALUETYPE
    // 010 OneVector                                0001866AF510 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 020 PositiveInfinityVector                   0001866AF510 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 030 NegativeInfinityVector                   0001866AF510 ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class Vector4
    {
        public float                                    X                                       { get; set; }
        public float                                    Y                                       { get; set; }
        public float                                    Z                                       { get; set; }
        public float                                    W                                       { get; set; }
        public Vector4                                  OneVector                               { get; set; }
        public Vector4                                  PositiveInfinityVector                  { get; set; }
        public Vector4                                  NegativeInfinityVector                  { get; set; }

        public static Vector4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector4();

            value.X                                         = GetSingle(new IntPtr(p + 0x010)); // 0270015F6D58 0x10 X                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Y                                         = GetSingle(new IntPtr(p + 0x014)); // 0270015F6D78 0x14 Y                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Z                                         = GetSingle(new IntPtr(p + 0x018)); // 0270015F6D98 0x18 Z                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.W                                         = GetSingle(new IntPtr(p + 0x01C)); // 0270015F6DB8 0x1C W                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.OneVector                                 = (Vector4)GetInt32(new IntPtr(p + 0x010)); // 0270015F6DF8 0x10 OneVector                   ( 0001866AF510 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.PositiveInfinityVector                    = (Vector4)GetInt32(new IntPtr(p + 0x020)); // 0270015F6E18 0x20 PositiveInfinityVector      ( 0001866AF510 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.NegativeInfinityVector                    = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 0270015F6E38 0x30 NegativeInfinityVector      ( 0001866AF510 ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
