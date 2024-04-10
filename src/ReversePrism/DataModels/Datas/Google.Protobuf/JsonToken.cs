using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _true                                    JsonToken IL2CPP_TYPE_CLASS
    // 008 _false                                   JsonToken IL2CPP_TYPE_CLASS
    // 010 Null                                     000186761E90 ModelClassType JsonToken JsonToken JsonToken Pointer
    // 018 StartObject                              000186761E90 ModelClassType JsonToken JsonToken JsonToken Pointer
    // 020 EndObject                                000186761E90 ModelClassType JsonToken JsonToken JsonToken Pointer
    // 028 StartArray                               000186761E90 ModelClassType JsonToken JsonToken JsonToken Pointer
    // 030 EndArray                                 000186761E90 ModelClassType JsonToken JsonToken JsonToken Pointer
    // 038 EndDocument                              000186761E90 ModelClassType JsonToken JsonToken JsonToken Pointer
    // 010 Type                                     000186671110 ModelEnumType TokenType TokenType TokenType Int32
    // 018 StringValue                              000186672F10 ModelPrimitiveType string string string String
    // 020 NumberValue                              0001865C35C0 ModelPrimitiveType double double double Double
    public partial class JsonToken : DataModel
    {
        public JsonToken?                               Null                                    { get; set; }
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

            value.Null                                      = GetObject<JsonToken>(new IntPtr(p + 0x010), ReversePrism.DataModels.JsonToken.FromPointer); // 02466A47CA20 0x10 Null                        ( 000186761E90 ModelClassType JsonToken JsonToken JsonToken Pointer )
            value.StartObject                               = GetObject<JsonToken>(new IntPtr(p + 0x018), ReversePrism.DataModels.JsonToken.FromPointer); // 02466A47CA40 0x18 StartObject                 ( 000186761E90 ModelClassType JsonToken JsonToken JsonToken Pointer )
            value.EndObject                                 = GetObject<JsonToken>(new IntPtr(p + 0x020), ReversePrism.DataModels.JsonToken.FromPointer); // 02466A47CA60 0x20 EndObject                   ( 000186761E90 ModelClassType JsonToken JsonToken JsonToken Pointer )
            value.StartArray                                = GetObject<JsonToken>(new IntPtr(p + 0x028), ReversePrism.DataModels.JsonToken.FromPointer); // 02466A47CA80 0x28 StartArray                  ( 000186761E90 ModelClassType JsonToken JsonToken JsonToken Pointer )
            value.EndArray                                  = GetObject<JsonToken>(new IntPtr(p + 0x030), ReversePrism.DataModels.JsonToken.FromPointer); // 02466A47CAA0 0x30 EndArray                    ( 000186761E90 ModelClassType JsonToken JsonToken JsonToken Pointer )
            value.EndDocument                               = GetObject<JsonToken>(new IntPtr(p + 0x038), ReversePrism.DataModels.JsonToken.FromPointer); // 02466A47CAC0 0x38 EndDocument                 ( 000186761E90 ModelClassType JsonToken JsonToken JsonToken Pointer )
            value.Type                                      = (TokenType)GetInt32(new IntPtr(p + 0x010)); // 02466A47CAE0 0x10 Type                        ( 000186671110 ModelEnumType TokenType TokenType TokenType Int32 )
            value.StringValue                               = GetString(new IntPtr(p + 0x018)); // 02466A47CB00 0x18 StringValue                 ( 000186672F10 ModelPrimitiveType string string string String )
            value.NumberValue                               = GetDouble(new IntPtr(p + 0x020)); // 02466A47CB20 0x20 NumberValue                 ( 0001865C35C0 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
