using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TotalNoteCoefficient                     000186666CB0 ModelPrimitiveType float float float Single
    // 014 ScoreBase                                000186666CB0 ModelPrimitiveType float float float Single
    // 018 TargetScoreRanks                         000185B89630 ModelClassListType IScoreRankStatus[] IScoreRankStatus[] List<IScoreRankStatus> Pointer
    public partial class RhythmGameScoreService
    {
        public float                                    TotalNoteCoefficient                    { get; set; }
        public float                                    ScoreBase                               { get; set; }
        public List<IScoreRankStatus>?                  TargetScoreRanks                        { get; set; }

        public static RhythmGameScoreService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameScoreService();

            value.TotalNoteCoefficient                      = GetSingle(new IntPtr(p + 0x010)); // 0270D500E648 0x10 TotalNoteCoefficient        ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.ScoreBase                                 = GetSingle(new IntPtr(p + 0x014)); // 0270D500E668 0x14 ScoreBase                   ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.TargetScoreRanks                          = GetObjectList<IScoreRankStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IScoreRankStatus.FromPointer); // 0270D500E688 0x18 TargetScoreRanks            ( 000185B89630 ModelClassListType IScoreRankStatus[] IScoreRankStatus[] List<IScoreRankStatus> Pointer )

            return value;
        }
    }
}
