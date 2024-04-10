using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 DefExpanded                              000186671910 ModelPrimitiveType string string string String
    // 068 LineNum                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 06C LinePos                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 ValueLineNum                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 074 ValueLinePos                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 Reserved                                 000186732A00 ModelEnumType Reserve Reserve Reserve Int32
    // 07C DefaultValueChecked                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 080 SchemaAttribute                          0001865AE470 ModelClassType XmlSchemaAttribute XmlSchemaAttribute XmlSchemaAttribute Pointer
    // 000 Empty                                    SchemaAttDef IL2CPP_TYPE_CLASS
    public partial class SchemaAttDef : DataModel
    {
        public string                                   DefExpanded                             { get; set; }
        public int                                      LineNum                                 { get; set; }
        public int                                      LinePos                                 { get; set; }
        public int                                      ValueLineNum                            { get; set; }
        public int                                      ValueLinePos                            { get; set; }
        public Reserve                                  Reserved                                { get; set; }
        public bool                                     DefaultValueChecked                     { get; set; }
        public XmlSchemaAttribute?                      SchemaAttribute                         { get; set; }

        public static SchemaAttDef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaAttDef() { Pointer= p0 };

            value.DefExpanded                               = GetString(new IntPtr(p + 0x060)); // 024667445A08 0x60 DefExpanded                 ( 000186671910 ModelPrimitiveType string string string String )
            value.LineNum                                   = GetInt32(new IntPtr(p + 0x068)); // 024667445A28 0x68 LineNum                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LinePos                                   = GetInt32(new IntPtr(p + 0x06C)); // 024667445A48 0x6C LinePos                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ValueLineNum                              = GetInt32(new IntPtr(p + 0x070)); // 024667445A68 0x70 ValueLineNum                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ValueLinePos                              = GetInt32(new IntPtr(p + 0x074)); // 024667445A88 0x74 ValueLinePos                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Reserved                                  = (Reserve)GetInt32(new IntPtr(p + 0x078)); // 024667445AA8 0x78 Reserved                    ( 000186732A00 ModelEnumType Reserve Reserve Reserve Int32 )
            value.DefaultValueChecked                       = GetBool(new IntPtr(p + 0x07C)); // 024667445AC8 0x7C DefaultValueChecked         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SchemaAttribute                           = GetObject<XmlSchemaAttribute>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaAttribute.FromPointer); // 024667445AE8 0x80 SchemaAttribute             ( 0001865AE470 ModelClassType XmlSchemaAttribute XmlSchemaAttribute XmlSchemaAttribute Pointer )

            return value;
        }
    }
}
