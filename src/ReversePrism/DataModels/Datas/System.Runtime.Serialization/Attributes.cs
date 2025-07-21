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
    // 010 Id                                       ModelPrimitiveType string string string String
    // 018 Ref                                      ModelPrimitiveType string string string String
    // 020 XsiTypeName                              ModelPrimitiveType string string string String
    // 028 XsiTypeNamespace                         ModelPrimitiveType string string string String
    // 030 XsiTypePrefix                            ModelPrimitiveType string string string String
    // 038 XsiNil                                   ModelPrimitiveType bool bool bool Bool
    // 040 ClrAssembly                              ModelPrimitiveType string string string String
    // 048 ClrType                                  ModelPrimitiveType string string string String
    // 050 ArraySZSize                              ModelPrimitiveType int int int Int32
    // 058 FactoryTypeName                          ModelPrimitiveType string string string String
    // 060 FactoryTypeNamespace                     ModelPrimitiveType string string string String
    // 068 FactoryTypePrefix                        ModelPrimitiveType string string string String
    // 070 UnrecognizedAttributesFound              ModelPrimitiveType bool bool bool Bool
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

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType string string string String )
            value.Ref                                       = GetString(new IntPtr(p + 0x018)); // 0x18 Ref                         ( ModelPrimitiveType string string string String )
            value.XsiTypeName                               = GetString(new IntPtr(p + 0x020)); // 0x20 XsiTypeName                 ( ModelPrimitiveType string string string String )
            value.XsiTypeNamespace                          = GetString(new IntPtr(p + 0x028)); // 0x28 XsiTypeNamespace            ( ModelPrimitiveType string string string String )
            value.XsiTypePrefix                             = GetString(new IntPtr(p + 0x030)); // 0x30 XsiTypePrefix               ( ModelPrimitiveType string string string String )
            value.XsiNil                                    = GetBool(new IntPtr(p + 0x038)); // 0x38 XsiNil                      ( ModelPrimitiveType bool bool bool Bool )
            value.ClrAssembly                               = GetString(new IntPtr(p + 0x040)); // 0x40 ClrAssembly                 ( ModelPrimitiveType string string string String )
            value.ClrType                                   = GetString(new IntPtr(p + 0x048)); // 0x48 ClrType                     ( ModelPrimitiveType string string string String )
            value.ArraySZSize                               = GetInt32(new IntPtr(p + 0x050)); // 0x50 ArraySZSize                 ( ModelPrimitiveType int int int Int32 )
            value.FactoryTypeName                           = GetString(new IntPtr(p + 0x058)); // 0x58 FactoryTypeName             ( ModelPrimitiveType string string string String )
            value.FactoryTypeNamespace                      = GetString(new IntPtr(p + 0x060)); // 0x60 FactoryTypeNamespace        ( ModelPrimitiveType string string string String )
            value.FactoryTypePrefix                         = GetString(new IntPtr(p + 0x068)); // 0x68 FactoryTypePrefix           ( ModelPrimitiveType string string string String )
            value.UnrecognizedAttributesFound               = GetBool(new IntPtr(p + 0x070)); // 0x70 UnrecognizedAttributesFound ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
