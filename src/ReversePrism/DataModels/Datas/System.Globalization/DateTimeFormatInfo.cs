using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_invariantInfo                          DateTimeFormatInfo IL2CPP_TYPE_CLASS
    // 010 CultureData                              000186666620 ModelClassType CultureData CultureData CultureData Pointer
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 020 LangName                                 0001866742E0 ModelPrimitiveType string string string String
    // 028 CompareInfo                              0001865EBAF0 ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    // 030 CultureInfo                              0001865B5970 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 038 AmDesignator                             000186671910 ModelPrimitiveType string string string String
    // 040 PmDesignator                             000186671910 ModelPrimitiveType string string string String
    // 048 DateSeparator                            000186671910 ModelPrimitiveType string string string String
    // 050 GeneralShortTimePattern                  000186671910 ModelPrimitiveType string string string String
    // 058 GeneralLongTimePattern                   000186671910 ModelPrimitiveType string string string String
    // 060 TimeSeparator                            000186671910 ModelPrimitiveType string string string String
    // 068 MonthDayPattern                          000186671910 ModelPrimitiveType string string string String
    // 070 DateTimeOffsetPattern                    000186671910 ModelPrimitiveType string string string String
    // 000 rfc1123Pattern                           string IL2CPP_TYPE_STRING
    // 000 sortableDateTimePattern                  string IL2CPP_TYPE_STRING
    // 000 universalSortableDateTimePattern         string IL2CPP_TYPE_STRING
    // 078 Calendar                                 0001865A0F00 ModelClassType Calendar Calendar Calendar Pointer
    // 080 FirstDayOfWeek                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 084 CalendarWeekRule                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 FullDateTimePattern                      000186671910 ModelPrimitiveType string string string String
    // 090 AbbreviatedDayNames                      000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 098 M_superShortDayNames                     000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A0 DayNames                                 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A8 AbbreviatedMonthNames                    000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0B0 MonthNames                               000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0B8 GenitiveMonthNames                       000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0C0 M_genitiveAbbreviatedMonthNames          000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0C8 LeapYearMonthNames                       000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0D0 LongDatePattern                          000186671910 ModelPrimitiveType string string string String
    // 0D8 ShortDatePattern                         000186671910 ModelPrimitiveType string string string String
    // 0E0 YearMonthPattern                         000186671910 ModelPrimitiveType string string string String
    // 0E8 LongTimePattern                          000186671910 ModelPrimitiveType string string string String
    // 0F0 ShortTimePattern                         000186671910 ModelPrimitiveType string string string String
    // 0F8 AllYearMonthPatterns                     000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 100 AllShortDatePatterns                     000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 108 AllLongDatePatterns                      000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 110 AllShortTimePatterns                     000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 118 AllLongTimePatterns                      000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 120 M_eraNames                               000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 128 M_abbrevEraNames                         000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 130 M_abbrevEnglishEraNames                  000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 138 OptionalCalendars                        000185B728C0 ModelEnumListType CalendarId[] CalendarId[] List<CalendarId> Pointer
    // 000 DEFAULT_ALL_DATETIMES_SIZE               int IL2CPP_TYPE_I4
    // 140 IsReadOnly                               000186595210 ModelPrimitiveType bool bool bool Bool
    // 144 FormatFlags                              000186695650 ModelEnumType DateTimeFormatFlags DateTimeFormatFlags DateTimeFormatFlags Int32
    // 008 s_monthSpaces                            char[] IL2CPP_TYPE_SZARRAY
    // 000 RoundtripFormat                          string IL2CPP_TYPE_STRING
    // 000 RoundtripDateTimeUnfixed                 string IL2CPP_TYPE_STRING
    // 148 FullTimeSpanPositivePattern              000186671910 ModelPrimitiveType string string string String
    // 150 FullTimeSpanNegativePattern              000186671910 ModelPrimitiveType string string string String
    // 000 InvalidDateTimeStyles                    DateTimeStyles IL2CPP_TYPE_VALUETYPE
    // 158 DtfiTokenHash                            000185CB8EE8 ModelClassListType TokenHashValue[] TokenHashValue[] List<TokenHashValue> Pointer
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
    // 010 S_jajpDTFI                               0001865BB580 ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer
    // 018 S_zhtwDTFI                               0001865BB580 ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer
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

            value.CultureData                               = GetObject<CultureData>(new IntPtr(p + 0x010), ReversePrism.DataModels.CultureData.FromPointer); // 0245A3CB2578 0x10 CultureData                 ( 000186666620 ModelClassType CultureData CultureData CultureData Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0245A3CB2598 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.LangName                                  = GetString(new IntPtr(p + 0x020)); // 0245A3CB25B8 0x20 LangName                    ( 0001866742E0 ModelPrimitiveType string string string String )
            value.CompareInfo                               = GetObject<CompareInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompareInfo.FromPointer); // 0245A3CB25D8 0x28 CompareInfo                 ( 0001865EBAF0 ModelClassType CompareInfo CompareInfo CompareInfo Pointer )
            value.CultureInfo                               = GetObject<CultureInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.CultureInfo.FromPointer); // 0245A3CB25F8 0x30 CultureInfo                 ( 0001865B5970 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.AmDesignator                              = GetString(new IntPtr(p + 0x038)); // 0245A3CB2618 0x38 AmDesignator                ( 000186671910 ModelPrimitiveType string string string String )
            value.PmDesignator                              = GetString(new IntPtr(p + 0x040)); // 0245A3CB2638 0x40 PmDesignator                ( 000186671910 ModelPrimitiveType string string string String )
            value.DateSeparator                             = GetString(new IntPtr(p + 0x048)); // 0245A3CB2658 0x48 DateSeparator               ( 000186671910 ModelPrimitiveType string string string String )
            value.GeneralShortTimePattern                   = GetString(new IntPtr(p + 0x050)); // 0245A3CB2678 0x50 GeneralShortTimePattern     ( 000186671910 ModelPrimitiveType string string string String )
            value.GeneralLongTimePattern                    = GetString(new IntPtr(p + 0x058)); // 0245A3CB2698 0x58 GeneralLongTimePattern      ( 000186671910 ModelPrimitiveType string string string String )
            value.TimeSeparator                             = GetString(new IntPtr(p + 0x060)); // 0245A3CB26B8 0x60 TimeSeparator               ( 000186671910 ModelPrimitiveType string string string String )
            value.MonthDayPattern                           = GetString(new IntPtr(p + 0x068)); // 0245A3CB26D8 0x68 MonthDayPattern             ( 000186671910 ModelPrimitiveType string string string String )
            value.DateTimeOffsetPattern                     = GetString(new IntPtr(p + 0x070)); // 0245A3CB26F8 0x70 DateTimeOffsetPattern       ( 000186671910 ModelPrimitiveType string string string String )
            value.Calendar                                  = GetObject<Calendar>(new IntPtr(p + 0x078), ReversePrism.DataModels.Calendar.FromPointer); // 0245A3CB2778 0x78 Calendar                    ( 0001865A0F00 ModelClassType Calendar Calendar Calendar Pointer )
            value.FirstDayOfWeek                            = GetInt32(new IntPtr(p + 0x080)); // 0245A3CB2798 0x80 FirstDayOfWeek              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CalendarWeekRule                          = GetInt32(new IntPtr(p + 0x084)); // 0245A3CB27B8 0x84 CalendarWeekRule            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FullDateTimePattern                       = GetString(new IntPtr(p + 0x088)); // 0245A3CB27D8 0x88 FullDateTimePattern         ( 000186671910 ModelPrimitiveType string string string String )
            value.AbbreviatedDayNames                       = GetStringList(new IntPtr(p + 0x090)); // 0245A3CB27F8 0x90 AbbreviatedDayNames         ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_superShortDayNames                      = GetStringList(new IntPtr(p + 0x098)); // 0245A3CB2818 0x98 M_superShortDayNames        ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.DayNames                                  = GetStringList(new IntPtr(p + 0x0A0)); // 0245A3CB2838 0xA0 DayNames                    ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AbbreviatedMonthNames                     = GetStringList(new IntPtr(p + 0x0A8)); // 0245A3CB2858 0xA8 AbbreviatedMonthNames       ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MonthNames                                = GetStringList(new IntPtr(p + 0x0B0)); // 0245A3CB2878 0xB0 MonthNames                  ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.GenitiveMonthNames                        = GetStringList(new IntPtr(p + 0x0B8)); // 0245A3CB2898 0xB8 GenitiveMonthNames          ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_genitiveAbbreviatedMonthNames           = GetStringList(new IntPtr(p + 0x0C0)); // 0245A3CB28B8 0xC0 M_genitiveAbbreviatedMonthNames ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.LeapYearMonthNames                        = GetStringList(new IntPtr(p + 0x0C8)); // 0245A3CB28D8 0xC8 LeapYearMonthNames          ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.LongDatePattern                           = GetString(new IntPtr(p + 0x0D0)); // 0245A3CB28F8 0xD0 LongDatePattern             ( 000186671910 ModelPrimitiveType string string string String )
            value.ShortDatePattern                          = GetString(new IntPtr(p + 0x0D8)); // 0245A3CB2918 0xD8 ShortDatePattern            ( 000186671910 ModelPrimitiveType string string string String )
            value.YearMonthPattern                          = GetString(new IntPtr(p + 0x0E0)); // 0245A3CB2938 0xE0 YearMonthPattern            ( 000186671910 ModelPrimitiveType string string string String )
            value.LongTimePattern                           = GetString(new IntPtr(p + 0x0E8)); // 0245A3CB2958 0xE8 LongTimePattern             ( 000186671910 ModelPrimitiveType string string string String )
            value.ShortTimePattern                          = GetString(new IntPtr(p + 0x0F0)); // 0245A3CB2978 0xF0 ShortTimePattern            ( 000186671910 ModelPrimitiveType string string string String )
            value.AllYearMonthPatterns                      = GetStringList(new IntPtr(p + 0x0F8)); // 0245A3CB2998 0xF8 AllYearMonthPatterns        ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AllShortDatePatterns                      = GetStringList(new IntPtr(p + 0x100)); // 0245A3CB29B8 0x100 AllShortDatePatterns        ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AllLongDatePatterns                       = GetStringList(new IntPtr(p + 0x108)); // 0245A3CB29D8 0x108 AllLongDatePatterns         ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AllShortTimePatterns                      = GetStringList(new IntPtr(p + 0x110)); // 0245A3CB29F8 0x110 AllShortTimePatterns        ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AllLongTimePatterns                       = GetStringList(new IntPtr(p + 0x118)); // 0245A3CB2A18 0x118 AllLongTimePatterns         ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_eraNames                                = GetStringList(new IntPtr(p + 0x120)); // 0245A3CB2A38 0x120 M_eraNames                  ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_abbrevEraNames                          = GetStringList(new IntPtr(p + 0x128)); // 0245A3CB2A58 0x128 M_abbrevEraNames            ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_abbrevEnglishEraNames                   = GetStringList(new IntPtr(p + 0x130)); // 0245A3CB2A78 0x130 M_abbrevEnglishEraNames     ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.OptionalCalendars                         = GetEnumList<CalendarId>(new IntPtr(p + 0x138)); // 0245A3CB2A98 0x138 OptionalCalendars           ( 000185B728C0 ModelEnumListType CalendarId[] CalendarId[] List<CalendarId> Pointer )
            value.IsReadOnly                                = GetBool(new IntPtr(p + 0x140)); // 0245A3CB2AD8 0x140 IsReadOnly                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.FormatFlags                               = (DateTimeFormatFlags)GetInt32(new IntPtr(p + 0x144)); // 0245A3CB2AF8 0x144 FormatFlags                 ( 000186695650 ModelEnumType DateTimeFormatFlags DateTimeFormatFlags DateTimeFormatFlags Int32 )
            value.FullTimeSpanPositivePattern               = GetString(new IntPtr(p + 0x148)); // 0245A3CB2B78 0x148 FullTimeSpanPositivePattern ( 000186671910 ModelPrimitiveType string string string String )
            value.FullTimeSpanNegativePattern               = GetString(new IntPtr(p + 0x150)); // 0245A3CB2B98 0x150 FullTimeSpanNegativePattern ( 000186671910 ModelPrimitiveType string string string String )
            value.DtfiTokenHash                             = GetObjectList<TokenHashValue>(new IntPtr(p + 0x158), ReversePrism.DataModels.TokenHashValue.FromPointer); // 0245A3CB2BD8 0x158 DtfiTokenHash               ( 000185CB8EE8 ModelClassListType TokenHashValue[] TokenHashValue[] List<TokenHashValue> Pointer )
            value.S_jajpDTFI                                = GetObject<DateTimeFormatInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.DateTimeFormatInfo.FromPointer); // 0245A3CB2F58 0x10 S_jajpDTFI                  ( 0001865BB580 ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer )
            value.S_zhtwDTFI                                = GetObject<DateTimeFormatInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.DateTimeFormatInfo.FromPointer); // 0245A3CB2F78 0x18 S_zhtwDTFI                  ( 0001865BB580 ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer )

            return value;
        }
    }
}
