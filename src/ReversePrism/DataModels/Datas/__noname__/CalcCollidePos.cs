using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CollideCone                              0001866D1CC0 ModelClassType ConeInfo ConeInfo ConeInfo Pointer
    // 018 LastCollideCone                          0001866D1CC0 ModelClassType ConeInfo ConeInfo ConeInfo Pointer
    // 020 HandPos                                  0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C HandPosSave                              0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 038 HandCurrentPos                           0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 HandCalcedPos                            0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 050 HitFlag                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 054 HandLerpCount                            000186666050 ModelPrimitiveType float float float Single
    public partial class CalcCollidePos
    {
        public ConeInfo?                                CollideCone                             { get; set; }
        public ConeInfo?                                LastCollideCone                         { get; set; }
        public Vector3                                  HandPos                                 { get; set; }
        public Vector3                                  HandPosSave                             { get; set; }
        public Vector3                                  HandCurrentPos                          { get; set; }
        public Vector3                                  HandCalcedPos                           { get; set; }
        public bool                                     HitFlag                                 { get; set; }
        public float                                    HandLerpCount                           { get; set; }

        public static CalcCollidePos? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CalcCollidePos();

            value.CollideCone                               = GetObject<ConeInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.ConeInfo.FromPointer); // 0270069DC3C8 0x10 CollideCone                 ( 0001866D1CC0 ModelClassType ConeInfo ConeInfo ConeInfo Pointer )
            value.LastCollideCone                           = GetObject<ConeInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.ConeInfo.FromPointer); // 0270069DC3E8 0x18 LastCollideCone             ( 0001866D1CC0 ModelClassType ConeInfo ConeInfo ConeInfo Pointer )
            value.HandPos                                   = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0270069DC408 0x20 HandPos                     ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HandPosSave                               = (Vector3)GetInt32(new IntPtr(p + 0x02C)); // 0270069DC428 0x2C HandPosSave                 ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HandCurrentPos                            = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0270069DC448 0x38 HandCurrentPos              ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HandCalcedPos                             = (Vector3)GetInt32(new IntPtr(p + 0x044)); // 0270069DC468 0x44 HandCalcedPos               ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HitFlag                                   = GetBool(new IntPtr(p + 0x050)); // 0270069DC488 0x50 HitFlag                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.HandLerpCount                             = GetSingle(new IntPtr(p + 0x054)); // 0270069DC4A8 0x54 HandLerpCount               ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
