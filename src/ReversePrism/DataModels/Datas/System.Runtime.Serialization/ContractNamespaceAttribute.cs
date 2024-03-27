using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClrNamespace                             000186671910 ModelPrimitiveType string string string String
    // 018 ContractNamespace                        000186671910 ModelPrimitiveType string string string String
    public partial class ContractNamespaceAttribute
    {
        public string                                   ClrNamespace                            { get; set; }
        public string                                   ContractNamespace                       { get; set; }

        public static ContractNamespaceAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContractNamespaceAttribute();

            value.ClrNamespace                              = GetString(new IntPtr(p + 0x010)); // 027004CC0480 0x10 ClrNamespace                ( 000186671910 ModelPrimitiveType string string string String )
            value.ContractNamespace                         = GetString(new IntPtr(p + 0x018)); // 027004CC04A0 0x18 ContractNamespace           ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
