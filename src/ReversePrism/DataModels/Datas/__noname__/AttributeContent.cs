using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AttDef                                   ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer
    // 018 Name                                     ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 020 Prefix                                   ModelPrimitiveType string string string String
    // 028 Required                                 ModelPrimitiveType bool bool bool Bool
    // 02C MinVal                                   ModelPrimitiveType uint uint uint UInt32
    // 030 MaxVal                                   ModelPrimitiveType uint uint uint UInt32
    // 034 MaxLength                                ModelPrimitiveType uint uint uint UInt32
    // 038 MinLength                                ModelPrimitiveType uint uint uint UInt32
    // 03C EnumerationRequired                      ModelPrimitiveType bool bool bool Bool
    // 03D HasDataType                              ModelPrimitiveType bool bool bool Bool
    // 03E Global                                   ModelPrimitiveType bool bool bool Bool
    // 040 _Default                                 <object> IL2CPP_TYPE_OBJECT
    public partial class AttributeContent : DataModel
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
            var value   = new AttributeContent() { Pointer= p0 };

            value.AttDef                                    = GetObject<SchemaAttDef>(new IntPtr(p + 0x010), ReversePrism.DataModels.SchemaAttDef.FromPointer); // 0x10 AttDef                      ( ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer )
            value.Name                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x18 Name                        ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Prefix                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Prefix                      ( ModelPrimitiveType string string string String )
            value.Required                                  = GetBool(new IntPtr(p + 0x028)); // 0x28 Required                    ( ModelPrimitiveType bool bool bool Bool )
            value.MinVal                                    = GetUInt32(new IntPtr(p + 0x02C)); // 0x2C MinVal                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.MaxVal                                    = GetUInt32(new IntPtr(p + 0x030)); // 0x30 MaxVal                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.MaxLength                                 = GetUInt32(new IntPtr(p + 0x034)); // 0x34 MaxLength                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.MinLength                                 = GetUInt32(new IntPtr(p + 0x038)); // 0x38 MinLength                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.EnumerationRequired                       = GetBool(new IntPtr(p + 0x03C)); // 0x3C EnumerationRequired         ( ModelPrimitiveType bool bool bool Bool )
            value.HasDataType                               = GetBool(new IntPtr(p + 0x03D)); // 0x3D HasDataType                 ( ModelPrimitiveType bool bool bool Bool )
            value.Global                                    = GetBool(new IntPtr(p + 0x03E)); // 0x3E Global                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
