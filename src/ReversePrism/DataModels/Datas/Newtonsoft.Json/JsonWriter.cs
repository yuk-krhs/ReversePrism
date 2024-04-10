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
    // 010 Stack                                    000185CEEAC8 ModelEnumListType List`1<JsonPosition> List`1<JsonPosition> List<JsonPosition> Pointer
    // 018 CurrentPosition                          000186758540 ModelEnumType JsonPosition JsonPosition JsonPosition Int32
    // 030 CurrentState                             000186674340 ModelEnumType State State State Int32
    // 034 Formatting                               0001865B9450 ModelEnumType Formatting Formatting Formatting Int32
    // 038 CloseOutput                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 AutoCompleteOnClose                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C DateFormatHandling                       000186692260 ModelEnumType DateFormatHandling DateFormatHandling DateFormatHandling Int32
    // 040 DateTimeZoneHandling                     0001866970F0 ModelEnumType DateTimeZoneHandling DateTimeZoneHandling DateTimeZoneHandling Int32
    // 044 StringEscapeHandling                     0001865BE100 ModelEnumType StringEscapeHandling StringEscapeHandling StringEscapeHandling Int32
    // 048 FloatFormatHandling                      0001865A5860 ModelEnumType FloatFormatHandling FloatFormatHandling FloatFormatHandling Int32
    // 050 DateFormatString                         000186671910 ModelPrimitiveType string string string String
    // 058 Culture                                  0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
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

            value.Stack                                     = GetEnumList<JsonPosition>(new IntPtr(p + 0x010)); // 0245A66484B8 0x10 Stack                       ( 000185CEEAC8 ModelEnumListType List`1<JsonPosition> List`1<JsonPosition> List<JsonPosition> Pointer )
            value.CurrentPosition                           = (JsonPosition)GetInt32(new IntPtr(p + 0x018)); // 0245A66484D8 0x18 CurrentPosition             ( 000186758540 ModelEnumType JsonPosition JsonPosition JsonPosition Int32 )
            value.CurrentState                              = (State)GetInt32(new IntPtr(p + 0x030)); // 0245A66484F8 0x30 CurrentState                ( 000186674340 ModelEnumType State State State Int32 )
            value.Formatting                                = (Formatting)GetInt32(new IntPtr(p + 0x034)); // 0245A6648518 0x34 Formatting                  ( 0001865B9450 ModelEnumType Formatting Formatting Formatting Int32 )
            value.CloseOutput                               = GetBool(new IntPtr(p + 0x038)); // 0245A6648538 0x38 CloseOutput                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AutoCompleteOnClose                       = GetBool(new IntPtr(p + 0x039)); // 0245A6648558 0x39 AutoCompleteOnClose         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DateFormatHandling                        = (DateFormatHandling)GetInt32(new IntPtr(p + 0x03C)); // 0245A6648578 0x3C DateFormatHandling          ( 000186692260 ModelEnumType DateFormatHandling DateFormatHandling DateFormatHandling Int32 )
            value.DateTimeZoneHandling                      = (DateTimeZoneHandling)GetInt32(new IntPtr(p + 0x040)); // 0245A6648598 0x40 DateTimeZoneHandling        ( 0001866970F0 ModelEnumType DateTimeZoneHandling DateTimeZoneHandling DateTimeZoneHandling Int32 )
            value.StringEscapeHandling                      = (StringEscapeHandling)GetInt32(new IntPtr(p + 0x044)); // 0245A66485B8 0x44 StringEscapeHandling        ( 0001865BE100 ModelEnumType StringEscapeHandling StringEscapeHandling StringEscapeHandling Int32 )
            value.FloatFormatHandling                       = (FloatFormatHandling)GetInt32(new IntPtr(p + 0x048)); // 0245A66485D8 0x48 FloatFormatHandling         ( 0001865A5860 ModelEnumType FloatFormatHandling FloatFormatHandling FloatFormatHandling Int32 )
            value.DateFormatString                          = GetString(new IntPtr(p + 0x050)); // 0245A66485F8 0x50 DateFormatString            ( 000186671910 ModelPrimitiveType string string string String )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.CultureInfo.FromPointer); // 0245A6648618 0x58 Culture                     ( 0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )

            return value;
        }
    }
}
