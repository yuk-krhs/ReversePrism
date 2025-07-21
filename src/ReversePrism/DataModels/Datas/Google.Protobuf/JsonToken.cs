using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <Null>k__BackingField                    JsonToken IL2CPP_TYPE_CLASS
    // 008 <False>k__BackingField                   JsonToken IL2CPP_TYPE_CLASS
    // 010 True                                     ModelClassType JsonToken JsonToken JsonToken Pointer
    // 018 StartObject                              ModelClassType JsonToken JsonToken JsonToken Pointer
    // 020 EndObject                                ModelClassType JsonToken JsonToken JsonToken Pointer
    // 028 StartArray                               ModelClassType JsonToken JsonToken JsonToken Pointer
    // 030 EndArray                                 ModelClassType JsonToken JsonToken JsonToken Pointer
    // 038 EndDocument                              ModelClassType JsonToken JsonToken JsonToken Pointer
    // 010 Type                                     ModelEnumType TokenType TokenType TokenType Int32
    // 018 StringValue                              ModelPrimitiveType string string string String
    // 020 NumberValue                              ModelPrimitiveType double double double Double
    public partial class JsonToken : DataModel
    {
        public JsonToken?                               True                                    { get; set; }
        public JsonToken?                               StartObject                             { get; set; }
        public JsonToken?                               EndObject                               { get; set; }
        public JsonToken?                               StartArray                              { get; set; }
        public JsonToken?                               EndArray                                { get; set; }
        public JsonToken?                               EndDocument                             { get; set; }
        public TokenType                                Type                                    { get; set; }
        public string                                   StringValue                             { get; set; }
        public double                                   NumberValue                             { get; set; }

        public static JsonToken? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonToken() { Pointer= p0 };

            value.True                                      = GetObject<JsonToken>(new IntPtr(p + 0x010), ReversePrism.DataModels.JsonToken.FromPointer); // 0x10 True                        ( ModelClassType JsonToken JsonToken JsonToken Pointer )
            value.StartObject                               = GetObject<JsonToken>(new IntPtr(p + 0x018), ReversePrism.DataModels.JsonToken.FromPointer); // 0x18 StartObject                 ( ModelClassType JsonToken JsonToken JsonToken Pointer )
            value.EndObject                                 = GetObject<JsonToken>(new IntPtr(p + 0x020), ReversePrism.DataModels.JsonToken.FromPointer); // 0x20 EndObject                   ( ModelClassType JsonToken JsonToken JsonToken Pointer )
            value.StartArray                                = GetObject<JsonToken>(new IntPtr(p + 0x028), ReversePrism.DataModels.JsonToken.FromPointer); // 0x28 StartArray                  ( ModelClassType JsonToken JsonToken JsonToken Pointer )
            value.EndArray                                  = GetObject<JsonToken>(new IntPtr(p + 0x030), ReversePrism.DataModels.JsonToken.FromPointer); // 0x30 EndArray                    ( ModelClassType JsonToken JsonToken JsonToken Pointer )
            value.EndDocument                               = GetObject<JsonToken>(new IntPtr(p + 0x038), ReversePrism.DataModels.JsonToken.FromPointer); // 0x38 EndDocument                 ( ModelClassType JsonToken JsonToken JsonToken Pointer )
            value.Type                                      = (TokenType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType TokenType TokenType TokenType Int32 )
            value.StringValue                               = GetString(new IntPtr(p + 0x018)); // 0x18 StringValue                 ( ModelPrimitiveType string string string String )
            value.NumberValue                               = GetDouble(new IntPtr(p + 0x020)); // 0x20 NumberValue                 ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
