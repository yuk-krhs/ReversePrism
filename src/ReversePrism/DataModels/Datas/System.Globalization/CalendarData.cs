using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MAX_CALENDARS                            int IL2CPP_TYPE_I4
    // 010 SNativeName                              ModelPrimitiveType string string string String
    // 018 SaShortDates                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 SaYearMonths                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 SaLongDates                              ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 SMonthDay                                ModelPrimitiveType string string string String
    // 038 SaEraNames                               ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 SaAbbrevEraNames                         ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 SaAbbrevEnglishEraNames                  ModelPrimitiveListType string[] string[] List<string> Pointer
    // 050 SaDayNames                               ModelPrimitiveListType string[] string[] List<string> Pointer
    // 058 SaAbbrevDayNames                         ModelPrimitiveListType string[] string[] List<string> Pointer
    // 060 SaSuperShortDayNames                     ModelPrimitiveListType string[] string[] List<string> Pointer
    // 068 SaMonthNames                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 070 SaAbbrevMonthNames                       ModelPrimitiveListType string[] string[] List<string> Pointer
    // 078 SaMonthGenitiveNames                     ModelPrimitiveListType string[] string[] List<string> Pointer
    // 080 SaAbbrevMonthGenitiveNames               ModelPrimitiveListType string[] string[] List<string> Pointer
    // 088 SaLeapYearMonthNames                     ModelPrimitiveListType string[] string[] List<string> Pointer
    // 090 ITwoDigitYearMax                         ModelPrimitiveType int int int Int32
    // 094 ICurrentEra                              ModelPrimitiveType int int int Int32
    // 098 BUseUserOverrides                        ModelPrimitiveType bool bool bool Bool
    // 000 Invariant                                CalendarData IL2CPP_TYPE_CLASS
    // 008 HEBREW_MONTH_NAMES                       string[] IL2CPP_TYPE_SZARRAY
    // 010 HEBREW_LEAP_MONTH_NAMES                  ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class CalendarData : DataModel
    {
        public string                                   SNativeName                             { get; set; }
        public List<string>?                            SaShortDates                            { get; set; }
        public List<string>?                            SaYearMonths                            { get; set; }
        public List<string>?                            SaLongDates                             { get; set; }
        public string                                   SMonthDay                               { get; set; }
        public List<string>?                            SaEraNames                              { get; set; }
        public List<string>?                            SaAbbrevEraNames                        { get; set; }
        public List<string>?                            SaAbbrevEnglishEraNames                 { get; set; }
        public List<string>?                            SaDayNames                              { get; set; }
        public List<string>?                            SaAbbrevDayNames                        { get; set; }
        public List<string>?                            SaSuperShortDayNames                    { get; set; }
        public List<string>?                            SaMonthNames                            { get; set; }
        public List<string>?                            SaAbbrevMonthNames                      { get; set; }
        public List<string>?                            SaMonthGenitiveNames                    { get; set; }
        public List<string>?                            SaAbbrevMonthGenitiveNames              { get; set; }
        public List<string>?                            SaLeapYearMonthNames                    { get; set; }
        public int                                      ITwoDigitYearMax                        { get; set; }
        public int                                      ICurrentEra                             { get; set; }
        public bool                                     BUseUserOverrides                       { get; set; }
        public List<string>?                            HEBREW_LEAP_MONTH_NAMES                 { get; set; }

        public static CalendarData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CalendarData() { Pointer= p0 };

            value.SNativeName                               = GetString(new IntPtr(p + 0x010)); // 0x10 SNativeName                 ( ModelPrimitiveType string string string String )
            value.SaShortDates                              = GetStringList(new IntPtr(p + 0x018)); // 0x18 SaShortDates                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaYearMonths                              = GetStringList(new IntPtr(p + 0x020)); // 0x20 SaYearMonths                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaLongDates                               = GetStringList(new IntPtr(p + 0x028)); // 0x28 SaLongDates                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SMonthDay                                 = GetString(new IntPtr(p + 0x030)); // 0x30 SMonthDay                   ( ModelPrimitiveType string string string String )
            value.SaEraNames                                = GetStringList(new IntPtr(p + 0x038)); // 0x38 SaEraNames                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaAbbrevEraNames                          = GetStringList(new IntPtr(p + 0x040)); // 0x40 SaAbbrevEraNames            ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaAbbrevEnglishEraNames                   = GetStringList(new IntPtr(p + 0x048)); // 0x48 SaAbbrevEnglishEraNames     ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaDayNames                                = GetStringList(new IntPtr(p + 0x050)); // 0x50 SaDayNames                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaAbbrevDayNames                          = GetStringList(new IntPtr(p + 0x058)); // 0x58 SaAbbrevDayNames            ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaSuperShortDayNames                      = GetStringList(new IntPtr(p + 0x060)); // 0x60 SaSuperShortDayNames        ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaMonthNames                              = GetStringList(new IntPtr(p + 0x068)); // 0x68 SaMonthNames                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaAbbrevMonthNames                        = GetStringList(new IntPtr(p + 0x070)); // 0x70 SaAbbrevMonthNames          ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaMonthGenitiveNames                      = GetStringList(new IntPtr(p + 0x078)); // 0x78 SaMonthGenitiveNames        ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaAbbrevMonthGenitiveNames                = GetStringList(new IntPtr(p + 0x080)); // 0x80 SaAbbrevMonthGenitiveNames  ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaLeapYearMonthNames                      = GetStringList(new IntPtr(p + 0x088)); // 0x88 SaLeapYearMonthNames        ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ITwoDigitYearMax                          = GetInt32(new IntPtr(p + 0x090)); // 0x90 ITwoDigitYearMax            ( ModelPrimitiveType int int int Int32 )
            value.ICurrentEra                               = GetInt32(new IntPtr(p + 0x094)); // 0x94 ICurrentEra                 ( ModelPrimitiveType int int int Int32 )
            value.BUseUserOverrides                         = GetBool(new IntPtr(p + 0x098)); // 0x98 BUseUserOverrides           ( ModelPrimitiveType bool bool bool Bool )
            value.HEBREW_LEAP_MONTH_NAMES                   = GetStringList(new IntPtr(p + 0x010)); // 0x10 HEBREW_LEAP_MONTH_NAMES     ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
