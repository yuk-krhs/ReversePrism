using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType JudgmentResultType JudgmentResultType JudgmentResultType Int32
    // 014 LagType                                  ModelEnumType JudgmentLagType JudgmentLagType JudgmentLagType Int32
    // 018 TargetNote                               ModelClassType NoteState NoteState NoteState Pointer
    // 020 IsSkillBoosted                           ModelPrimitiveType bool bool bool Bool
    public partial class JudgmentResultForEffect : DataModel
    {
        public JudgmentResultType                       Type                                    { get; set; }
        public JudgmentLagType                          LagType                                 { get; set; }
        public NoteState?                               TargetNote                              { get; set; }
        public bool                                     IsSkillBoosted                          { get; set; }

        public static JudgmentResultForEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JudgmentResultForEffect() { Pointer= p0 };

            value.Type                                      = (JudgmentResultType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType JudgmentResultType JudgmentResultType JudgmentResultType Int32 )
            value.LagType                                   = (JudgmentLagType)GetInt32(new IntPtr(p + 0x014)); // 0x14 LagType                     ( ModelEnumType JudgmentLagType JudgmentLagType JudgmentLagType Int32 )
            value.TargetNote                                = GetObject<NoteState>(new IntPtr(p + 0x018), ReversePrism.DataModels.NoteState.FromPointer); // 0x18 TargetNote                  ( ModelClassType NoteState NoteState NoteState Pointer )
            value.IsSkillBoosted                            = GetBool(new IntPtr(p + 0x020)); // 0x20 IsSkillBoosted              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
