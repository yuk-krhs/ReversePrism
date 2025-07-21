using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NoteCount                                ModelPrimitiveType int int int Int32
    // 018 Results                                  ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer
    // 020 Shiny                                    ModelPrimitiveType int int int Int32
    // 028 Perfect                                  ModelClassType JudgmentResultCountDetail JudgmentResultCountDetail JudgmentResultCountDetail Pointer
    // 030 Great                                    ModelClassType JudgmentResultCountDetail JudgmentResultCountDetail JudgmentResultCountDetail Pointer
    // 038 Good                                     ModelClassType JudgmentResultCountDetail JudgmentResultCountDetail JudgmentResultCountDetail Pointer
    // 040 Miss                                     ModelPrimitiveType int int int Int32
    public partial class JudgmentResultList : DataModel
    {
        public int                                      NoteCount                               { get; set; }
        public List<JudgmentResult>?                    Results                                 { get; set; }
        public int                                      Shiny                                   { get; set; }
        public JudgmentResultCountDetail?               Perfect                                 { get; set; }
        public JudgmentResultCountDetail?               Great                                   { get; set; }
        public JudgmentResultCountDetail?               Good                                    { get; set; }
        public int                                      Miss                                    { get; set; }

        public static JudgmentResultList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JudgmentResultList() { Pointer= p0 };

            value.NoteCount                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 NoteCount                   ( ModelPrimitiveType int int int Int32 )
            value.Results                                   = GetEnumList<JudgmentResult>(new IntPtr(p + 0x018)); // 0x18 Results                     ( ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer )
            value.Shiny                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Shiny                       ( ModelPrimitiveType int int int Int32 )
            value.Perfect                                   = GetObject<JudgmentResultCountDetail>(new IntPtr(p + 0x028), ReversePrism.DataModels.JudgmentResultCountDetail.FromPointer); // 0x28 Perfect                     ( ModelClassType JudgmentResultCountDetail JudgmentResultCountDetail JudgmentResultCountDetail Pointer )
            value.Great                                     = GetObject<JudgmentResultCountDetail>(new IntPtr(p + 0x030), ReversePrism.DataModels.JudgmentResultCountDetail.FromPointer); // 0x30 Great                       ( ModelClassType JudgmentResultCountDetail JudgmentResultCountDetail JudgmentResultCountDetail Pointer )
            value.Good                                      = GetObject<JudgmentResultCountDetail>(new IntPtr(p + 0x038), ReversePrism.DataModels.JudgmentResultCountDetail.FromPointer); // 0x38 Good                        ( ModelClassType JudgmentResultCountDetail JudgmentResultCountDetail JudgmentResultCountDetail Pointer )
            value.Miss                                      = GetInt32(new IntPtr(p + 0x040)); // 0x40 Miss                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
