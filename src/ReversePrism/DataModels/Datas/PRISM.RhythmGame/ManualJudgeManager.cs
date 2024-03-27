using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 judgmentRanges                           Dictionary`2<NoteType, ValueTuple`2<JudgementRange, JudgementRange>> IL2CPP_TYPE_GENERICINST
    // 018 Results                                  000185CEF1C8 ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer
    // 020 currentJudgmentResults                   Dictionary`2<NoteState, JudgmentResult> IL2CPP_TYPE_GENERICINST
    public partial class ManualJudgeManager
    {
        public List<JudgmentResult>?                    Results                                 { get; set; }

        public static ManualJudgeManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ManualJudgeManager();

            value.Results                                   = GetEnumList<JudgmentResult>(new IntPtr(p + 0x018)); // 0270D4F720C8 0x18 Results                     ( 000185CEF1C8 ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer )

            return value;
        }
    }
}
