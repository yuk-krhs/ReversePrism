using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        000186666050 ModelPrimitiveType float float float Single
    // 014 Y                                        000186666050 ModelPrimitiveType float float float Single
    // 000 zeroVector                               Vector2 IL2CPP_TYPE_VALUETYPE
    // 008 oneVector                                Vector2 IL2CPP_TYPE_VALUETYPE
    // 010 UpVector                                 0001866A9820 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 DownVector                               0001866A9820 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 LeftVector                               0001866A9820 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 RightVector                              0001866A9820 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 030 PositiveInfinityVector                   0001866A9820 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 038 NegativeInfinityVector                   0001866A9820 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 000 kEpsilon                                 float IL2CPP_TYPE_R4
    // 000 kEpsilonNormalSqrt                       float IL2CPP_TYPE_R4
    public partial class Vector2 : DataModel
    {
        public float                                    X                                       { get; set; }
        public float                                    Y                                       { get; set; }
        public Vector2                                  UpVector                                { get; set; }
        public Vector2                                  DownVector                              { get; set; }
        public Vector2                                  LeftVector                              { get; set; }
        public Vector2                                  RightVector                             { get; set; }
        public Vector2                                  PositiveInfinityVector                  { get; set; }
        public Vector2                                  NegativeInfinityVector                  { get; set; }

        public static Vector2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector2() { Pointer= p0 };

            value.X                                         = GetSingle(new IntPtr(p + 0x010)); // 0245A15F4340 0x10 X                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Y                                         = GetSingle(new IntPtr(p + 0x014)); // 0245A15F4360 0x14 Y                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.UpVector                                  = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0245A15F43C0 0x10 UpVector                    ( 0001866A9820 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.DownVector                                = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0245A15F43E0 0x18 DownVector                  ( 0001866A9820 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.LeftVector                                = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0245A15F4400 0x20 LeftVector                  ( 0001866A9820 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.RightVector                               = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 0245A15F4420 0x28 RightVector                 ( 0001866A9820 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.PositiveInfinityVector                    = (Vector2)GetInt32(new IntPtr(p + 0x030)); // 0245A15F4440 0x30 PositiveInfinityVector      ( 0001866A9820 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.NegativeInfinityVector                    = (Vector2)GetInt32(new IntPtr(p + 0x038)); // 0245A15F4460 0x38 NegativeInfinityVector      ( 0001866A9820 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
