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
    public partial class Attributes : DataModel
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
            var value   = new Attributes() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0245A4D28C80 0x10 Id                          ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Ref                                       = GetString(new IntPtr(p + 0x018)); // 0245A4D28CA0 0x18 Ref                         ( 000186671BA0 ModelPrimitiveType string string string String )
            value.XsiTypeName                               = GetString(new IntPtr(p + 0x020)); // 0245A4D28CC0 0x20 XsiTypeName                 ( 000186671BA0 ModelPrimitiveType string string string String )
            value.XsiTypeNamespace                          = GetString(new IntPtr(p + 0x028)); // 0245A4D28CE0 0x28 XsiTypeNamespace            ( 000186671BA0 ModelPrimitiveType string string string String )
            value.XsiTypePrefix                             = GetString(new IntPtr(p + 0x030)); // 0245A4D28D00 0x30 XsiTypePrefix               ( 000186671BA0 ModelPrimitiveType string string string String )
            value.XsiNil                                    = GetBool(new IntPtr(p + 0x038)); // 0245A4D28D20 0x38 XsiNil                      ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ClrAssembly                               = GetString(new IntPtr(p + 0x040)); // 0245A4D28D40 0x40 ClrAssembly                 ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ClrType                                   = GetString(new IntPtr(p + 0x048)); // 0245A4D28D60 0x48 ClrType                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ArraySZSize                               = GetInt32(new IntPtr(p + 0x050)); // 0245A4D28D80 0x50 ArraySZSize                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.FactoryTypeName                           = GetString(new IntPtr(p + 0x058)); // 0245A4D28DA0 0x58 FactoryTypeName             ( 000186671BA0 ModelPrimitiveType string string string String )
            value.FactoryTypeNamespace                      = GetString(new IntPtr(p + 0x060)); // 0245A4D28DC0 0x60 FactoryTypeNamespace        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.FactoryTypePrefix                         = GetString(new IntPtr(p + 0x068)); // 0245A4D28DE0 0x68 FactoryTypePrefix           ( 000186671BA0 ModelPrimitiveType string string string String )
            value.UnrecognizedAttributesFound               = GetBool(new IntPtr(p + 0x070)); // 0245A4D28E00 0x70 UnrecognizedAttributesFound ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
