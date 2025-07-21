using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 RefName                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 080 Particle                                 ModelClassType XmlSchemaGroupBase XmlSchemaGroupBase XmlSchemaGroupBase Pointer
    // 088 Refined                                  ModelClassType XmlSchemaGroup XmlSchemaGroup XmlSchemaGroup Pointer
    public partial class XmlSchemaGroupRef : DataModel
    {
        public XmlQualifiedName?                        RefName                                 { get; set; }
        public XmlSchemaGroupBase?                      Particle                                { get; set; }
        public XmlSchemaGroup?                          Refined                                 { get; set; }

        public static XmlSchemaGroupRef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaGroupRef() { Pointer= p0 };

            value.RefName                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x78 RefName                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Particle                                  = GetObject<XmlSchemaGroupBase>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaGroupBase.FromPointer); // 0x80 Particle                    ( ModelClassType XmlSchemaGroupBase XmlSchemaGroupBase XmlSchemaGroupBase Pointer )
            value.Refined                                   = GetObject<XmlSchemaGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaGroup.FromPointer); // 0x88 Refined                     ( ModelClassType XmlSchemaGroup XmlSchemaGroup XmlSchemaGroup Pointer )

            return value;
        }
    }
}
