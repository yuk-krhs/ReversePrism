using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dstruct                                  000186655260 ModelClassType DecimalStruct DecimalStruct DecimalStruct Pointer
    // 018 ovalue                                   <object> IL2CPP_TYPE_OBJECT
    // 020 Svalue                                   000186671910 ModelPrimitiveType string string string String
    // 028 Xsdtype                                  0001865B3820 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 030 Dim                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 IsList                                   000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.Dstruct                                   = GetObject<DecimalStruct>(new IntPtr(p + 0x010), ReversePrism.DataModels.DecimalStruct.FromPointer); // 02466755AB28 0x10 Dstruct                     ( 000186655260 ModelClassType DecimalStruct DecimalStruct DecimalStruct Pointer )
            value.Svalue                                    = GetString(new IntPtr(p + 0x020)); // 02466755AB68 0x20 Svalue                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Xsdtype                                   = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 02466755AB88 0x28 Xsdtype                     ( 0001865B3820 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.Dim                                       = GetInt32(new IntPtr(p + 0x030)); // 02466755ABA8 0x30 Dim                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsList                                    = GetBool(new IntPtr(p + 0x034)); // 02466755ABC8 0x34 IsList                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
