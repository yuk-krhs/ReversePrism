using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Results                                  000185CEF1C8 ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer
    // 018 judgmentResults                          Dictionary`2<NoteState, JudgmentResult> IL2CPP_TYPE_GENERICINST
    public partial class AutoJudgeManager
    {
        public List<JudgmentResult>?                    Results                                 { get; set; }

        public static AutoJudgeManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoJudgeManager();

            value.Results                                   = GetEnumList<JudgmentResult>(new IntPtr(p + 0x010)); // 0270D4F7A930 0x10 Results                     ( 000185CEF1C8 ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer )

            return value;
        }
    }
}
