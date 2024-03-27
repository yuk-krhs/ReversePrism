using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentFrameJudgingResults               000185CEF1C8 ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer
    // 018 PendingJudgmentResults                   000185CEF1C8 ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer
    // 020 TemporaryPendingJudgmentResults          000185CEF1C8 ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer
    // 000 EmptyJudgmentResults                     List`1<JudgmentResult> IL2CPP_TYPE_GENERICINST
    // 028 State                                    00018668CAD0 ModelClassType RhythmGameState RhythmGameState RhythmGameState Pointer
    // 030 JudgeManager                             00018658C210 ModelClassType IJudgeManager IJudgeManager IJudgeManager Pointer
    // 038 InputManager                             00018668F440 ModelClassType TouchInputService TouchInputService TouchInputService Pointer
    public partial class JudgeService
    {
        public List<JudgmentResult>?                    CurrentFrameJudgingResults              { get; set; }
        public List<JudgmentResult>?                    PendingJudgmentResults                  { get; set; }
        public List<JudgmentResult>?                    TemporaryPendingJudgmentResults         { get; set; }
        public RhythmGameState?                         State                                   { get; set; }
        public IJudgeManager?                           JudgeManager                            { get; set; }
        public TouchInputService?                       InputManager                            { get; set; }

        public static JudgeService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JudgeService();

            value.CurrentFrameJudgingResults                = GetEnumList<JudgmentResult>(new IntPtr(p + 0x010)); // 0270D4F86D08 0x10 CurrentFrameJudgingResults  ( 000185CEF1C8 ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer )
            value.PendingJudgmentResults                    = GetEnumList<JudgmentResult>(new IntPtr(p + 0x018)); // 0270D4F86D28 0x18 PendingJudgmentResults      ( 000185CEF1C8 ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer )
            value.TemporaryPendingJudgmentResults           = GetEnumList<JudgmentResult>(new IntPtr(p + 0x020)); // 0270D4F86D48 0x20 TemporaryPendingJudgmentResults ( 000185CEF1C8 ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer )
            value.State                                     = GetObject<RhythmGameState>(new IntPtr(p + 0x028), ReversePrism.DataModels.RhythmGameState.FromPointer); // 0270D4F86D88 0x28 State                       ( 00018668CAD0 ModelClassType RhythmGameState RhythmGameState RhythmGameState Pointer )
            value.JudgeManager                              = GetObject<IJudgeManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.IJudgeManager.FromPointer); // 0270D4F86DA8 0x30 JudgeManager                ( 00018658C210 ModelClassType IJudgeManager IJudgeManager IJudgeManager Pointer )
            value.InputManager                              = GetObject<TouchInputService>(new IntPtr(p + 0x038), ReversePrism.DataModels.TouchInputService.FromPointer); // 0270D4F86DC8 0x38 InputManager                ( 00018668F440 ModelClassType TouchInputService TouchInputService TouchInputService Pointer )

            return value;
        }
    }
}
