using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Year                                     ModelPrimitiveType int int int Int32
    // 014 Month                                    ModelPrimitiveType int int int Int32
    // 018 Day                                      ModelPrimitiveType int int int Int32
    // 01C Hour                                     ModelPrimitiveType int int int Int32
    // 020 Minute                                   ModelPrimitiveType int int int Int32
    // 024 Second                                   ModelPrimitiveType int int int Int32
    // 028 Fraction                                 ModelPrimitiveType double double double Double
    // 030 Era                                      ModelPrimitiveType int int int Int32
    // 034 Flags                                    ModelEnumType ParseFlags ParseFlags ParseFlags Int32
    // 038 TimeZoneOffset                           ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 040 Calendar                                 ModelClassType Calendar Calendar Calendar Pointer
    // 048 ParsedDate                               ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 050 Failure                                  ModelEnumType ParseFailureKind ParseFailureKind ParseFailureKind Int32
    // 058 FailureMessageID                         ModelPrimitiveType string string string String
    // 060 failureMessageFormatArgument             <object> IL2CPP_TYPE_OBJECT
    // 068 FailureArgumentName                      ModelPrimitiveType string string string String
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

            value.Year                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Year                        ( ModelPrimitiveType int int int Int32 )
            value.Month                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Month                       ( ModelPrimitiveType int int int Int32 )
            value.Day                                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 Day                         ( ModelPrimitiveType int int int Int32 )
            value.Hour                                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Hour                        ( ModelPrimitiveType int int int Int32 )
            value.Minute                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 Minute                      ( ModelPrimitiveType int int int Int32 )
            value.Second                                    = GetInt32(new IntPtr(p + 0x024)); // 0x24 Second                      ( ModelPrimitiveType int int int Int32 )
            value.Fraction                                  = GetDouble(new IntPtr(p + 0x028)); // 0x28 Fraction                    ( ModelPrimitiveType double double double Double )
            value.Era                                       = GetInt32(new IntPtr(p + 0x030)); // 0x30 Era                         ( ModelPrimitiveType int int int Int32 )
            value.Flags                                     = (ParseFlags)GetInt32(new IntPtr(p + 0x034)); // 0x34 Flags                       ( ModelEnumType ParseFlags ParseFlags ParseFlags Int32 )
            value.TimeZoneOffset                            = (TimeSpan)GetInt32(new IntPtr(p + 0x038)); // 0x38 TimeZoneOffset              ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Calendar                                  = GetObject<Calendar>(new IntPtr(p + 0x040), ReversePrism.DataModels.Calendar.FromPointer); // 0x40 Calendar                    ( ModelClassType Calendar Calendar Calendar Pointer )
            value.ParsedDate                                = GetDateTime(new IntPtr(p + 0x048)); // 0x48 ParsedDate                  ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Failure                                   = (ParseFailureKind)GetInt32(new IntPtr(p + 0x050)); // 0x50 Failure                     ( ModelEnumType ParseFailureKind ParseFailureKind ParseFailureKind Int32 )
            value.FailureMessageID                          = GetString(new IntPtr(p + 0x058)); // 0x58 FailureMessageID            ( ModelPrimitiveType string string string String )
            value.FailureArgumentName                       = GetString(new IntPtr(p + 0x068)); // 0x68 FailureArgumentName         ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
