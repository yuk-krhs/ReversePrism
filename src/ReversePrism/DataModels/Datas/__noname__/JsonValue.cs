using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186663C10 ModelEnumType JsonValueType JsonValueType JsonValueType Int32
    // 014 BoolValue                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 RealValue                                0001865C2E50 ModelPrimitiveType double double double Double
    // 020 IntegerValue                             0001865F7E40 ModelPrimitiveType long long long Int64
    // 028 StringValue                              000186663730 ModelEnumType JsonString JsonString JsonString Int32
    // 040 ArrayValue                               000185D25F58 ModelEnumListType List`1<JsonValue> List`1<JsonValue> List<JsonValue> Pointer
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

            value.Type                                      = (JsonValueType)GetInt32(new IntPtr(p + 0x010)); // 02466791B138 0x10 Type                        ( 000186663C10 ModelEnumType JsonValueType JsonValueType JsonValueType Int32 )
            value.BoolValue                                 = GetBool(new IntPtr(p + 0x014)); // 02466791B158 0x14 BoolValue                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.RealValue                                 = GetDouble(new IntPtr(p + 0x018)); // 02466791B178 0x18 RealValue                   ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.IntegerValue                              = GetInt64(new IntPtr(p + 0x020)); // 02466791B198 0x20 IntegerValue                ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.StringValue                               = (JsonString)GetInt32(new IntPtr(p + 0x028)); // 02466791B1B8 0x28 StringValue                 ( 000186663730 ModelEnumType JsonString JsonString JsonString Int32 )
            value.ArrayValue                                = GetEnumList<JsonValue>(new IntPtr(p + 0x040)); // 02466791B1D8 0x40 ArrayValue                  ( 000185D25F58 ModelEnumListType List`1<JsonValue> List`1<JsonValue> List<JsonValue> Pointer )

            return value;
        }
    }
}
