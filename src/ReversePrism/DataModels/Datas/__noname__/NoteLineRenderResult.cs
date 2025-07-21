using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsRendering                              ModelPrimitiveType bool bool bool Bool
    // 011 IsJudging                                ModelPrimitiveType bool bool bool Bool
    // 014 JudgePosition                            ModelPrimitiveType float float float Single
    // 000 NotRendering                             NoteLineRenderResult IL2CPP_TYPE_VALUETYPE
    public partial class NoteLineRenderResult : DataModel
    {
        public bool                                     IsRendering                             { get; set; }
        public bool                                     IsJudging                               { get; set; }
        public float                                    JudgePosition                           { get; set; }

        public static NoteLineRenderResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoteLineRenderResult() { Pointer= p0 };

            value.IsRendering                               = GetBool(new IntPtr(p + 0x010)); // 0x10 IsRendering                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsJudging                                 = GetBool(new IntPtr(p + 0x011)); // 0x11 IsJudging                   ( ModelPrimitiveType bool bool bool Bool )
            value.JudgePosition                             = GetSingle(new IntPtr(p + 0x014)); // 0x14 JudgePosition               ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
