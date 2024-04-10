using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PerfectSeconds                           000186666050 ModelPrimitiveType float float float Single
    // 014 GreatSeconds                             000186666050 ModelPrimitiveType float float float Single
    // 018 GoodSeconds                              000186666050 ModelPrimitiveType float float float Single
    public partial class JudgementRange : DataModel
    {
        public float                                    PerfectSeconds                          { get; set; }
        public float                                    GreatSeconds                            { get; set; }
        public float                                    GoodSeconds                             { get; set; }

        public static JudgementRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JudgementRange() { Pointer= p0 };

            value.PerfectSeconds                            = GetSingle(new IntPtr(p + 0x010)); // 024664FE8F18 0x10 PerfectSeconds              ( 000186666050 ModelPrimitiveType float float float Single )
            value.GreatSeconds                              = GetSingle(new IntPtr(p + 0x014)); // 024664FE8F38 0x14 GreatSeconds                ( 000186666050 ModelPrimitiveType float float float Single )
            value.GoodSeconds                               = GetSingle(new IntPtr(p + 0x018)); // 024664FE8F58 0x18 GoodSeconds                 ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
