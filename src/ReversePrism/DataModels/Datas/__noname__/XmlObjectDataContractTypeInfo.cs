using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Assembly                                 ModelClassType Assembly Assembly Assembly Pointer
    // 018 Type                                     ModelClassType Type Type Type Pointer
    public partial class XmlObjectDataContractTypeInfo : DataModel
    {
        public Assembly?                                Assembly                                { get; set; }
        public Type?                                    Type                                    { get; set; }

        public static XmlObjectDataContractTypeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlObjectDataContractTypeInfo() { Pointer= p0 };

            value.Assembly                                  = GetObject<Assembly>(new IntPtr(p + 0x010), ReversePrism.DataModels.Assembly.FromPointer); // 0x10 Assembly                    ( ModelClassType Assembly Assembly Assembly Pointer )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 Type                        ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
