using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 serializationLocalNames                  XmlDictionaryString[] IL2CPP_TYPE_SZARRAY
    // 008 schemaInstanceLocalNames                 XmlDictionaryString[] IL2CPP_TYPE_SZARRAY
    // 010 Id                                       000186671BA0 ModelPrimitiveType string string string String
    // 018 Ref                                      000186671BA0 ModelPrimitiveType string string string String
    // 020 XsiTypeName                              000186671BA0 ModelPrimitiveType string string string String
    // 028 XsiTypeNamespace                         000186671BA0 ModelPrimitiveType string string string String
    // 030 XsiTypePrefix                            000186671BA0 ModelPrimitiveType string string string String
    // 038 XsiNil                                   000186595210 ModelPrimitiveType bool bool bool Bool
    // 040 ClrAssembly                              000186671BA0 ModelPrimitiveType string string string String
    // 048 ClrType                                  000186671BA0 ModelPrimitiveType string string string String
    // 050 ArraySZSize                              0001865F2F90 ModelPrimitiveType int int int Int32
    // 058 FactoryTypeName                          000186671BA0 ModelPrimitiveType string string string String
    // 060 FactoryTypeNamespace                     000186671BA0 ModelPrimitiveType string string string String
    // 068 FactoryTypePrefix                        000186671BA0 ModelPrimitiveType string string string String
    // 070 UnrecognizedAttributesFound              000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class Attributes
    {
        public string                                   Id                                      { get; set; }
        public string                                   Ref                                     { get; set; }
        public string                                   XsiTypeName                             { get; set; }
        public string                                   XsiTypeNamespace                        { get; set; }
        public string                                   XsiTypePrefix                           { get; set; }
        public bool                                     XsiNil                                  { get; set; }
        public string                                   ClrAssembly                             { get; set; }
        public string                                   ClrType                                 { get; set; }
        public int                                      ArraySZSize                             { get; set; }
        public string                                   FactoryTypeName                         { get; set; }
        public string                                   FactoryTypeNamespace                    { get; set; }
        public string                                   FactoryTypePrefix                       { get; set; }
        public bool                                     UnrecognizedAttributesFound             { get; set; }

        public static Attributes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Attributes();

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 027004CF2F18 0x10 Id                          ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Ref                                       = GetString(new IntPtr(p + 0x018)); // 027004CF2F38 0x18 Ref                         ( 000186671BA0 ModelPrimitiveType string string string String )
            value.XsiTypeName                               = GetString(new IntPtr(p + 0x020)); // 027004CF2F58 0x20 XsiTypeName                 ( 000186671BA0 ModelPrimitiveType string string string String )
            value.XsiTypeNamespace                          = GetString(new IntPtr(p + 0x028)); // 027004CF2F78 0x28 XsiTypeNamespace            ( 000186671BA0 ModelPrimitiveType string string string String )
            value.XsiTypePrefix                             = GetString(new IntPtr(p + 0x030)); // 027004CF2F98 0x30 XsiTypePrefix               ( 000186671BA0 ModelPrimitiveType string string string String )
            value.XsiNil                                    = GetBool(new IntPtr(p + 0x038)); // 027004CF2FB8 0x38 XsiNil                      ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ClrAssembly                               = GetString(new IntPtr(p + 0x040)); // 027004CF2FD8 0x40 ClrAssembly                 ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ClrType                                   = GetString(new IntPtr(p + 0x048)); // 027004CF2FF8 0x48 ClrType                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ArraySZSize                               = GetInt32(new IntPtr(p + 0x050)); // 027004CF3018 0x50 ArraySZSize                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.FactoryTypeName                           = GetString(new IntPtr(p + 0x058)); // 027004CF3038 0x58 FactoryTypeName             ( 000186671BA0 ModelPrimitiveType string string string String )
            value.FactoryTypeNamespace                      = GetString(new IntPtr(p + 0x060)); // 027004CF3058 0x60 FactoryTypeNamespace        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.FactoryTypePrefix                         = GetString(new IntPtr(p + 0x068)); // 027004CF3078 0x68 FactoryTypePrefix           ( 000186671BA0 ModelPrimitiveType string string string String )
            value.UnrecognizedAttributesFound               = GetBool(new IntPtr(p + 0x070)); // 027004CF3098 0x70 UnrecognizedAttributesFound ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
