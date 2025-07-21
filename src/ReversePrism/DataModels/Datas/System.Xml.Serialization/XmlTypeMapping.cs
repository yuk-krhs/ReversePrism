using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 XmlType                                  ModelPrimitiveType string string string String
    // 050 XmlTypeNamespace                         ModelPrimitiveType string string string String
    // 058 Type                                     ModelClassType TypeData TypeData TypeData Pointer
    // 060 BaseMap                                  ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer
    // 068 MultiReferenceType                       ModelPrimitiveType bool bool bool Bool
    // 069 IncludeInSchema                          ModelPrimitiveType bool bool bool Bool
    // 06A IsNullable                               ModelPrimitiveType bool bool bool Bool
    // 06B IsAny                                    ModelPrimitiveType bool bool bool Bool
    // 070 DerivedTypes                             ModelClassType ArrayList ArrayList ArrayList Pointer
    public partial class XmlTypeMapping : DataModel
    {
        public string                                   XmlType                                 { get; set; }
        public string                                   XmlTypeNamespace                        { get; set; }
        public TypeData?                                Type                                    { get; set; }
        public XmlTypeMapping?                          BaseMap                                 { get; set; }
        public bool                                     MultiReferenceType                      { get; set; }
        public bool                                     IncludeInSchema                         { get; set; }
        public bool                                     IsNullable                              { get; set; }
        public bool                                     IsAny                                   { get; set; }
        public ArrayList?                               DerivedTypes                            { get; set; }

        public static XmlTypeMapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTypeMapping() { Pointer= p0 };

            value.XmlType                                   = GetString(new IntPtr(p + 0x048)); // 0x48 XmlType                     ( ModelPrimitiveType string string string String )
            value.XmlTypeNamespace                          = GetString(new IntPtr(p + 0x050)); // 0x50 XmlTypeNamespace            ( ModelPrimitiveType string string string String )
            value.Type                                      = GetObject<TypeData>(new IntPtr(p + 0x058), ReversePrism.DataModels.TypeData.FromPointer); // 0x58 Type                        ( ModelClassType TypeData TypeData TypeData Pointer )
            value.BaseMap                                   = GetObject<XmlTypeMapping>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlTypeMapping.FromPointer); // 0x60 BaseMap                     ( ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer )
            value.MultiReferenceType                        = GetBool(new IntPtr(p + 0x068)); // 0x68 MultiReferenceType          ( ModelPrimitiveType bool bool bool Bool )
            value.IncludeInSchema                           = GetBool(new IntPtr(p + 0x069)); // 0x69 IncludeInSchema             ( ModelPrimitiveType bool bool bool Bool )
            value.IsNullable                                = GetBool(new IntPtr(p + 0x06A)); // 0x6A IsNullable                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsAny                                     = GetBool(new IntPtr(p + 0x06B)); // 0x6B IsAny                       ( ModelPrimitiveType bool bool bool Bool )
            value.DerivedTypes                              = GetObject<ArrayList>(new IntPtr(p + 0x070), ReversePrism.DataModels.ArrayList.FromPointer); // 0x70 DerivedTypes                ( ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
