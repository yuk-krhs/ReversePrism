using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_invariantInfo                          DateTimeFormatInfo IL2CPP_TYPE_CLASS
    // 010 CultureData                              ModelClassType CultureData CultureData CultureData Pointer
    // 018 Name                                     ModelPrimitiveType string string string String
    // 020 LangName                                 ModelPrimitiveType string string string String
    // 028 CompareInfo                              ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    // 030 CultureInfo                              ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 038 AmDesignator                             ModelPrimitiveType string string string String
    // 040 PmDesignator                             ModelPrimitiveType string string string String
    // 048 DateSeparator                            ModelPrimitiveType string string string String
    // 050 GeneralShortTimePattern                  ModelPrimitiveType string string string String
    // 058 GeneralLongTimePattern                   ModelPrimitiveType string string string String
    // 060 TimeSeparator                            ModelPrimitiveType string string string String
    // 068 MonthDayPattern                          ModelPrimitiveType string string string String
    // 070 DateTimeOffsetPattern                    ModelPrimitiveType string string string String
    // 000 rfc1123Pattern                           string IL2CPP_TYPE_STRING
    // 000 sortableDateTimePattern                  string IL2CPP_TYPE_STRING
    // 000 universalSortableDateTimePattern         string IL2CPP_TYPE_STRING
    // 078 Calendar                                 ModelClassType Calendar Calendar Calendar Pointer
    // 080 FirstDayOfWeek                           ModelPrimitiveType int int int Int32
    // 084 CalendarWeekRule                         ModelPrimitiveType int int int Int32
    // 088 FullDateTimePattern                      ModelPrimitiveType string string string String
    // 090 AbbreviatedDayNames                      ModelPrimitiveListType string[] string[] List<string> Pointer
    // 098 M_superShortDayNames                     ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A0 DayNames                                 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A8 AbbreviatedMonthNames                    ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0B0 MonthNames                               ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0B8 GenitiveMonthNames                       ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0C0 M_genitiveAbbreviatedMonthNames          ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0C8 LeapYearMonthNames                       ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0D0 LongDatePattern                          ModelPrimitiveType string string string String
    // 0D8 ShortDatePattern                         ModelPrimitiveType string string string String
    // 0E0 YearMonthPattern                         ModelPrimitiveType string string string String
    // 0E8 LongTimePattern                          ModelPrimitiveType string string string String
    // 0F0 ShortTimePattern                         ModelPrimitiveType string string string String
    // 0F8 AllYearMonthPatterns                     ModelPrimitiveListType string[] string[] List<string> Pointer
    // 100 AllShortDatePatterns                     ModelPrimitiveListType string[] string[] List<string> Pointer
    // 108 AllLongDatePatterns                      ModelPrimitiveListType string[] string[] List<string> Pointer
    // 110 AllShortTimePatterns                     ModelPrimitiveListType string[] string[] List<string> Pointer
    // 118 AllLongTimePatterns                      ModelPrimitiveListType string[] string[] List<string> Pointer
    // 120 M_eraNames                               ModelPrimitiveListType string[] string[] List<string> Pointer
    // 128 M_abbrevEraNames                         ModelPrimitiveListType string[] string[] List<string> Pointer
    // 130 M_abbrevEnglishEraNames                  ModelPrimitiveListType string[] string[] List<string> Pointer
    // 138 OptionalCalendars                        ModelEnumListType CalendarId[] CalendarId[] List<CalendarId> Pointer
    // 000 DEFAULT_ALL_DATETIMES_SIZE               int IL2CPP_TYPE_I4
    // 140 IsReadOnly                               ModelPrimitiveType bool bool bool Bool
    // 144 FormatFlags                              ModelEnumType DateTimeFormatFlags DateTimeFormatFlags DateTimeFormatFlags Int32
    // 008 s_monthSpaces                            char[] IL2CPP_TYPE_SZARRAY
    // 000 RoundtripFormat                          string IL2CPP_TYPE_STRING
    // 000 RoundtripDateTimeUnfixed                 string IL2CPP_TYPE_STRING
    // 148 FullTimeSpanPositivePattern              ModelPrimitiveType string string string String
    // 150 FullTimeSpanNegativePattern              ModelPrimitiveType string string string String
    // 000 InvalidDateTimeStyles                    DateTimeStyles IL2CPP_TYPE_VALUETYPE
    // 158 DtfiTokenHash                            ModelClassListType TokenHashValue[] TokenHashValue[] List<TokenHashValue> Pointer
    // 000 TOKEN_HASH_SIZE                          int IL2CPP_TYPE_I4
    // 000 SECOND_PRIME                             int IL2CPP_TYPE_I4
    // 000 dateSeparatorOrTimeZoneOffset            string IL2CPP_TYPE_STRING
    // 000 invariantDateSeparator                   string IL2CPP_TYPE_STRING
    // 000 invariantTimeSeparator                   string IL2CPP_TYPE_STRING
    // 000 IgnorablePeriod                          string IL2CPP_TYPE_STRING
    // 000 IgnorableComma                           string IL2CPP_TYPE_STRING
    // 000 CJKYearSuff                              string IL2CPP_TYPE_STRING
    // 000 CJKMonthSuff                             string IL2CPP_TYPE_STRING
    // 000 CJKDaySuff                               string IL2CPP_TYPE_STRING
    // 000 KoreanYearSuff                           string IL2CPP_TYPE_STRING
    // 000 KoreanMonthSuff                          string IL2CPP_TYPE_STRING
    // 000 KoreanDaySuff                            string IL2CPP_TYPE_STRING
    // 000 KoreanHourSuff                           string IL2CPP_TYPE_STRING
    // 000 KoreanMinuteSuff                         string IL2CPP_TYPE_STRING
    // 000 KoreanSecondSuff                         string IL2CPP_TYPE_STRING
    // 000 CJKHourSuff                              string IL2CPP_TYPE_STRING
    // 000 ChineseHourSuff                          string IL2CPP_TYPE_STRING
    // 000 CJKMinuteSuff                            string IL2CPP_TYPE_STRING
    // 000 CJKSecondSuff                            string IL2CPP_TYPE_STRING
    // 000 JapaneseEraStart                         string IL2CPP_TYPE_STRING
    // 000 LocalTimeMark                            string IL2CPP_TYPE_STRING
    // 000 GMTName                                  string IL2CPP_TYPE_STRING
    // 000 ZuluName                                 string IL2CPP_TYPE_STRING
    // 000 KoreanLangName                           string IL2CPP_TYPE_STRING
    // 000 JapaneseLangName                         string IL2CPP_TYPE_STRING
    // 000 EnglishLangName                          string IL2CPP_TYPE_STRING
    // 010 S_jajpDTFI                               ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer
    // 018 S_zhtwDTFI                               ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer
    public partial class DateTimeFormatInfo : DataModel
    {
        public CultureData?                             CultureData                             { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   LangName                                { get; set; }
        public CompareInfo?                             CompareInfo                             { get; set; }
        public CultureInfo?                             CultureInfo                             { get; set; }
        public string                                   AmDesignator                            { get; set; }
        public string                                   PmDesignator                            { get; set; }
        public string                                   DateSeparator                           { get; set; }
        public string                                   GeneralShortTimePattern                 { get; set; }
        public string                                   GeneralLongTimePattern                  { get; set; }
        public string                                   TimeSeparator                           { get; set; }
        public string                                   MonthDayPattern                         { get; set; }
        public string                                   DateTimeOffsetPattern                   { get; set; }
        public Calendar?                                Calendar                                { get; set; }
        public int                                      FirstDayOfWeek                          { get; set; }
        public int                                      CalendarWeekRule                        { get; set; }
        public string                                   FullDateTimePattern                     { get; set; }
        public List<string>?                            AbbreviatedDayNames                     { get; set; }
        public List<string>?                            M_superShortDayNames                    { get; set; }
        public List<string>?                            DayNames                                { get; set; }
        public List<string>?                            AbbreviatedMonthNames                   { get; set; }
        public List<string>?                            MonthNames                              { get; set; }
        public List<string>?                            GenitiveMonthNames                      { get; set; }
        public List<string>?                            M_genitiveAbbreviatedMonthNames         { get; set; }
        public List<string>?                            LeapYearMonthNames                      { get; set; }
        public string                                   LongDatePattern                         { get; set; }
        public string                                   ShortDatePattern                        { get; set; }
        public string                                   YearMonthPattern                        { get; set; }
        public string                                   LongTimePattern                         { get; set; }
        public string                                   ShortTimePattern                        { get; set; }
        public List<string>?                            AllYearMonthPatterns                    { get; set; }
        public List<string>?                            AllShortDatePatterns                    { get; set; }
        public List<string>?                            AllLongDatePatterns                     { get; set; }
        public List<string>?                            AllShortTimePatterns                    { get; set; }
        public List<string>?                            AllLongTimePatterns                     { get; set; }
        public List<string>?                            M_eraNames                              { get; set; }
        public List<string>?                            M_abbrevEraNames                        { get; set; }
        public List<string>?                            M_abbrevEnglishEraNames                 { get; set; }
        public List<CalendarId>?                        OptionalCalendars                       { get; set; }
        public bool                                     IsReadOnly                              { get; set; }
        public DateTimeFormatFlags                      FormatFlags                             { get; set; }
        public string                                   FullTimeSpanPositivePattern             { get; set; }
        public string                                   FullTimeSpanNegativePattern             { get; set; }
        public List<TokenHashValue>?                    DtfiTokenHash                           { get; set; }
        public DateTimeFormatInfo?                      S_jajpDTFI                              { get; set; }
        public DateTimeFormatInfo?                      S_zhtwDTFI                              { get; set; }

        public static DateTimeFormatInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeFormatInfo() { Pointer= p0 };

            value.CultureData                               = GetObject<CultureData>(new IntPtr(p + 0x010), ReversePrism.DataModels.CultureData.FromPointer); // 0x10 CultureData                 ( ModelClassType CultureData CultureData CultureData Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.LangName                                  = GetString(new IntPtr(p + 0x020)); // 0x20 LangName                    ( ModelPrimitiveType string string string String )
            value.CompareInfo                               = GetObject<CompareInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompareInfo.FromPointer); // 0x28 CompareInfo                 ( ModelClassType CompareInfo CompareInfo CompareInfo Pointer )
            value.CultureInfo                               = GetObject<CultureInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x30 CultureInfo                 ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.AmDesignator                              = GetString(new IntPtr(p + 0x038)); // 0x38 AmDesignator                ( ModelPrimitiveType string string string String )
            value.PmDesignator                              = GetString(new IntPtr(p + 0x040)); // 0x40 PmDesignator                ( ModelPrimitiveType string string string String )
            value.DateSeparator                             = GetString(new IntPtr(p + 0x048)); // 0x48 DateSeparator               ( ModelPrimitiveType string string string String )
            value.GeneralShortTimePattern                   = GetString(new IntPtr(p + 0x050)); // 0x50 GeneralShortTimePattern     ( ModelPrimitiveType string string string String )
            value.GeneralLongTimePattern                    = GetString(new IntPtr(p + 0x058)); // 0x58 GeneralLongTimePattern      ( ModelPrimitiveType string string string String )
            value.TimeSeparator                             = GetString(new IntPtr(p + 0x060)); // 0x60 TimeSeparator               ( ModelPrimitiveType string string string String )
            value.MonthDayPattern                           = GetString(new IntPtr(p + 0x068)); // 0x68 MonthDayPattern             ( ModelPrimitiveType string string string String )
            value.DateTimeOffsetPattern                     = GetString(new IntPtr(p + 0x070)); // 0x70 DateTimeOffsetPattern       ( ModelPrimitiveType string string string String )
            value.Calendar                                  = GetObject<Calendar>(new IntPtr(p + 0x078), ReversePrism.DataModels.Calendar.FromPointer); // 0x78 Calendar                    ( ModelClassType Calendar Calendar Calendar Pointer )
            value.FirstDayOfWeek                            = GetInt32(new IntPtr(p + 0x080)); // 0x80 FirstDayOfWeek              ( ModelPrimitiveType int int int Int32 )
            value.CalendarWeekRule                          = GetInt32(new IntPtr(p + 0x084)); // 0x84 CalendarWeekRule            ( ModelPrimitiveType int int int Int32 )
            value.FullDateTimePattern                       = GetString(new IntPtr(p + 0x088)); // 0x88 FullDateTimePattern         ( ModelPrimitiveType string string string String )
            value.AbbreviatedDayNames                       = GetStringList(new IntPtr(p + 0x090)); // 0x90 AbbreviatedDayNames         ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_superShortDayNames                      = GetStringList(new IntPtr(p + 0x098)); // 0x98 M_superShortDayNames        ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.DayNames                                  = GetStringList(new IntPtr(p + 0x0A0)); // 0xA0 DayNames                    ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AbbreviatedMonthNames                     = GetStringList(new IntPtr(p + 0x0A8)); // 0xA8 AbbreviatedMonthNames       ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MonthNames                                = GetStringList(new IntPtr(p + 0x0B0)); // 0xB0 MonthNames                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.GenitiveMonthNames                        = GetStringList(new IntPtr(p + 0x0B8)); // 0xB8 GenitiveMonthNames          ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_genitiveAbbreviatedMonthNames           = GetStringList(new IntPtr(p + 0x0C0)); // 0xC0 M_genitiveAbbreviatedMonthNames ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.LeapYearMonthNames                        = GetStringList(new IntPtr(p + 0x0C8)); // 0xC8 LeapYearMonthNames          ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.LongDatePattern                           = GetString(new IntPtr(p + 0x0D0)); // 0xD0 LongDatePattern             ( ModelPrimitiveType string string string String )
            value.ShortDatePattern                          = GetString(new IntPtr(p + 0x0D8)); // 0xD8 ShortDatePattern            ( ModelPrimitiveType string string string String )
            value.YearMonthPattern                          = GetString(new IntPtr(p + 0x0E0)); // 0xE0 YearMonthPattern            ( ModelPrimitiveType string string string String )
            value.LongTimePattern                           = GetString(new IntPtr(p + 0x0E8)); // 0xE8 LongTimePattern             ( ModelPrimitiveType string string string String )
            value.ShortTimePattern                          = GetString(new IntPtr(p + 0x0F0)); // 0xF0 ShortTimePattern            ( ModelPrimitiveType string string string String )
            value.AllYearMonthPatterns                      = GetStringList(new IntPtr(p + 0x0F8)); // 0xF8 AllYearMonthPatterns        ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AllShortDatePatterns                      = GetStringList(new IntPtr(p + 0x100)); // 0x100 AllShortDatePatterns        ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AllLongDatePatterns                       = GetStringList(new IntPtr(p + 0x108)); // 0x108 AllLongDatePatterns         ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AllShortTimePatterns                      = GetStringList(new IntPtr(p + 0x110)); // 0x110 AllShortTimePatterns        ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AllLongTimePatterns                       = GetStringList(new IntPtr(p + 0x118)); // 0x118 AllLongTimePatterns         ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_eraNames                                = GetStringList(new IntPtr(p + 0x120)); // 0x120 M_eraNames                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_abbrevEraNames                          = GetStringList(new IntPtr(p + 0x128)); // 0x128 M_abbrevEraNames            ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_abbrevEnglishEraNames                   = GetStringList(new IntPtr(p + 0x130)); // 0x130 M_abbrevEnglishEraNames     ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.OptionalCalendars                         = GetEnumList<CalendarId>(new IntPtr(p + 0x138)); // 0x138 OptionalCalendars           ( ModelEnumListType CalendarId[] CalendarId[] List<CalendarId> Pointer )
            value.IsReadOnly                                = GetBool(new IntPtr(p + 0x140)); // 0x140 IsReadOnly                  ( ModelPrimitiveType bool bool bool Bool )
            value.FormatFlags                               = (DateTimeFormatFlags)GetInt32(new IntPtr(p + 0x144)); // 0x144 FormatFlags                 ( ModelEnumType DateTimeFormatFlags DateTimeFormatFlags DateTimeFormatFlags Int32 )
            value.FullTimeSpanPositivePattern               = GetString(new IntPtr(p + 0x148)); // 0x148 FullTimeSpanPositivePattern ( ModelPrimitiveType string string string String )
            value.FullTimeSpanNegativePattern               = GetString(new IntPtr(p + 0x150)); // 0x150 FullTimeSpanNegativePattern ( ModelPrimitiveType string string string String )
            value.DtfiTokenHash                             = GetObjectList<TokenHashValue>(new IntPtr(p + 0x158), ReversePrism.DataModels.TokenHashValue.FromPointer); // 0x158 DtfiTokenHash               ( ModelClassListType TokenHashValue[] TokenHashValue[] List<TokenHashValue> Pointer )
            value.S_jajpDTFI                                = GetObject<DateTimeFormatInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.DateTimeFormatInfo.FromPointer); // 0x10 S_jajpDTFI                  ( ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer )
            value.S_zhtwDTFI                                = GetObject<DateTimeFormatInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.DateTimeFormatInfo.FromPointer); // 0x18 S_zhtwDTFI                  ( ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer )

            return value;
        }
    }
}
