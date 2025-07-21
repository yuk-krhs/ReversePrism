using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType JsonValueType JsonValueType JsonValueType Int32
    // 014 BoolValue                                ModelPrimitiveType bool bool bool Bool
    // 018 RealValue                                ModelPrimitiveType double double double Double
    // 020 IntegerValue                             ModelPrimitiveType long long long Int64
    // 028 StringValue                              ModelEnumType JsonString JsonString JsonString Int32
    // 040 ArrayValue                               ModelEnumListType List`1<JsonValue> List`1<JsonValue> List<JsonValue> Pointer
    // 048 objectValue                              Dictionary`2<string, JsonValue> IL2CPP_TYPE_GENERICINST
    // 050 anyValue                                 <object> IL2CPP_TYPE_OBJECT
    public partial class JsonValue : DataModel
    {
        public JsonValueType                            Type                                    { get; set; }
        public bool                                     BoolValue                               { get; set; }
        public double                                   RealValue                               { get; set; }
        public long                                     IntegerValue                            { get; set; }
        public JsonString                               StringValue                             { get; set; }
        public List<JsonValue>?                         ArrayValue                              { get; set; }

        public static JsonValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonValue() { Pointer= p0 };

            value.Type                                      = (JsonValueType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType JsonValueType JsonValueType JsonValueType Int32 )
            value.BoolValue                                 = GetBool(new IntPtr(p + 0x014)); // 0x14 BoolValue                   ( ModelPrimitiveType bool bool bool Bool )
            value.RealValue                                 = GetDouble(new IntPtr(p + 0x018)); // 0x18 RealValue                   ( ModelPrimitiveType double double double Double )
            value.IntegerValue                              = GetInt64(new IntPtr(p + 0x020)); // 0x20 IntegerValue                ( ModelPrimitiveType long long long Int64 )
            value.StringValue                               = (JsonString)GetInt32(new IntPtr(p + 0x028)); // 0x28 StringValue                 ( ModelEnumType JsonString JsonString JsonString Int32 )
            value.ArrayValue                                = GetEnumList<JsonValue>(new IntPtr(p + 0x040)); // 0x40 ArrayValue                  ( ModelEnumListType List`1<JsonValue> List`1<JsonValue> List<JsonValue> Pointer )

            return value;
        }
    }
}
