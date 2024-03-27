using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementName                              000186671910 ModelPrimitiveType string string string String
    // 018 Namespace                                000186671910 ModelPrimitiveType string string string String
    // 020 Form                                     0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 028 Member                                   0001865D0040 ModelClassType XmlTypeMapMember XmlTypeMapMember XmlTypeMapMember Pointer
    // 030 _choiceValue                             <object> IL2CPP_TYPE_OBJECT
    // 038 IsNullable                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C NestingLevel                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 MappedType                               0001865D1D40 ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer
    // 048 Type                                     0001866D2C90 ModelClassType TypeData TypeData TypeData Pointer
    // 050 WrappedElement                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 054 ExplicitOrder                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XmlTypeMapElementInfo
    {
        public string                                   ElementName                             { get; set; }
        public string                                   Namespace                               { get; set; }
        public XmlSchemaForm                            Form                                    { get; set; }
        public XmlTypeMapMember?                        Member                                  { get; set; }
        public bool                                     IsNullable                              { get; set; }
        public int                                      NestingLevel                            { get; set; }
        public XmlTypeMapping?                          MappedType                              { get; set; }
        public TypeData?                                Type                                    { get; set; }
        public bool                                     WrappedElement                          { get; set; }
        public int                                      ExplicitOrder                           { get; set; }

        public static XmlTypeMapElementInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTypeMapElementInfo();

            value.ElementName                               = GetString(new IntPtr(p + 0x010)); // 0270D74CE398 0x10 ElementName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Namespace                                 = GetString(new IntPtr(p + 0x018)); // 0270D74CE3B8 0x18 Namespace                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x020)); // 0270D74CE3D8 0x20 Form                        ( 0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.Member                                    = GetObject<XmlTypeMapMember>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlTypeMapMember.FromPointer); // 0270D74CE3F8 0x28 Member                      ( 0001865D0040 ModelClassType XmlTypeMapMember XmlTypeMapMember XmlTypeMapMember Pointer )
            value.IsNullable                                = GetBool(new IntPtr(p + 0x038)); // 0270D74CE438 0x38 IsNullable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NestingLevel                              = GetInt32(new IntPtr(p + 0x03C)); // 0270D74CE458 0x3C NestingLevel                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MappedType                                = GetObject<XmlTypeMapping>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlTypeMapping.FromPointer); // 0270D74CE478 0x40 MappedType                  ( 0001865D1D40 ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer )
            value.Type                                      = GetObject<TypeData>(new IntPtr(p + 0x048), ReversePrism.DataModels.TypeData.FromPointer); // 0270D74CE498 0x48 Type                        ( 0001866D2C90 ModelClassType TypeData TypeData TypeData Pointer )
            value.WrappedElement                            = GetBool(new IntPtr(p + 0x050)); // 0270D74CE4B8 0x50 WrappedElement              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ExplicitOrder                             = GetInt32(new IntPtr(p + 0x054)); // 0270D74CE4D8 0x54 ExplicitOrder               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
