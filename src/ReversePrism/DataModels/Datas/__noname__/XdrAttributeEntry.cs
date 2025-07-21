using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Attribute                                ModelEnumType Token Token Token Int32
    // 014 SchemaFlags                              ModelPrimitiveType int int int Int32
    // 018 Datatype                                 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 020 BuildFunc                                ModelClassType XdrBuildFunction XdrBuildFunction XdrBuildFunction Pointer
    public partial class XdrAttributeEntry : DataModel
    {
        public Token                                    Attribute                               { get; set; }
        public int                                      SchemaFlags                             { get; set; }
        public XmlSchemaDatatype?                       Datatype                                { get; set; }
        public XdrBuildFunction?                        BuildFunc                               { get; set; }

        public static XdrAttributeEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XdrAttributeEntry() { Pointer= p0 };

            value.Attribute                                 = (Token)GetInt32(new IntPtr(p + 0x010)); // 0x10 Attribute                   ( ModelEnumType Token Token Token Int32 )
            value.SchemaFlags                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 SchemaFlags                 ( ModelPrimitiveType int int int Int32 )
            value.Datatype                                  = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 0x18 Datatype                    ( ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.BuildFunc                                 = GetObject<XdrBuildFunction>(new IntPtr(p + 0x020), ReversePrism.DataModels.XdrBuildFunction.FromPointer); // 0x20 BuildFunc                   ( ModelClassType XdrBuildFunction XdrBuildFunction XdrBuildFunction Pointer )

            return value;
        }
    }
}
