using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 atomicValueType                          Type IL2CPP_TYPE_CLASS
    // 008 listValueType                            Type IL2CPP_TYPE_CLASS
    // 038 Types                                    ModelClassListType XmlSchemaSimpleType[] XmlSchemaSimpleType[] List<XmlSchemaSimpleType> Pointer
    public partial class Datatype_union : DataModel
    {
        public List<XmlSchemaSimpleType>?               Types                                   { get; set; }

        public static Datatype_union? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Datatype_union() { Pointer= p0 };

            value.Types                                     = GetObjectList<XmlSchemaSimpleType>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0x38 Types                       ( ModelClassListType XmlSchemaSimpleType[] XmlSchemaSimpleType[] List<XmlSchemaSimpleType> Pointer )

            return value;
        }
    }
}
