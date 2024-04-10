using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186603A80 ModelEnumType JudgmentResultType JudgmentResultType JudgmentResultType Int32
    // 018 TargetNote                               000186634AA0 ModelClassType NoteState NoteState NoteState Pointer
    // 020 State                                    000186766BA0 ModelEnumType JudgeState JudgeState JudgeState Int32
    // 024 LagSeconds                               000186666F40 ModelPrimitiveType float float float Single
    // 028 LagType                                  0001867677B0 ModelEnumType JudgmentLagType JudgmentLagType JudgmentLagType Int32
    public partial class JudgmentResult : DataModel
    {
        public JudgmentResultType                       Type                                    { get; set; }
        public NoteState?                               TargetNote                              { get; set; }
        public JudgeState                               State                                   { get; set; }
        public float                                    LagSeconds                              { get; set; }
        public JudgmentLagType                          LagType                                 { get; set; }

        public static JudgmentResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JudgmentResult() { Pointer= p0 };

            value.Type                                      = (JudgmentResultType)GetInt32(new IntPtr(p + 0x010)); // 024665004DA0 0x10 Type                        ( 000186603A80 ModelEnumType JudgmentResultType JudgmentResultType JudgmentResultType Int32 )
            value.TargetNote                                = GetObject<NoteState>(new IntPtr(p + 0x018), ReversePrism.DataModels.NoteState.FromPointer); // 024665004DC0 0x18 TargetNote                  ( 000186634AA0 ModelClassType NoteState NoteState NoteState Pointer )
            value.State                                     = (JudgeState)GetInt32(new IntPtr(p + 0x020)); // 024665004DE0 0x20 State                       ( 000186766BA0 ModelEnumType JudgeState JudgeState JudgeState Int32 )
            value.LagSeconds                                = GetSingle(new IntPtr(p + 0x024)); // 024665004E00 0x24 LagSeconds                  ( 000186666F40 ModelPrimitiveType float float float Single )
            value.LagType                                   = (JudgmentLagType)GetInt32(new IntPtr(p + 0x028)); // 024665004E20 0x28 LagType                     ( 0001867677B0 ModelEnumType JudgmentLagType JudgmentLagType JudgmentLagType Int32 )

            return value;
        }
    }
}
