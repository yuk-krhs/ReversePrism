using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ContractTypeName                         ModelPrimitiveType string string string String
    // 018 CreatedTypeName                          ModelPrimitiveType string string string String
    // 020 BuilderTypeName                          ModelPrimitiveType string string string String
    public partial class ImmutableCollectionTypeInfo : DataModel
    {
        public string                                   ContractTypeName                        { get; set; }
        public string                                   CreatedTypeName                         { get; set; }
        public string                                   BuilderTypeName                         { get; set; }

        public static ImmutableCollectionTypeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ImmutableCollectionTypeInfo() { Pointer= p0 };

            value.ContractTypeName                          = GetString(new IntPtr(p + 0x010)); // 0x10 ContractTypeName            ( ModelPrimitiveType string string string String )
            value.CreatedTypeName                           = GetString(new IntPtr(p + 0x018)); // 0x18 CreatedTypeName             ( ModelPrimitiveType string string string String )
            value.BuilderTypeName                           = GetString(new IntPtr(p + 0x020)); // 0x20 BuilderTypeName             ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
