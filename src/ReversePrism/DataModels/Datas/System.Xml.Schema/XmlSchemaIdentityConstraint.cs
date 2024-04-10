using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Name                                     000186671910 ModelPrimitiveType string string string String
    // 058 Selector                                 0001865C4920 ModelClassType XmlSchemaXPath XmlSchemaXPath XmlSchemaXPath Pointer
    // 060 Fields                                   0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 068 QualifiedName                            0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 070 CompiledConstraint                       0001865EF900 ModelClassType CompiledIdentityConstraint CompiledIdentityConstraint CompiledIdentityConstraint Pointer
    public partial class XmlSchemaIdentityConstraint : DataModel
    {
        public string                                   Name                                    { get; set; }
        public XmlSchemaXPath?                          Selector                                { get; set; }
        public XmlSchemaObjectCollection?               Fields                                  { get; set; }
        public XmlQualifiedName?                        QualifiedName                           { get; set; }
        public CompiledIdentityConstraint?              CompiledConstraint                      { get; set; }

        public static XmlSchemaIdentityConstraint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaIdentityConstraint() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x050)); // 024667559B38 0x50 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Selector                                  = GetObject<XmlSchemaXPath>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaXPath.FromPointer); // 024667559B58 0x58 Selector                    ( 0001865C4920 ModelClassType XmlSchemaXPath XmlSchemaXPath XmlSchemaXPath Pointer )
            value.Fields                                    = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 024667559B78 0x60 Fields                      ( 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.QualifiedName                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667559B98 0x68 QualifiedName               ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.CompiledConstraint                        = GetObject<CompiledIdentityConstraint>(new IntPtr(p + 0x070), ReversePrism.DataModels.CompiledIdentityConstraint.FromPointer); // 024667559BB8 0x70 CompiledConstraint          ( 0001865EF900 ModelClassType CompiledIdentityConstraint CompiledIdentityConstraint CompiledIdentityConstraint Pointer )

            return value;
        }
    }
}
