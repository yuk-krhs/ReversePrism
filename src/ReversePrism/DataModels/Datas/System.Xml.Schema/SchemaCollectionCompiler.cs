using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 CompileContentModel                      ModelPrimitiveType bool bool bool Bool
    // 048 Examplars                                ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 050 ComplexTypeStack                         ModelClassType Stack Stack Stack Pointer
    // 058 Schema                                   ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    public partial class SchemaCollectionCompiler : DataModel
    {
        public bool                                     CompileContentModel                     { get; set; }
        public XmlSchemaObjectTable?                    Examplars                               { get; set; }
        public Stack?                                   ComplexTypeStack                        { get; set; }
        public XmlSchema?                               Schema                                  { get; set; }

        public static SchemaCollectionCompiler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaCollectionCompiler() { Pointer= p0 };

            value.CompileContentModel                       = GetBool(new IntPtr(p + 0x040)); // 0x40 CompileContentModel         ( ModelPrimitiveType bool bool bool Bool )
            value.Examplars                                 = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x48 Examplars                   ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.ComplexTypeStack                          = GetObject<Stack>(new IntPtr(p + 0x050), ReversePrism.DataModels.Stack.FromPointer); // 0x50 ComplexTypeStack            ( ModelClassType Stack Stack Stack Pointer )
            value.Schema                                    = GetObject<XmlSchema>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchema.FromPointer); // 0x58 Schema                      ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )

            return value;
        }
    }
}
