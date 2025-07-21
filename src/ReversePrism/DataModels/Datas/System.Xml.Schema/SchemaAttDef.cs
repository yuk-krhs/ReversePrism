using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 DefExpanded                              ModelPrimitiveType string string string String
    // 068 LineNum                                  ModelPrimitiveType int int int Int32
    // 06C LinePos                                  ModelPrimitiveType int int int Int32
    // 070 ValueLineNum                             ModelPrimitiveType int int int Int32
    // 074 ValueLinePos                             ModelPrimitiveType int int int Int32
    // 078 Reserved                                 ModelEnumType Reserve Reserve Reserve Int32
    // 07C DefaultValueChecked                      ModelPrimitiveType bool bool bool Bool
    // 080 SchemaAttribute                          ModelClassType XmlSchemaAttribute XmlSchemaAttribute XmlSchemaAttribute Pointer
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

            value.DefExpanded                               = GetString(new IntPtr(p + 0x060)); // 0x60 DefExpanded                 ( ModelPrimitiveType string string string String )
            value.LineNum                                   = GetInt32(new IntPtr(p + 0x068)); // 0x68 LineNum                     ( ModelPrimitiveType int int int Int32 )
            value.LinePos                                   = GetInt32(new IntPtr(p + 0x06C)); // 0x6C LinePos                     ( ModelPrimitiveType int int int Int32 )
            value.ValueLineNum                              = GetInt32(new IntPtr(p + 0x070)); // 0x70 ValueLineNum                ( ModelPrimitiveType int int int Int32 )
            value.ValueLinePos                              = GetInt32(new IntPtr(p + 0x074)); // 0x74 ValueLinePos                ( ModelPrimitiveType int int int Int32 )
            value.Reserved                                  = (Reserve)GetInt32(new IntPtr(p + 0x078)); // 0x78 Reserved                    ( ModelEnumType Reserve Reserve Reserve Int32 )
            value.DefaultValueChecked                       = GetBool(new IntPtr(p + 0x07C)); // 0x7C DefaultValueChecked         ( ModelPrimitiveType bool bool bool Bool )
            value.SchemaAttribute                           = GetObject<XmlSchemaAttribute>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaAttribute.FromPointer); // 0x80 SchemaAttribute             ( ModelClassType XmlSchemaAttribute XmlSchemaAttribute XmlSchemaAttribute Pointer )

            return value;
        }
    }
}
