using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NameTable                                ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 018 SchemaNames                              ModelClassType SchemaNames SchemaNames SchemaNames Pointer
    // 020 EventHandler                             ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 028 CompilationSettings                      ModelClassType XmlSchemaCompilationSettings XmlSchemaCompilationSettings XmlSchemaCompilationSettings Pointer
    // 030 ErrorCount                               ModelPrimitiveType int int int Int32
    // 038 NsXml                                    ModelPrimitiveType string string string String
    public partial class BaseProcessor : DataModel
    {
        public XmlNameTable?                            NameTable                               { get; set; }
        public SchemaNames?                             SchemaNames                             { get; set; }
        public ValidationEventHandler?                  EventHandler                            { get; set; }
        public XmlSchemaCompilationSettings?            CompilationSettings                     { get; set; }
        public int                                      ErrorCount                              { get; set; }
        public string                                   NsXml                                   { get; set; }

        public static BaseProcessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseProcessor() { Pointer= p0 };

            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x10 NameTable                   ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.SchemaNames                               = GetObject<SchemaNames>(new IntPtr(p + 0x018), ReversePrism.DataModels.SchemaNames.FromPointer); // 0x18 SchemaNames                 ( ModelClassType SchemaNames SchemaNames SchemaNames Pointer )
            value.EventHandler                              = GetObject<ValidationEventHandler>(new IntPtr(p + 0x020), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0x20 EventHandler                ( ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.CompilationSettings                       = GetObject<XmlSchemaCompilationSettings>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSchemaCompilationSettings.FromPointer); // 0x28 CompilationSettings         ( ModelClassType XmlSchemaCompilationSettings XmlSchemaCompilationSettings XmlSchemaCompilationSettings Pointer )
            value.ErrorCount                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 ErrorCount                  ( ModelPrimitiveType int int int Int32 )
            value.NsXml                                     = GetString(new IntPtr(p + 0x038)); // 0x38 NsXml                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
