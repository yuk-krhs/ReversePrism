using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 UnlockShinyCellSize                      ModelPrimitiveType float float float Single
    // 060 UnlockShinyCell                          ModelClassType MusicRateRewardListUnlockShinyCell MusicRateRewardListUnlockShinyCell MusicRateRewardListUnlockShinyCell Pointer
    // 068 EffectDuration                           ModelPrimitiveType float float float Single
    public partial class MusicRateRewardListView : DataModel
    {
        public float                                    UnlockShinyCellSize                     { get; set; }
        public MusicRateRewardListUnlockShinyCell?      UnlockShinyCell                         { get; set; }
        public float                                    EffectDuration                          { get; set; }

        public static MusicRateRewardListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateRewardListView() { Pointer= p0 };

            value.UnlockShinyCellSize                       = GetSingle(new IntPtr(p + 0x058)); // 0x58 UnlockShinyCellSize         ( ModelPrimitiveType float float float Single )
            value.UnlockShinyCell                           = GetObject<MusicRateRewardListUnlockShinyCell>(new IntPtr(p + 0x060), ReversePrism.DataModels.MusicRateRewardListUnlockShinyCell.FromPointer); // 0x60 UnlockShinyCell             ( ModelClassType MusicRateRewardListUnlockShinyCell MusicRateRewardListUnlockShinyCell MusicRateRewardListUnlockShinyCell Pointer )
            value.EffectDuration                            = GetSingle(new IntPtr(p + 0x068)); // 0x68 EffectDuration              ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
