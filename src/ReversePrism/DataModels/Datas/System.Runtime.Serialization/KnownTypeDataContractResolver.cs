using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Context                                  0001865A59A0 ModelClassType XmlObjectSerializerContext XmlObjectSerializerContext XmlObjectSerializerContext Pointer
    public partial class KnownTypeDataContractResolver : DataModel
    {
        public XmlObjectSerializerContext?              Context                                 { get; set; }

        public static KnownTypeDataContractResolver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KnownTypeDataContractResolver() { Pointer= p0 };

            value.Context                                   = GetObject<XmlObjectSerializerContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlObjectSerializerContext.FromPointer); // 024667DA7E30 0x10 Context                     ( 0001865A59A0 ModelClassType XmlObjectSerializerContext XmlObjectSerializerContext XmlObjectSerializerContext Pointer )

            return value;
        }
    }
}
