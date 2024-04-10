using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 FactoryTypeName                          000186671910 ModelPrimitiveType string string string String
    // 058 FactoryTypeNamespace                     000186671910 ModelPrimitiveType string string string String
    // 060 members                                  IList`1<ISerializableDataMember> IL2CPP_TYPE_GENERICINST
    public partial class ISerializableDataNode : DataModel
    {
        public string                                   FactoryTypeName                         { get; set; }
        public string                                   FactoryTypeNamespace                    { get; set; }

        public static ISerializableDataNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ISerializableDataNode() { Pointer= p0 };

            value.FactoryTypeName                           = GetString(new IntPtr(p + 0x050)); // 024667D9F580 0x50 FactoryTypeName             ( 000186671910 ModelPrimitiveType string string string String )
            value.FactoryTypeNamespace                      = GetString(new IntPtr(p + 0x058)); // 024667D9F5A0 0x58 FactoryTypeNamespace        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
