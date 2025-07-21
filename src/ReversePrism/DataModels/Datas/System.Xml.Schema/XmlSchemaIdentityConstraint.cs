using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Name                                     ModelPrimitiveType string string string String
    // 058 Selector                                 ModelClassType XmlSchemaXPath XmlSchemaXPath XmlSchemaXPath Pointer
    // 060 Fields                                   ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 068 QualifiedName                            ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 070 CompiledConstraint                       ModelClassType CompiledIdentityConstraint CompiledIdentityConstraint CompiledIdentityConstraint Pointer
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

            value.Name                                      = GetString(new IntPtr(p + 0x050)); // 0x50 Name                        ( ModelPrimitiveType string string string String )
            value.Selector                                  = GetObject<XmlSchemaXPath>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaXPath.FromPointer); // 0x58 Selector                    ( ModelClassType XmlSchemaXPath XmlSchemaXPath XmlSchemaXPath Pointer )
            value.Fields                                    = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0x60 Fields                      ( ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.QualifiedName                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x68 QualifiedName               ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.CompiledConstraint                        = GetObject<CompiledIdentityConstraint>(new IntPtr(p + 0x070), ReversePrism.DataModels.CompiledIdentityConstraint.FromPointer); // 0x70 CompiledConstraint          ( ModelClassType CompiledIdentityConstraint CompiledIdentityConstraint CompiledIdentityConstraint Pointer )

            return value;
        }
    }
}
