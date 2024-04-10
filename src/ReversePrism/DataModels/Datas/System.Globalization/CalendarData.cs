using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MAX_CALENDARS                            int IL2CPP_TYPE_I4
    // 010 SNativeName                              000186671BA0 ModelPrimitiveType string string string String
    // 018 SaShortDates                             000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 SaYearMonths                             000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 SaLongDates                              000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 SMonthDay                                000186671BA0 ModelPrimitiveType string string string String
    // 038 SaEraNames                               000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 SaAbbrevEraNames                         000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 SaAbbrevEnglishEraNames                  000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 050 SaDayNames                               000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 058 SaAbbrevDayNames                         000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 060 SaSuperShortDayNames                     000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 068 SaMonthNames                             000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 070 SaAbbrevMonthNames                       000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 078 SaMonthGenitiveNames                     000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 080 SaAbbrevMonthGenitiveNames               000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 088 SaLeapYearMonthNames                     000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 090 ITwoDigitYearMax                         0001865F2F90 ModelPrimitiveType int int int Int32
    // 094 ICurrentEra                              0001865F2F90 ModelPrimitiveType int int int Int32
    // 098 BUseUserOverrides                        000186595210 ModelPrimitiveType bool bool bool Bool
    // 000 Invariant                                CalendarData IL2CPP_TYPE_CLASS
    // 008 HEBREW_MONTH_NAMES                       string[] IL2CPP_TYPE_SZARRAY
    // 010 HEBREW_LEAP_MONTH_NAMES                  000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer
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

            value.SNativeName                               = GetString(new IntPtr(p + 0x010)); // 0245A3365930 0x10 SNativeName                 ( 000186671BA0 ModelPrimitiveType string string string String )
            value.SaShortDates                              = GetStringList(new IntPtr(p + 0x018)); // 0245A3365950 0x18 SaShortDates                ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaYearMonths                              = GetStringList(new IntPtr(p + 0x020)); // 0245A3365970 0x20 SaYearMonths                ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaLongDates                               = GetStringList(new IntPtr(p + 0x028)); // 0245A3365990 0x28 SaLongDates                 ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SMonthDay                                 = GetString(new IntPtr(p + 0x030)); // 0245A33659B0 0x30 SMonthDay                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.SaEraNames                                = GetStringList(new IntPtr(p + 0x038)); // 0245A33659D0 0x38 SaEraNames                  ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaAbbrevEraNames                          = GetStringList(new IntPtr(p + 0x040)); // 0245A33659F0 0x40 SaAbbrevEraNames            ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaAbbrevEnglishEraNames                   = GetStringList(new IntPtr(p + 0x048)); // 0245A3365A10 0x48 SaAbbrevEnglishEraNames     ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaDayNames                                = GetStringList(new IntPtr(p + 0x050)); // 0245A3365A30 0x50 SaDayNames                  ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaAbbrevDayNames                          = GetStringList(new IntPtr(p + 0x058)); // 0245A3365A50 0x58 SaAbbrevDayNames            ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaSuperShortDayNames                      = GetStringList(new IntPtr(p + 0x060)); // 0245A3365A70 0x60 SaSuperShortDayNames        ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaMonthNames                              = GetStringList(new IntPtr(p + 0x068)); // 0245A3365A90 0x68 SaMonthNames                ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaAbbrevMonthNames                        = GetStringList(new IntPtr(p + 0x070)); // 0245A3365AB0 0x70 SaAbbrevMonthNames          ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaMonthGenitiveNames                      = GetStringList(new IntPtr(p + 0x078)); // 0245A3365AD0 0x78 SaMonthGenitiveNames        ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaAbbrevMonthGenitiveNames                = GetStringList(new IntPtr(p + 0x080)); // 0245A3365AF0 0x80 SaAbbrevMonthGenitiveNames  ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaLeapYearMonthNames                      = GetStringList(new IntPtr(p + 0x088)); // 0245A3365B10 0x88 SaLeapYearMonthNames        ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ITwoDigitYearMax                          = GetInt32(new IntPtr(p + 0x090)); // 0245A3365B30 0x90 ITwoDigitYearMax            ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.ICurrentEra                               = GetInt32(new IntPtr(p + 0x094)); // 0245A3365B50 0x94 ICurrentEra                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.BUseUserOverrides                         = GetBool(new IntPtr(p + 0x098)); // 0245A3365B70 0x98 BUseUserOverrides           ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.HEBREW_LEAP_MONTH_NAMES                   = GetStringList(new IntPtr(p + 0x010)); // 0245A3365BD0 0x10 HEBREW_LEAP_MONTH_NAMES     ( 000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
