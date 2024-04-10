using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Name                                     000186671910 ModelPrimitiveType string string string String
    // 058 Particle                                 0001865B75D0 ModelClassType XmlSchemaGroupBase XmlSchemaGroupBase XmlSchemaGroupBase Pointer
    // 060 CanonicalParticle                        0001865BD330 ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer
    // 068 Qname                                    0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 070 Redefined                                0001865B70D0 ModelClassType XmlSchemaGroup XmlSchemaGroup XmlSchemaGroup Pointer
    // 078 SelfReferenceCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XmlSchemaGroup : DataModel
    {
        public string                                   Name                                    { get; set; }
        public XmlSchemaGroupBase?                      Particle                                { get; set; }
        public XmlSchemaParticle?                       CanonicalParticle                       { get; set; }
        public XmlQualifiedName?                        Qname                                   { get; set; }
        public XmlSchemaGroup?                          Redefined                               { get; set; }
        public int                                      SelfReferenceCount                      { get; set; }

        public static XmlSchemaGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaGroup() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x050)); // 024667596000 0x50 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Particle                                  = GetObject<XmlSchemaGroupBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaGroupBase.FromPointer); // 024667596020 0x58 Particle                    ( 0001865B75D0 ModelClassType XmlSchemaGroupBase XmlSchemaGroupBase XmlSchemaGroupBase Pointer )
            value.CanonicalParticle                         = GetObject<XmlSchemaParticle>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaParticle.FromPointer); // 024667596040 0x60 CanonicalParticle           ( 0001865BD330 ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer )
            value.Qname                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667596060 0x68 Qname                       ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Redefined                                 = GetObject<XmlSchemaGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSchemaGroup.FromPointer); // 024667596080 0x70 Redefined                   ( 0001865B70D0 ModelClassType XmlSchemaGroup XmlSchemaGroup XmlSchemaGroup Pointer )
            value.SelfReferenceCount                        = GetInt32(new IntPtr(p + 0x078)); // 0246675960A0 0x78 SelfReferenceCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
