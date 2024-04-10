using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TokenType                                000186748850 ModelEnumType JTokenType JTokenType JTokenType Int32
    // 018 _schemas                                 IList`1<JsonSchemaModel> IL2CPP_TYPE_GENERICINST
    // 020 _requiredProperties                      Dictionary`2<string, bool> IL2CPP_TYPE_GENERICINST
    // 028 CurrentPropertyName                      000186671910 ModelPrimitiveType string string string String
    // 030 ArrayItemCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 IsUniqueArray                            0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 038 <UniqueArrayItems>k__BackingField        IList`1<JToken> IL2CPP_TYPE_GENERICINST
    // 040 CurrentItemWriter                        000186748F70 ModelClassType JTokenWriter JTokenWriter JTokenWriter Pointer
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

            value.TokenType                                 = (JTokenType)GetInt32(new IntPtr(p + 0x010)); // 024668733BD0 0x10 TokenType                   ( 000186748850 ModelEnumType JTokenType JTokenType JTokenType Int32 )
            value.CurrentPropertyName                       = GetString(new IntPtr(p + 0x028)); // 024668733C30 0x28 CurrentPropertyName         ( 000186671910 ModelPrimitiveType string string string String )
            value.ArrayItemCount                            = GetInt32(new IntPtr(p + 0x030)); // 024668733C50 0x30 ArrayItemCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsUniqueArray                             = GetBool(new IntPtr(p + 0x034)); // 024668733C70 0x34 IsUniqueArray               ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.CurrentItemWriter                         = GetObject<JTokenWriter>(new IntPtr(p + 0x040), ReversePrism.DataModels.JTokenWriter.FromPointer); // 024668733CB0 0x40 CurrentItemWriter           ( 000186748F70 ModelClassType JTokenWriter JTokenWriter JTokenWriter Pointer )

            return value;
        }
    }
}
