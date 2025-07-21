using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 StateArray                               State[][] IL2CPP_TYPE_SZARRAY
    // 008 StateArrayTemplate                       State[][] IL2CPP_TYPE_SZARRAY
    // 010 Stack                                    ModelEnumListType List`1<JsonPosition> List`1<JsonPosition> List<JsonPosition> Pointer
    // 018 CurrentPosition                          ModelEnumType JsonPosition JsonPosition JsonPosition Int32
    // 030 CurrentState                             ModelEnumType State State State Int32
    // 034 Formatting                               ModelEnumType Formatting Formatting Formatting Int32
    // 038 CloseOutput                              ModelPrimitiveType bool bool bool Bool
    // 039 AutoCompleteOnClose                      ModelPrimitiveType bool bool bool Bool
    // 03C DateFormatHandling                       ModelEnumType DateFormatHandling DateFormatHandling DateFormatHandling Int32
    // 040 DateTimeZoneHandling                     ModelEnumType DateTimeZoneHandling DateTimeZoneHandling DateTimeZoneHandling Int32
    // 044 StringEscapeHandling                     ModelEnumType StringEscapeHandling StringEscapeHandling StringEscapeHandling Int32
    // 048 FloatFormatHandling                      ModelEnumType FloatFormatHandling FloatFormatHandling FloatFormatHandling Int32
    // 050 DateFormatString                         ModelPrimitiveType string string string String
    // 058 Culture                                  ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    public partial class JsonWriter : DataModel
    {
        public List<JsonPosition>?                      Stack                                   { get; set; }
        public JsonPosition                             CurrentPosition                         { get; set; }
        public State                                    CurrentState                            { get; set; }
        public Formatting                               Formatting                              { get; set; }
        public bool                                     CloseOutput                             { get; set; }
        public bool                                     AutoCompleteOnClose                     { get; set; }
        public DateFormatHandling                       DateFormatHandling                      { get; set; }
        public DateTimeZoneHandling                     DateTimeZoneHandling                    { get; set; }
        public StringEscapeHandling                     StringEscapeHandling                    { get; set; }
        public FloatFormatHandling                      FloatFormatHandling                     { get; set; }
        public string                                   DateFormatString                        { get; set; }
        public CultureInfo?                             Culture                                 { get; set; }

        public static JsonWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonWriter() { Pointer= p0 };

            value.Stack                                     = GetEnumList<JsonPosition>(new IntPtr(p + 0x010)); // 0x10 Stack                       ( ModelEnumListType List`1<JsonPosition> List`1<JsonPosition> List<JsonPosition> Pointer )
            value.CurrentPosition                           = (JsonPosition)GetInt32(new IntPtr(p + 0x018)); // 0x18 CurrentPosition             ( ModelEnumType JsonPosition JsonPosition JsonPosition Int32 )
            value.CurrentState                              = (State)GetInt32(new IntPtr(p + 0x030)); // 0x30 CurrentState                ( ModelEnumType State State State Int32 )
            value.Formatting                                = (Formatting)GetInt32(new IntPtr(p + 0x034)); // 0x34 Formatting                  ( ModelEnumType Formatting Formatting Formatting Int32 )
            value.CloseOutput                               = GetBool(new IntPtr(p + 0x038)); // 0x38 CloseOutput                 ( ModelPrimitiveType bool bool bool Bool )
            value.AutoCompleteOnClose                       = GetBool(new IntPtr(p + 0x039)); // 0x39 AutoCompleteOnClose         ( ModelPrimitiveType bool bool bool Bool )
            value.DateFormatHandling                        = (DateFormatHandling)GetInt32(new IntPtr(p + 0x03C)); // 0x3C DateFormatHandling          ( ModelEnumType DateFormatHandling DateFormatHandling DateFormatHandling Int32 )
            value.DateTimeZoneHandling                      = (DateTimeZoneHandling)GetInt32(new IntPtr(p + 0x040)); // 0x40 DateTimeZoneHandling        ( ModelEnumType DateTimeZoneHandling DateTimeZoneHandling DateTimeZoneHandling Int32 )
            value.StringEscapeHandling                      = (StringEscapeHandling)GetInt32(new IntPtr(p + 0x044)); // 0x44 StringEscapeHandling        ( ModelEnumType StringEscapeHandling StringEscapeHandling StringEscapeHandling Int32 )
            value.FloatFormatHandling                       = (FloatFormatHandling)GetInt32(new IntPtr(p + 0x048)); // 0x48 FloatFormatHandling         ( ModelEnumType FloatFormatHandling FloatFormatHandling FloatFormatHandling Int32 )
            value.DateFormatString                          = GetString(new IntPtr(p + 0x050)); // 0x50 DateFormatString            ( ModelPrimitiveType string string string String )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x58 Culture                     ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )

            return value;
        }
    }
}
