using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Attribute                                000186733D80 ModelEnumType Token Token Token Int32
    // 014 SchemaFlags                              0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Datatype                                 0001865B3AB0 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 020 BuildFunc                                000186727110 ModelClassType XdrBuildFunction XdrBuildFunction XdrBuildFunction Pointer
    public partial class XdrAttributeEntry
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
            var value   = new XdrAttributeEntry();

            value.Attribute                                 = (Token)GetInt32(new IntPtr(p + 0x010)); // 0270D75861F0 0x10 Attribute                   ( 000186733D80 ModelEnumType Token Token Token Int32 )
            value.SchemaFlags                               = GetInt32(new IntPtr(p + 0x014)); // 0270D7586210 0x14 SchemaFlags                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Datatype                                  = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 0270D7586230 0x18 Datatype                    ( 0001865B3AB0 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.BuildFunc                                 = GetObject<XdrBuildFunction>(new IntPtr(p + 0x020), ReversePrism.DataModels.XdrBuildFunction.FromPointer); // 0270D7586250 0x20 BuildFunc                   ( 000186727110 ModelClassType XdrBuildFunction XdrBuildFunction XdrBuildFunction Pointer )

            return value;
        }
    }
}
