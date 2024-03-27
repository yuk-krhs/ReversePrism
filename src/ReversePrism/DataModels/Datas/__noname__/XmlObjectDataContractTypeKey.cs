using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AssemblyName                             000186671910 ModelPrimitiveType string string string String
    // 018 TypeName                                 000186671910 ModelPrimitiveType string string string String
    public partial class XmlObjectDataContractTypeKey
    {
        public string                                   AssemblyName                            { get; set; }
        public string                                   TypeName                                { get; set; }

        public static XmlObjectDataContractTypeKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlObjectDataContractTypeKey();

            value.AssemblyName                              = GetString(new IntPtr(p + 0x010)); // 0270D7D71530 0x10 AssemblyName                ( 000186671910 ModelPrimitiveType string string string String )
            value.TypeName                                  = GetString(new IntPtr(p + 0x018)); // 0270D7D71550 0x18 TypeName                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
