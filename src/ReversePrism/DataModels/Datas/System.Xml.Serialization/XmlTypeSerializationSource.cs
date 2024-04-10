using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 AttributeOverridesHash                   000186671910 ModelPrimitiveType string string string String
    // 030 Type                                     000186692850 ModelClassType Type Type Type Pointer
    // 038 RootHash                                 000186671910 ModelPrimitiveType string string string String
    public partial class XmlTypeSerializationSource : DataModel
    {
        public string                                   AttributeOverridesHash                  { get; set; }
        public Type?                                    Type                                    { get; set; }
        public string                                   RootHash                                { get; set; }

        public static XmlTypeSerializationSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTypeSerializationSource() { Pointer= p0 };

            value.AttributeOverridesHash                    = GetString(new IntPtr(p + 0x028)); // 024667513730 0x28 AttributeOverridesHash      ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 024667513750 0x30 Type                        ( 000186692850 ModelClassType Type Type Type Pointer )
            value.RootHash                                  = GetString(new IntPtr(p + 0x038)); // 024667513770 0x38 RootHash                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
