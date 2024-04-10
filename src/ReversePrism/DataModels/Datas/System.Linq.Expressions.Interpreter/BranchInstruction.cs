using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_caches                                 Instruction[][][] IL2CPP_TYPE_SZARRAY
    // 018 HasResult                                000186596860 ModelPrimitiveType bool bool bool Bool
    // 019 HasValue                                 000186596860 ModelPrimitiveType bool bool bool Bool
    public partial class BranchInstruction : DataModel
    {
        public bool                                     HasResult                               { get; set; }
        public bool                                     HasValue                                { get; set; }

        public static BranchInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BranchInstruction() { Pointer= p0 };

            value.HasResult                                 = GetBool(new IntPtr(p + 0x018)); // 024669FF9370 0x18 HasResult                   ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.HasValue                                  = GetBool(new IntPtr(p + 0x019)); // 024669FF9390 0x19 HasValue                    ( 000186596860 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
