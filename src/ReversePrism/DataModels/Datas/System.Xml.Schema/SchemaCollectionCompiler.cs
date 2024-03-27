using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 CompileContentModel                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 Examplars                                0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 050 ComplexTypeStack                         00018655EBF0 ModelClassType Stack Stack Stack Pointer
    // 058 Schema                                   0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    public partial class SchemaCollectionCompiler
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
            var value   = new SchemaCollectionCompiler();

            value.CompileContentModel                       = GetBool(new IntPtr(p + 0x040)); // 0270D752FB78 0x40 CompileContentModel         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Examplars                                 = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0270D752FB98 0x48 Examplars                   ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.ComplexTypeStack                          = GetObject<Stack>(new IntPtr(p + 0x050), ReversePrism.DataModels.Stack.FromPointer); // 0270D752FBB8 0x50 ComplexTypeStack            ( 00018655EBF0 ModelClassType Stack Stack Stack Pointer )
            value.Schema                                    = GetObject<XmlSchema>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchema.FromPointer); // 0270D752FBD8 0x58 Schema                      ( 0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )

            return value;
        }
    }
}
