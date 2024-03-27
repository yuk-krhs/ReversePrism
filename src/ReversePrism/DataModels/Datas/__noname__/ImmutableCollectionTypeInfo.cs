using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ContractTypeName                         000186671910 ModelPrimitiveType string string string String
    // 018 CreatedTypeName                          000186671910 ModelPrimitiveType string string string String
    // 020 BuilderTypeName                          000186671910 ModelPrimitiveType string string string String
    public partial class ImmutableCollectionTypeInfo
    {
        public string                                   ContractTypeName                        { get; set; }
        public string                                   CreatedTypeName                         { get; set; }
        public string                                   BuilderTypeName                         { get; set; }

        public static ImmutableCollectionTypeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ImmutableCollectionTypeInfo();

            value.ContractTypeName                          = GetString(new IntPtr(p + 0x010)); // 0270060CB778 0x10 ContractTypeName            ( 000186671910 ModelPrimitiveType string string string String )
            value.CreatedTypeName                           = GetString(new IntPtr(p + 0x018)); // 0270060CB798 0x18 CreatedTypeName             ( 000186671910 ModelPrimitiveType string string string String )
            value.BuilderTypeName                           = GetString(new IntPtr(p + 0x020)); // 0270060CB7B8 0x20 BuilderTypeName             ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
