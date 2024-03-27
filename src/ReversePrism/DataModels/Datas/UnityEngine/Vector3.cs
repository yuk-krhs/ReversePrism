using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kEpsilon                                 float IL2CPP_TYPE_R4
    // 000 kEpsilonNormalSqrt                       float IL2CPP_TYPE_R4
    // 010 X                                        000186666050 ModelPrimitiveType float float float Single
    // 014 Y                                        000186666050 ModelPrimitiveType float float float Single
    // 018 Z                                        000186666050 ModelPrimitiveType float float float Single
    // 000 zeroVector                               Vector3 IL2CPP_TYPE_VALUETYPE
    // 00C oneVector                                Vector3 IL2CPP_TYPE_VALUETYPE
    // 018 UpVector                                 0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 DownVector                               0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 030 LeftVector                               0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 03C RightVector                              0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 048 ForwardVector                            0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 054 BackVector                               0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 060 PositiveInfinityVector                   0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 06C NegativeInfinityVector                   0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class Vector3
    {
        public float                                    X                                       { get; set; }
        public float                                    Y                                       { get; set; }
        public float                                    Z                                       { get; set; }
        public Vector3                                  UpVector                                { get; set; }
        public Vector3                                  DownVector                              { get; set; }
        public Vector3                                  LeftVector                              { get; set; }
        public Vector3                                  RightVector                             { get; set; }
        public Vector3                                  ForwardVector                           { get; set; }
        public Vector3                                  BackVector                              { get; set; }
        public Vector3                                  PositiveInfinityVector                  { get; set; }
        public Vector3                                  NegativeInfinityVector                  { get; set; }

        public static Vector3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector3();

            value.X                                         = GetSingle(new IntPtr(p + 0x010)); // 0270015F0278 0x10 X                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Y                                         = GetSingle(new IntPtr(p + 0x014)); // 0270015F0298 0x14 Y                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Z                                         = GetSingle(new IntPtr(p + 0x018)); // 0270015F02B8 0x18 Z                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.UpVector                                  = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0270015F0318 0x18 UpVector                    ( 0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.DownVector                                = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 0270015F0338 0x24 DownVector                  ( 0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LeftVector                                = (Vector3)GetInt32(new IntPtr(p + 0x030)); // 0270015F0358 0x30 LeftVector                  ( 0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RightVector                               = (Vector3)GetInt32(new IntPtr(p + 0x03C)); // 0270015F0378 0x3C RightVector                 ( 0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ForwardVector                             = (Vector3)GetInt32(new IntPtr(p + 0x048)); // 0270015F0398 0x48 ForwardVector               ( 0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BackVector                                = (Vector3)GetInt32(new IntPtr(p + 0x054)); // 0270015F03B8 0x54 BackVector                  ( 0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.PositiveInfinityVector                    = (Vector3)GetInt32(new IntPtr(p + 0x060)); // 0270015F03D8 0x60 PositiveInfinityVector      ( 0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.NegativeInfinityVector                    = (Vector3)GetInt32(new IntPtr(p + 0x06C)); // 0270015F03F8 0x6C NegativeInfinityVector      ( 0001866ACBA0 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
