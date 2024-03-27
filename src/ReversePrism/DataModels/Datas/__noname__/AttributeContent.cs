using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AttDef                                   0001866E7090 ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer
    // 018 Name                                     0001866BCA70 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 020 Prefix                                   000186671BA0 ModelPrimitiveType string string string String
    // 028 Required                                 000186595210 ModelPrimitiveType bool bool bool Bool
    // 02C MinVal                                   000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 030 MaxVal                                   000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 034 MaxLength                                000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 038 MinLength                                000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 03C EnumerationRequired                      000186595210 ModelPrimitiveType bool bool bool Bool
    // 03D HasDataType                              000186595210 ModelPrimitiveType bool bool bool Bool
    // 03E Global                                   000186595210 ModelPrimitiveType bool bool bool Bool
    // 040 _Default                                 <object> IL2CPP_TYPE_OBJECT
    public partial class AttributeContent
    {
        public SchemaAttDef?                            AttDef                                  { get; set; }
        public XmlQualifiedName?                        Name                                    { get; set; }
        public string                                   Prefix                                  { get; set; }
        public bool                                     Required                                { get; set; }
        public uint                                     MinVal                                  { get; set; }
        public uint                                     MaxVal                                  { get; set; }
        public uint                                     MaxLength                               { get; set; }
        public uint                                     MinLength                               { get; set; }
        public bool                                     EnumerationRequired                     { get; set; }
        public bool                                     HasDataType                             { get; set; }
        public bool                                     Global                                  { get; set; }

        public static AttributeContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeContent();

            value.AttDef                                    = GetObject<SchemaAttDef>(new IntPtr(p + 0x010), ReversePrism.DataModels.SchemaAttDef.FromPointer); // 0270D7585C98 0x10 AttDef                      ( 0001866E7090 ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer )
            value.Name                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D7585CB8 0x18 Name                        ( 0001866BCA70 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Prefix                                    = GetString(new IntPtr(p + 0x020)); // 0270D7585CD8 0x20 Prefix                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Required                                  = GetBool(new IntPtr(p + 0x028)); // 0270D7585CF8 0x28 Required                    ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.MinVal                                    = GetUInt32(new IntPtr(p + 0x02C)); // 0270D7585D18 0x2C MinVal                      ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.MaxVal                                    = GetUInt32(new IntPtr(p + 0x030)); // 0270D7585D38 0x30 MaxVal                      ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.MaxLength                                 = GetUInt32(new IntPtr(p + 0x034)); // 0270D7585D58 0x34 MaxLength                   ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.MinLength                                 = GetUInt32(new IntPtr(p + 0x038)); // 0270D7585D78 0x38 MinLength                   ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.EnumerationRequired                       = GetBool(new IntPtr(p + 0x03C)); // 0270D7585D98 0x3C EnumerationRequired         ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.HasDataType                               = GetBool(new IntPtr(p + 0x03D)); // 0270D7585DB8 0x3D HasDataType                 ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Global                                    = GetBool(new IntPtr(p + 0x03E)); // 0270D7585DD8 0x3E Global                      ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
