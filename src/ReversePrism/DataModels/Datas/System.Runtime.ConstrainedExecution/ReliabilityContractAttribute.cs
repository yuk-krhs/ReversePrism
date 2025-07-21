using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ConsistencyGuarantee                     ModelEnumType Consistency Consistency Consistency Int32
    // 014 Cer                                      ModelEnumType Cer Cer Cer Int32
    public partial class ReliabilityContractAttribute : DataModel
    {
        public Consistency                              ConsistencyGuarantee                    { get; set; }
        public Cer                                      Cer                                     { get; set; }

        public static ReliabilityContractAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReliabilityContractAttribute() { Pointer= p0 };

            value.ConsistencyGuarantee                      = (Consistency)GetInt32(new IntPtr(p + 0x010)); // 0x10 ConsistencyGuarantee        ( ModelEnumType Consistency Consistency Consistency Int32 )
            value.Cer                                       = (Cer)GetInt32(new IntPtr(p + 0x014)); // 0x14 Cer                         ( ModelEnumType Cer Cer Cer Int32 )

            return value;
        }
    }
}
