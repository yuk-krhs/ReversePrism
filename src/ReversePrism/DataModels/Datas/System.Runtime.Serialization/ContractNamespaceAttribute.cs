using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClrNamespace                             ModelPrimitiveType string string string String
    // 018 ContractNamespace                        ModelPrimitiveType string string string String
    public partial class ContractNamespaceAttribute : DataModel
    {
        public string                                   ClrNamespace                            { get; set; }
        public string                                   ContractNamespace                       { get; set; }

        public static ContractNamespaceAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContractNamespaceAttribute() { Pointer= p0 };

            value.ClrNamespace                              = GetString(new IntPtr(p + 0x010)); // 0x10 ClrNamespace                ( ModelPrimitiveType string string string String )
            value.ContractNamespace                         = GetString(new IntPtr(p + 0x018)); // 0x18 ContractNamespace           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
