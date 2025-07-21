using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Multiplicative                           ModelPrimitiveType float float float Single
    // 014 Additive                                 ModelPrimitiveType float float float Single
    public partial class BlendFactors : DataModel
    {
        public float                                    Multiplicative                          { get; set; }
        public float                                    Additive                                { get; set; }

        public static BlendFactors? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BlendFactors() { Pointer= p0 };

            value.Multiplicative                            = GetSingle(new IntPtr(p + 0x010)); // 0x10 Multiplicative              ( ModelPrimitiveType float float float Single )
            value.Additive                                  = GetSingle(new IntPtr(p + 0x014)); // 0x14 Additive                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
