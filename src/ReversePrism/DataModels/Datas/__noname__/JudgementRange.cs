using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ShinySeconds                             ModelPrimitiveType float float float Single
    // 014 PerfectSeconds                           ModelPrimitiveType float float float Single
    // 018 GreatSeconds                             ModelPrimitiveType float float float Single
    // 01C GoodSeconds                              ModelPrimitiveType float float float Single
    public partial class JudgementRange : DataModel
    {
        public float                                    ShinySeconds                            { get; set; }
        public float                                    PerfectSeconds                          { get; set; }
        public float                                    GreatSeconds                            { get; set; }
        public float                                    GoodSeconds                             { get; set; }

        public static JudgementRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JudgementRange() { Pointer= p0 };

            value.ShinySeconds                              = GetSingle(new IntPtr(p + 0x010)); // 0x10 ShinySeconds                ( ModelPrimitiveType float float float Single )
            value.PerfectSeconds                            = GetSingle(new IntPtr(p + 0x014)); // 0x14 PerfectSeconds              ( ModelPrimitiveType float float float Single )
            value.GreatSeconds                              = GetSingle(new IntPtr(p + 0x018)); // 0x18 GreatSeconds                ( ModelPrimitiveType float float float Single )
            value.GoodSeconds                               = GetSingle(new IntPtr(p + 0x01C)); // 0x1C GoodSeconds                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
