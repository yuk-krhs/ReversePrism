using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Res                                      000186671910 ModelPrimitiveType string string string String
    // 098 Args                                     000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A0 SourceUri                                000186671910 ModelPrimitiveType string string string String
    // 0A8 LineNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0AC LinePosition                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0B0 SourceSchemaObject                       0001865BC0E0 ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer
    // 0B8 Message                                  000186671910 ModelPrimitiveType string string string String
    public partial class XmlSchemaException
    {
        public string                                   Res                                     { get; set; }
        public List<string>?                            Args                                    { get; set; }
        public string                                   SourceUri                               { get; set; }
        public int                                      LineNumber                              { get; set; }
        public int                                      LinePosition                            { get; set; }
        public XmlSchemaObject?                         SourceSchemaObject                      { get; set; }
        public string                                   Message                                 { get; set; }

        public static XmlSchemaException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaException();

            value.Res                                       = GetString(new IntPtr(p + 0x090)); // 0270D73E3D10 0x90 Res                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Args                                      = GetStringList(new IntPtr(p + 0x098)); // 0270D73E3D30 0x98 Args                        ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SourceUri                                 = GetString(new IntPtr(p + 0x0A0)); // 0270D73E3D50 0xA0 SourceUri                   ( 000186671910 ModelPrimitiveType string string string String )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x0A8)); // 0270D73E3D70 0xA8 LineNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LinePosition                              = GetInt32(new IntPtr(p + 0x0AC)); // 0270D73E3D90 0xAC LinePosition                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SourceSchemaObject                        = GetObject<XmlSchemaObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlSchemaObject.FromPointer); // 0270D73E3DB0 0xB0 SourceSchemaObject          ( 0001865BC0E0 ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer )
            value.Message                                   = GetString(new IntPtr(p + 0x0B8)); // 0270D73E3DD0 0xB8 Message                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
