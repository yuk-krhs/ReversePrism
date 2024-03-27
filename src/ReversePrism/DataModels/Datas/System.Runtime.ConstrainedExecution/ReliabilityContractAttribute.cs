using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ConsistencyGuarantee                     000186607740 ModelEnumType Consistency Consistency Consistency Int32
    // 014 Cer                                      000186553BC0 ModelEnumType Cer Cer Cer Int32
    public partial class ReliabilityContractAttribute
    {
        public Consistency                              ConsistencyGuarantee                    { get; set; }
        public Cer                                      Cer                                     { get; set; }

        public static ReliabilityContractAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReliabilityContractAttribute();

            value.ConsistencyGuarantee                      = (Consistency)GetInt32(new IntPtr(p + 0x010)); // 0270D6CA3240 0x10 ConsistencyGuarantee        ( 000186607740 ModelEnumType Consistency Consistency Consistency Int32 )
            value.Cer                                       = (Cer)GetInt32(new IntPtr(p + 0x014)); // 0270D6CA3260 0x14 Cer                         ( 000186553BC0 ModelEnumType Cer Cer Cer Int32 )

            return value;
        }
    }
}
