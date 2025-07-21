using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dstruct                                  ModelClassType DecimalStruct DecimalStruct DecimalStruct Pointer
    // 018 ovalue                                   <object> IL2CPP_TYPE_OBJECT
    // 020 Svalue                                   ModelPrimitiveType string string string String
    // 028 Xsdtype                                  ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 030 Dim                                      ModelPrimitiveType int int int Int32
    // 034 IsList                                   ModelPrimitiveType bool bool bool Bool
    public partial class TypedObject : DataModel
    {
        public DecimalStruct?                           Dstruct                                 { get; set; }
        public string                                   Svalue                                  { get; set; }
        public XmlSchemaDatatype?                       Xsdtype                                 { get; set; }
        public int                                      Dim                                     { get; set; }
        public bool                                     IsList                                  { get; set; }

        public static TypedObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypedObject() { Pointer= p0 };

            value.Dstruct                                   = GetObject<DecimalStruct>(new IntPtr(p + 0x010), ReversePrism.DataModels.DecimalStruct.FromPointer); // 0x10 Dstruct                     ( ModelClassType DecimalStruct DecimalStruct DecimalStruct Pointer )
            value.Svalue                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Svalue                      ( ModelPrimitiveType string string string String )
            value.Xsdtype                                   = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 0x28 Xsdtype                     ( ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.Dim                                       = GetInt32(new IntPtr(p + 0x030)); // 0x30 Dim                         ( ModelPrimitiveType int int int Int32 )
            value.IsList                                    = GetBool(new IntPtr(p + 0x034)); // 0x34 IsList                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
