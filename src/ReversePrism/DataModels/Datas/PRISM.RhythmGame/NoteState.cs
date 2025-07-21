using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 018 Entity                                   ModelClassType NoteEntity NoteEntity NoteEntity Pointer
    // 020 DisplayTime                              ModelPrimitiveType float float float Single
    // 024 Judged                                   ModelPrimitiveType bool bool bool Bool
    // 028 JudgeState                               ModelEnumType JudgeState JudgeState JudgeState Int32
    // 02C JudgmentResultType                       Nullable`1<JudgmentResultType> IL2CPP_TYPE_GENERICINST
    public partial class NoteState : DataModel
    {
        public int                                      Id                                      { get; set; }
        public NoteEntity?                              Entity                                  { get; set; }
        public float                                    DisplayTime                             { get; set; }
        public bool                                     Judged                                  { get; set; }
        public JudgeState                               JudgeState                              { get; set; }

        public static NoteState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoteState() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.Entity                                    = GetObject<NoteEntity>(new IntPtr(p + 0x018), ReversePrism.DataModels.NoteEntity.FromPointer); // 0x18 Entity                      ( ModelClassType NoteEntity NoteEntity NoteEntity Pointer )
            value.DisplayTime                               = GetSingle(new IntPtr(p + 0x020)); // 0x20 DisplayTime                 ( ModelPrimitiveType float float float Single )
            value.Judged                                    = GetBool(new IntPtr(p + 0x024)); // 0x24 Judged                      ( ModelPrimitiveType bool bool bool Bool )
            value.JudgeState                                = (JudgeState)GetInt32(new IntPtr(p + 0x028)); // 0x28 JudgeState                  ( ModelEnumType JudgeState JudgeState JudgeState Int32 )

            return value;
        }
    }
}
