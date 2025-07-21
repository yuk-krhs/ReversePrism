using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NumOfCalcParams                          int IL2CPP_TYPE_I4
    // 010 FollowsOriginalSource                    ModelPrimitiveType bool bool bool Bool
    // 014 CalculationType                          ModelEnumType Randomize3dCalcType Randomize3dCalcType Randomize3dCalcType Int32
    // 018 CalculationParameters                    ModelPrimitiveListType float[] float[] List<float> Pointer
    public partial class Randomize3dConfig : DataModel
    {
        public bool                                     FollowsOriginalSource                   { get; set; }
        public Randomize3dCalcType                      CalculationType                         { get; set; }
        public List<float>?                             CalculationParameters                   { get; set; }

        public static Randomize3dConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Randomize3dConfig() { Pointer= p0 };

            value.FollowsOriginalSource                     = GetBool(new IntPtr(p + 0x010)); // 0x10 FollowsOriginalSource       ( ModelPrimitiveType bool bool bool Bool )
            value.CalculationType                           = (Randomize3dCalcType)GetInt32(new IntPtr(p + 0x014)); // 0x14 CalculationType             ( ModelEnumType Randomize3dCalcType Randomize3dCalcType Randomize3dCalcType Int32 )
            value.CalculationParameters                     = GetSingleList(new IntPtr(p + 0x018)); // 0x18 CalculationParameters       ( ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
