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
    // 010 X                                        ModelPrimitiveType float float float Single
    // 014 Y                                        ModelPrimitiveType float float float Single
    // 018 Z                                        ModelPrimitiveType float float float Single
    // 000 zeroVector                               Vector3 IL2CPP_TYPE_VALUETYPE
    // 00C oneVector                                Vector3 IL2CPP_TYPE_VALUETYPE
    // 018 UpVector                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 DownVector                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 030 LeftVector                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 03C RightVector                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 048 ForwardVector                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 054 BackVector                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 060 PositiveInfinityVector                   ModelEnumType Vector3 Vector3 Vector3 Int32
    // 06C NegativeInfinityVector                   ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class Vector3 : DataModel
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
            var value   = new Vector3() { Pointer= p0 };

            value.X                                         = GetSingle(new IntPtr(p + 0x010)); // 0x10 X                           ( ModelPrimitiveType float float float Single )
            value.Y                                         = GetSingle(new IntPtr(p + 0x014)); // 0x14 Y                           ( ModelPrimitiveType float float float Single )
            value.Z                                         = GetSingle(new IntPtr(p + 0x018)); // 0x18 Z                           ( ModelPrimitiveType float float float Single )
            value.UpVector                                  = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0x18 UpVector                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.DownVector                                = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 0x24 DownVector                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LeftVector                                = (Vector3)GetInt32(new IntPtr(p + 0x030)); // 0x30 LeftVector                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RightVector                               = (Vector3)GetInt32(new IntPtr(p + 0x03C)); // 0x3C RightVector                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ForwardVector                             = (Vector3)GetInt32(new IntPtr(p + 0x048)); // 0x48 ForwardVector               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BackVector                                = (Vector3)GetInt32(new IntPtr(p + 0x054)); // 0x54 BackVector                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.PositiveInfinityVector                    = (Vector3)GetInt32(new IntPtr(p + 0x060)); // 0x60 PositiveInfinityVector      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.NegativeInfinityVector                    = (Vector3)GetInt32(new IntPtr(p + 0x06C)); // 0x6C NegativeInfinityVector      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
