using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Year                                     0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 Month                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Day                                      0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C Hour                                     0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 Minute                                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 024 Second                                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 Fraction                                 0001865C2BA0 ModelPrimitiveType double double double Double
    // 030 Era                                      0001865F2F90 ModelPrimitiveType int int int Int32
    // 034 Flags                                    00018671FE60 ModelEnumType ParseFlags ParseFlags ParseFlags Int32
    // 038 TimeZoneOffset                           00018668AB90 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 040 Calendar                                 0001865A1130 ModelClassType Calendar Calendar Calendar Pointer
    // 048 ParsedDate                               0001865B9320 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 050 Failure                                  00018671F760 ModelEnumType ParseFailureKind ParseFailureKind ParseFailureKind Int32
    // 058 FailureMessageID                         000186671BA0 ModelPrimitiveType string string string String
    // 060 failureMessageFormatArgument             <object> IL2CPP_TYPE_OBJECT
    // 068 FailureArgumentName                      000186671BA0 ModelPrimitiveType string string string String
    // 070 originalDateTimeString                   ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 080 failedFormatSpecifier                    ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    public partial class DateTimeResult : DataModel
    {
        public int                                      Year                                    { get; set; }
        public int                                      Month                                   { get; set; }
        public int                                      Day                                     { get; set; }
        public int                                      Hour                                    { get; set; }
        public int                                      Minute                                  { get; set; }
        public int                                      Second                                  { get; set; }
        public double                                   Fraction                                { get; set; }
        public int                                      Era                                     { get; set; }
        public ParseFlags                               Flags                                   { get; set; }
        public TimeSpan                                 TimeZoneOffset                          { get; set; }
        public Calendar?                                Calendar                                { get; set; }
        public DateTime                                 ParsedDate                              { get; set; }
        public ParseFailureKind                         Failure                                 { get; set; }
        public string                                   FailureMessageID                        { get; set; }
        public string                                   FailureArgumentName                     { get; set; }

        public static DateTimeResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeResult() { Pointer= p0 };

            value.Year                                      = GetInt32(new IntPtr(p + 0x010)); // 024666A0C820 0x10 Year                        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Month                                     = GetInt32(new IntPtr(p + 0x014)); // 024666A0C840 0x14 Month                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Day                                       = GetInt32(new IntPtr(p + 0x018)); // 024666A0C860 0x18 Day                         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Hour                                      = GetInt32(new IntPtr(p + 0x01C)); // 024666A0C880 0x1C Hour                        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Minute                                    = GetInt32(new IntPtr(p + 0x020)); // 024666A0C8A0 0x20 Minute                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Second                                    = GetInt32(new IntPtr(p + 0x024)); // 024666A0C8C0 0x24 Second                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Fraction                                  = GetDouble(new IntPtr(p + 0x028)); // 024666A0C8E0 0x28 Fraction                    ( 0001865C2BA0 ModelPrimitiveType double double double Double )
            value.Era                                       = GetInt32(new IntPtr(p + 0x030)); // 024666A0C900 0x30 Era                         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Flags                                     = (ParseFlags)GetInt32(new IntPtr(p + 0x034)); // 024666A0C920 0x34 Flags                       ( 00018671FE60 ModelEnumType ParseFlags ParseFlags ParseFlags Int32 )
            value.TimeZoneOffset                            = (TimeSpan)GetInt32(new IntPtr(p + 0x038)); // 024666A0C940 0x38 TimeZoneOffset              ( 00018668AB90 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Calendar                                  = GetObject<Calendar>(new IntPtr(p + 0x040), ReversePrism.DataModels.Calendar.FromPointer); // 024666A0C960 0x40 Calendar                    ( 0001865A1130 ModelClassType Calendar Calendar Calendar Pointer )
            value.ParsedDate                                = GetDateTime(new IntPtr(p + 0x048)); // 024666A0C980 0x48 ParsedDate                  ( 0001865B9320 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Failure                                   = (ParseFailureKind)GetInt32(new IntPtr(p + 0x050)); // 024666A0C9A0 0x50 Failure                     ( 00018671F760 ModelEnumType ParseFailureKind ParseFailureKind ParseFailureKind Int32 )
            value.FailureMessageID                          = GetString(new IntPtr(p + 0x058)); // 024666A0C9C0 0x58 FailureMessageID            ( 000186671BA0 ModelPrimitiveType string string string String )
            value.FailureArgumentName                       = GetString(new IntPtr(p + 0x068)); // 024666A0CA00 0x68 FailureArgumentName         ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
