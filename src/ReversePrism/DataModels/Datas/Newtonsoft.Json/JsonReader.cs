using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TokenType                                ModelEnumType JsonToken JsonToken JsonToken Int32
    // 018 _value                                   <object> IL2CPP_TYPE_OBJECT
    // 020 _quoteChar                               char IL2CPP_TYPE_CHAR
    // 024 CurrentState                             ModelEnumType State State State Int32
    // 028 CurrentPosition                          ModelEnumType JsonPosition JsonPosition JsonPosition Int32
    // 040 Culture                                  ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 048 DateTimeZoneHandling                     ModelEnumType DateTimeZoneHandling DateTimeZoneHandling DateTimeZoneHandling Int32
    // 04C _maxDepth                                Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 054 HasExceededMaxDepth                      ModelPrimitiveType bool bool bool Bool
    // 058 DateParseHandling                        ModelEnumType DateParseHandling DateParseHandling DateParseHandling Int32
    // 05C FloatParseHandling                       ModelEnumType FloatParseHandling FloatParseHandling FloatParseHandling Int32
    // 060 DateFormatString                         ModelPrimitiveType string string string String
    // 068 Stack                                    ModelEnumListType List`1<JsonPosition> List`1<JsonPosition> List<JsonPosition> Pointer
    // 070 CloseInput                               ModelPrimitiveType bool bool bool Bool
    // 071 SupportMultipleContent                   ModelPrimitiveType bool bool bool Bool
    public partial class JsonReader : DataModel
    {
        public JsonToken                                TokenType                               { get; set; }
        public State                                    CurrentState                            { get; set; }
        public JsonPosition                             CurrentPosition                         { get; set; }
        public CultureInfo?                             Culture                                 { get; set; }
        public DateTimeZoneHandling                     DateTimeZoneHandling                    { get; set; }
        public bool                                     HasExceededMaxDepth                     { get; set; }
        public DateParseHandling                        DateParseHandling                       { get; set; }
        public FloatParseHandling                       FloatParseHandling                      { get; set; }
        public string                                   DateFormatString                        { get; set; }
        public List<JsonPosition>?                      Stack                                   { get; set; }
        public bool                                     CloseInput                              { get; set; }
        public bool                                     SupportMultipleContent                  { get; set; }

        public static JsonReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonReader() { Pointer= p0 };

            value.TokenType                                 = (JsonToken)GetInt32(new IntPtr(p + 0x010)); // 0x10 TokenType                   ( ModelEnumType JsonToken JsonToken JsonToken Int32 )
            value.CurrentState                              = (State)GetInt32(new IntPtr(p + 0x024)); // 0x24 CurrentState                ( ModelEnumType State State State Int32 )
            value.CurrentPosition                           = (JsonPosition)GetInt32(new IntPtr(p + 0x028)); // 0x28 CurrentPosition             ( ModelEnumType JsonPosition JsonPosition JsonPosition Int32 )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x40 Culture                     ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.DateTimeZoneHandling                      = (DateTimeZoneHandling)GetInt32(new IntPtr(p + 0x048)); // 0x48 DateTimeZoneHandling        ( ModelEnumType DateTimeZoneHandling DateTimeZoneHandling DateTimeZoneHandling Int32 )
            value.HasExceededMaxDepth                       = GetBool(new IntPtr(p + 0x054)); // 0x54 HasExceededMaxDepth         ( ModelPrimitiveType bool bool bool Bool )
            value.DateParseHandling                         = (DateParseHandling)GetInt32(new IntPtr(p + 0x058)); // 0x58 DateParseHandling           ( ModelEnumType DateParseHandling DateParseHandling DateParseHandling Int32 )
            value.FloatParseHandling                        = (FloatParseHandling)GetInt32(new IntPtr(p + 0x05C)); // 0x5C FloatParseHandling          ( ModelEnumType FloatParseHandling FloatParseHandling FloatParseHandling Int32 )
            value.DateFormatString                          = GetString(new IntPtr(p + 0x060)); // 0x60 DateFormatString            ( ModelPrimitiveType string string string String )
            value.Stack                                     = GetEnumList<JsonPosition>(new IntPtr(p + 0x068)); // 0x68 Stack                       ( ModelEnumListType List`1<JsonPosition> List`1<JsonPosition> List<JsonPosition> Pointer )
            value.CloseInput                                = GetBool(new IntPtr(p + 0x070)); // 0x70 CloseInput                  ( ModelPrimitiveType bool bool bool Bool )
            value.SupportMultipleContent                    = GetBool(new IntPtr(p + 0x071)); // 0x71 SupportMultipleContent      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
