using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentFrameJudgingResults               ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer
    // 018 PendingJudgmentResults                   ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer
    // 020 TemporaryPendingJudgmentResults          ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer
    // 000 EmptyJudgmentResults                     List`1<JudgmentResult> IL2CPP_TYPE_GENERICINST
    // 028 State                                    ModelClassType RhythmGameState RhythmGameState RhythmGameState Pointer
    // 030 JudgeManager                             ModelClassType IJudgeManager IJudgeManager IJudgeManager Pointer
    // 038 InputManager                             ModelClassType TouchInputService TouchInputService TouchInputService Pointer
    public partial class JudgeService : DataModel
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
            var value   = new JudgeService() { Pointer= p0 };

            value.CurrentFrameJudgingResults                = GetEnumList<JudgmentResult>(new IntPtr(p + 0x010)); // 0x10 CurrentFrameJudgingResults  ( ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer )
            value.PendingJudgmentResults                    = GetEnumList<JudgmentResult>(new IntPtr(p + 0x018)); // 0x18 PendingJudgmentResults      ( ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer )
            value.TemporaryPendingJudgmentResults           = GetEnumList<JudgmentResult>(new IntPtr(p + 0x020)); // 0x20 TemporaryPendingJudgmentResults ( ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer )
            value.State                                     = GetObject<RhythmGameState>(new IntPtr(p + 0x028), ReversePrism.DataModels.RhythmGameState.FromPointer); // 0x28 State                       ( ModelClassType RhythmGameState RhythmGameState RhythmGameState Pointer )
            value.JudgeManager                              = GetObject<IJudgeManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.IJudgeManager.FromPointer); // 0x30 JudgeManager                ( ModelClassType IJudgeManager IJudgeManager IJudgeManager Pointer )
            value.InputManager                              = GetObject<TouchInputService>(new IntPtr(p + 0x038), ReversePrism.DataModels.TouchInputService.FromPointer); // 0x38 InputManager                ( ModelClassType TouchInputService TouchInputService TouchInputService Pointer )

            return value;
        }
    }
}
