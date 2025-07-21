using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CollideCone                              ModelClassType ConeInfo ConeInfo ConeInfo Pointer
    // 018 LastCollideCone                          ModelClassType ConeInfo ConeInfo ConeInfo Pointer
    // 020 HandPos                                  ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C HandPosSave                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 038 HandCurrentPos                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 HandCalcedPos                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 050 HitFlag                                  ModelPrimitiveType bool bool bool Bool
    // 054 HandLerpCount                            ModelPrimitiveType float float float Single
    public partial class CalcCollidePos : DataModel
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
            var value   = new CalcCollidePos() { Pointer= p0 };

            value.CollideCone                               = GetObject<ConeInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.ConeInfo.FromPointer); // 0x10 CollideCone                 ( ModelClassType ConeInfo ConeInfo ConeInfo Pointer )
            value.LastCollideCone                           = GetObject<ConeInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.ConeInfo.FromPointer); // 0x18 LastCollideCone             ( ModelClassType ConeInfo ConeInfo ConeInfo Pointer )
            value.HandPos                                   = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0x20 HandPos                     ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HandPosSave                               = (Vector3)GetInt32(new IntPtr(p + 0x02C)); // 0x2C HandPosSave                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HandCurrentPos                            = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0x38 HandCurrentPos              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HandCalcedPos                             = (Vector3)GetInt32(new IntPtr(p + 0x044)); // 0x44 HandCalcedPos               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HitFlag                                   = GetBool(new IntPtr(p + 0x050)); // 0x50 HitFlag                     ( ModelPrimitiveType bool bool bool Bool )
            value.HandLerpCount                             = GetSingle(new IntPtr(p + 0x054)); // 0x54 HandLerpCount               ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
