using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TotalNoteCoefficient                     ModelPrimitiveType float float float Single
    // 014 ScoreBase                                ModelPrimitiveType float float float Single
    // 018 TargetScoreRanks                         ModelClassType MstLiveScoreRankTarget MstLiveScoreRankTarget MstLiveScoreRankTarget Pointer
    public partial class RhythmGameScoreService : DataModel
    {
        public float                                    TotalNoteCoefficient                    { get; set; }
        public float                                    ScoreBase                               { get; set; }
        public MstLiveScoreRankTarget?                  TargetScoreRanks                        { get; set; }

        public static RhythmGameScoreService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameScoreService() { Pointer= p0 };

            value.TotalNoteCoefficient                      = GetSingle(new IntPtr(p + 0x010)); // 0x10 TotalNoteCoefficient        ( ModelPrimitiveType float float float Single )
            value.ScoreBase                                 = GetSingle(new IntPtr(p + 0x014)); // 0x14 ScoreBase                   ( ModelPrimitiveType float float float Single )
            value.TargetScoreRanks                          = GetObject<MstLiveScoreRankTarget>(new IntPtr(p + 0x018), ReversePrism.DataModels.MstLiveScoreRankTarget.FromPointer); // 0x18 TargetScoreRanks            ( ModelClassType MstLiveScoreRankTarget MstLiveScoreRankTarget MstLiveScoreRankTarget Pointer )

            return value;
        }
    }
}
