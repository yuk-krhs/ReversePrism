using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsRendering                              000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 011 IsJudging                                000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 014 JudgePosition                            000186666F40 ModelPrimitiveType float float float Single
    // 000 NotRendering                             NoteLineRenderResult IL2CPP_TYPE_VALUETYPE
    public partial class NoteLineRenderResult
    {
        public bool                                     IsRendering                             { get; set; }
        public bool                                     IsJudging                               { get; set; }
        public float                                    JudgePosition                           { get; set; }

        public static NoteLineRenderResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoteLineRenderResult();

            value.IsRendering                               = GetBool(new IntPtr(p + 0x010)); // 0270D4FAF8E8 0x10 IsRendering                 ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.IsJudging                                 = GetBool(new IntPtr(p + 0x011)); // 0270D4FAF908 0x11 IsJudging                   ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.JudgePosition                             = GetSingle(new IntPtr(p + 0x014)); // 0270D4FAF928 0x14 JudgePosition               ( 000186666F40 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
