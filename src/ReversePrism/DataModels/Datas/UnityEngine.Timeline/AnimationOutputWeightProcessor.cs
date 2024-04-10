using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Output                                 0001866B67B0 ModelEnumType AnimationPlayableOutput AnimationPlayableOutput AnimationPlayableOutput Int32
    // 020 M_MotionXPlayable                        0001866B4D20 ModelEnumType AnimationMotionXToDeltaPlayable AnimationMotionXToDeltaPlayable AnimationMotionXToDeltaPlayable Int32
    // 030 M_Mixers                                 000185D1EC88 ModelEnumListType List`1<WeightInfo> List`1<WeightInfo> List<WeightInfo> Pointer
    public partial class AnimationOutputWeightProcessor : DataModel
    {
        public AnimationPlayableOutput                  M_Output                                { get; set; }
        public AnimationMotionXToDeltaPlayable          M_MotionXPlayable                       { get; set; }
        public List<WeightInfo>?                        M_Mixers                                { get; set; }

        public static AnimationOutputWeightProcessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimationOutputWeightProcessor() { Pointer= p0 };

            value.M_Output                                  = (AnimationPlayableOutput)GetInt32(new IntPtr(p + 0x010)); // 02466B294290 0x10 M_Output                    ( 0001866B67B0 ModelEnumType AnimationPlayableOutput AnimationPlayableOutput AnimationPlayableOutput Int32 )
            value.M_MotionXPlayable                         = (AnimationMotionXToDeltaPlayable)GetInt32(new IntPtr(p + 0x020)); // 02466B2942B0 0x20 M_MotionXPlayable           ( 0001866B4D20 ModelEnumType AnimationMotionXToDeltaPlayable AnimationMotionXToDeltaPlayable AnimationMotionXToDeltaPlayable Int32 )
            value.M_Mixers                                  = GetEnumList<WeightInfo>(new IntPtr(p + 0x030)); // 02466B2942D0 0x30 M_Mixers                    ( 000185D1EC88 ModelEnumListType List`1<WeightInfo> List`1<WeightInfo> List<WeightInfo> Pointer )

            return value;
        }
    }
}
