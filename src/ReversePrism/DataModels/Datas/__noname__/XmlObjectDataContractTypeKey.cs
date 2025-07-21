using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AssemblyName                             ModelPrimitiveType string string string String
    // 018 TypeName                                 ModelPrimitiveType string string string String
    public partial class XmlObjectDataContractTypeKey : DataModel
    {
        public string                                   AssemblyName                            { get; set; }
        public string                                   TypeName                                { get; set; }

        public static XmlObjectDataContractTypeKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlObjectDataContractTypeKey() { Pointer= p0 };

            value.AssemblyName                              = GetString(new IntPtr(p + 0x010)); // 0x10 AssemblyName                ( ModelPrimitiveType string string string String )
            value.TypeName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 TypeName                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
