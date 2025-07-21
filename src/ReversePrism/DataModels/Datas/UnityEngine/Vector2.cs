using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        ModelPrimitiveType float float float Single
    // 014 Y                                        ModelPrimitiveType float float float Single
    // 000 zeroVector                               Vector2 IL2CPP_TYPE_VALUETYPE
    // 008 oneVector                                Vector2 IL2CPP_TYPE_VALUETYPE
    // 010 UpVector                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 DownVector                               ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 LeftVector                               ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 RightVector                              ModelEnumType Vector2 Vector2 Vector2 Int32
    // 030 PositiveInfinityVector                   ModelEnumType Vector2 Vector2 Vector2 Int32
    // 038 NegativeInfinityVector                   ModelEnumType Vector2 Vector2 Vector2 Int32
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

            value.X                                         = GetSingle(new IntPtr(p + 0x010)); // 0x10 X                           ( ModelPrimitiveType float float float Single )
            value.Y                                         = GetSingle(new IntPtr(p + 0x014)); // 0x14 Y                           ( ModelPrimitiveType float float float Single )
            value.UpVector                                  = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 UpVector                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.DownVector                                = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0x18 DownVector                  ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.LeftVector                                = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0x20 LeftVector                  ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.RightVector                               = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 0x28 RightVector                 ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.PositiveInfinityVector                    = (Vector2)GetInt32(new IntPtr(p + 0x030)); // 0x30 PositiveInfinityVector      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.NegativeInfinityVector                    = (Vector2)GetInt32(new IntPtr(p + 0x038)); // 0x38 NegativeInfinityVector      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
