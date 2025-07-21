using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TokenType                                ModelEnumType JTokenType JTokenType JTokenType Int32
    // 018 _schemas                                 IList`1<JsonSchemaModel> IL2CPP_TYPE_GENERICINST
    // 020 _requiredProperties                      Dictionary`2<string, bool> IL2CPP_TYPE_GENERICINST
    // 028 CurrentPropertyName                      ModelPrimitiveType string string string String
    // 030 ArrayItemCount                           ModelPrimitiveType int int int Int32
    // 034 IsUniqueArray                            ModelPrimitiveType bool bool bool Bool
    // 038 <UniqueArrayItems>k__BackingField        IList`1<JToken> IL2CPP_TYPE_GENERICINST
    // 040 CurrentItemWriter                        ModelClassType JTokenWriter JTokenWriter JTokenWriter Pointer
    public partial class SchemaScope : DataModel
    {
        public JTokenType                               TokenType                               { get; set; }
        public string                                   CurrentPropertyName                     { get; set; }
        public int                                      ArrayItemCount                          { get; set; }
        public bool                                     IsUniqueArray                           { get; set; }
        public JTokenWriter?                            CurrentItemWriter                       { get; set; }

        public static SchemaScope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaScope() { Pointer= p0 };

            value.TokenType                                 = (JTokenType)GetInt32(new IntPtr(p + 0x010)); // 0x10 TokenType                   ( ModelEnumType JTokenType JTokenType JTokenType Int32 )
            value.CurrentPropertyName                       = GetString(new IntPtr(p + 0x028)); // 0x28 CurrentPropertyName         ( ModelPrimitiveType string string string String )
            value.ArrayItemCount                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 ArrayItemCount              ( ModelPrimitiveType int int int Int32 )
            value.IsUniqueArray                             = GetBool(new IntPtr(p + 0x034)); // 0x34 IsUniqueArray               ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentItemWriter                         = GetObject<JTokenWriter>(new IntPtr(p + 0x040), ReversePrism.DataModels.JTokenWriter.FromPointer); // 0x40 CurrentItemWriter           ( ModelClassType JTokenWriter JTokenWriter JTokenWriter Pointer )

            return value;
        }
    }
}
