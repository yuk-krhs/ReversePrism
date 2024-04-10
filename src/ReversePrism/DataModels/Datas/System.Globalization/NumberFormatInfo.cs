using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 invariantInfo                            NumberFormatInfo IL2CPP_TYPE_CLASS
    // 010 NumberGroupSizes                         000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 CurrencyGroupSizes                       000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 PercentGroupSizes                        000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 PositiveSign                             000186671BA0 ModelPrimitiveType string string string String
    // 030 NegativeSign                             000186671BA0 ModelPrimitiveType string string string String
    // 038 NumberDecimalSeparator                   000186671BA0 ModelPrimitiveType string string string String
    // 040 NumberGroupSeparator                     000186671BA0 ModelPrimitiveType string string string String
    // 048 CurrencyGroupSeparator                   000186671BA0 ModelPrimitiveType string string string String
    // 050 CurrencyDecimalSeparator                 000186671BA0 ModelPrimitiveType string string string String
    // 058 CurrencySymbol                           000186671BA0 ModelPrimitiveType string string string String
    // 060 AnsiCurrencySymbol                       000186671BA0 ModelPrimitiveType string string string String
    // 068 NanSymbol                                000186671BA0 ModelPrimitiveType string string string String
    // 070 PositiveInfinitySymbol                   000186671BA0 ModelPrimitiveType string string string String
    // 078 NegativeInfinitySymbol                   000186671BA0 ModelPrimitiveType string string string String
    // 080 PercentDecimalSeparator                  000186671BA0 ModelPrimitiveType string string string String
    // 088 PercentGroupSeparator                    000186671BA0 ModelPrimitiveType string string string String
    // 090 PercentSymbol                            000186671BA0 ModelPrimitiveType string string string String
    // 098 PerMilleSymbol                           000186671BA0 ModelPrimitiveType string string string String
    // 0A0 NativeDigits                             000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A8 M_dataItem                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 0AC NumberDecimalDigits                      0001865F2F90 ModelPrimitiveType int int int Int32
    // 0B0 CurrencyDecimalDigits                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 0B4 CurrencyPositivePattern                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 0B8 CurrencyNegativePattern                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 0BC NumberNegativePattern                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 0C0 PercentPositivePattern                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 0C4 PercentNegativePattern                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 0C8 PercentDecimalDigits                     0001865F2F90 ModelPrimitiveType int int int Int32
    // 0CC DigitSubstitution                        0001865F2F90 ModelPrimitiveType int int int Int32
    // 0D0 IsReadOnly                               000186595210 ModelPrimitiveType bool bool bool Bool
    // 0D1 M_useUserOverride                        000186595210 ModelPrimitiveType bool bool bool Bool
    // 0D2 M_isInvariant                            000186595210 ModelPrimitiveType bool bool bool Bool
    // 0D3 ValidForParseAsNumber                    000186595210 ModelPrimitiveType bool bool bool Bool
    // 0D4 ValidForParseAsCurrency                  000186595210 ModelPrimitiveType bool bool bool Bool
    // 000 InvalidNumberStyles                      NumberStyles IL2CPP_TYPE_VALUETYPE
    public partial class NumberFormatInfo : DataModel
    {
        public List<int>?                               NumberGroupSizes                        { get; set; }
        public List<int>?                               CurrencyGroupSizes                      { get; set; }
        public List<int>?                               PercentGroupSizes                       { get; set; }
        public string                                   PositiveSign                            { get; set; }
        public string                                   NegativeSign                            { get; set; }
        public string                                   NumberDecimalSeparator                  { get; set; }
        public string                                   NumberGroupSeparator                    { get; set; }
        public string                                   CurrencyGroupSeparator                  { get; set; }
        public string                                   CurrencyDecimalSeparator                { get; set; }
        public string                                   CurrencySymbol                          { get; set; }
        public string                                   AnsiCurrencySymbol                      { get; set; }
        public string                                   NanSymbol                               { get; set; }
        public string                                   PositiveInfinitySymbol                  { get; set; }
        public string                                   NegativeInfinitySymbol                  { get; set; }
        public string                                   PercentDecimalSeparator                 { get; set; }
        public string                                   PercentGroupSeparator                   { get; set; }
        public string                                   PercentSymbol                           { get; set; }
        public string                                   PerMilleSymbol                          { get; set; }
        public List<string>?                            NativeDigits                            { get; set; }
        public int                                      M_dataItem                              { get; set; }
        public int                                      NumberDecimalDigits                     { get; set; }
        public int                                      CurrencyDecimalDigits                   { get; set; }
        public int                                      CurrencyPositivePattern                 { get; set; }
        public int                                      CurrencyNegativePattern                 { get; set; }
        public int                                      NumberNegativePattern                   { get; set; }
        public int                                      PercentPositivePattern                  { get; set; }
        public int                                      PercentNegativePattern                  { get; set; }
        public int                                      PercentDecimalDigits                    { get; set; }
        public int                                      DigitSubstitution                       { get; set; }
        public bool                                     IsReadOnly                              { get; set; }
        public bool                                     M_useUserOverride                       { get; set; }
        public bool                                     M_isInvariant                           { get; set; }
        public bool                                     ValidForParseAsNumber                   { get; set; }
        public bool                                     ValidForParseAsCurrency                 { get; set; }

        public static NumberFormatInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NumberFormatInfo() { Pointer= p0 };

            value.NumberGroupSizes                          = GetInt32List(new IntPtr(p + 0x010)); // 0245A336B168 0x10 NumberGroupSizes            ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CurrencyGroupSizes                        = GetInt32List(new IntPtr(p + 0x018)); // 0245A336B188 0x18 CurrencyGroupSizes          ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PercentGroupSizes                         = GetInt32List(new IntPtr(p + 0x020)); // 0245A336B1A8 0x20 PercentGroupSizes           ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PositiveSign                              = GetString(new IntPtr(p + 0x028)); // 0245A336B1C8 0x28 PositiveSign                ( 000186671BA0 ModelPrimitiveType string string string String )
            value.NegativeSign                              = GetString(new IntPtr(p + 0x030)); // 0245A336B1E8 0x30 NegativeSign                ( 000186671BA0 ModelPrimitiveType string string string String )
            value.NumberDecimalSeparator                    = GetString(new IntPtr(p + 0x038)); // 0245A336B208 0x38 NumberDecimalSeparator      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.NumberGroupSeparator                      = GetString(new IntPtr(p + 0x040)); // 0245A336B228 0x40 NumberGroupSeparator        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.CurrencyGroupSeparator                    = GetString(new IntPtr(p + 0x048)); // 0245A336B248 0x48 CurrencyGroupSeparator      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.CurrencyDecimalSeparator                  = GetString(new IntPtr(p + 0x050)); // 0245A336B268 0x50 CurrencyDecimalSeparator    ( 000186671BA0 ModelPrimitiveType string string string String )
            value.CurrencySymbol                            = GetString(new IntPtr(p + 0x058)); // 0245A336B288 0x58 CurrencySymbol              ( 000186671BA0 ModelPrimitiveType string string string String )
            value.AnsiCurrencySymbol                        = GetString(new IntPtr(p + 0x060)); // 0245A336B2A8 0x60 AnsiCurrencySymbol          ( 000186671BA0 ModelPrimitiveType string string string String )
            value.NanSymbol                                 = GetString(new IntPtr(p + 0x068)); // 0245A336B2C8 0x68 NanSymbol                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PositiveInfinitySymbol                    = GetString(new IntPtr(p + 0x070)); // 0245A336B2E8 0x70 PositiveInfinitySymbol      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.NegativeInfinitySymbol                    = GetString(new IntPtr(p + 0x078)); // 0245A336B308 0x78 NegativeInfinitySymbol      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PercentDecimalSeparator                   = GetString(new IntPtr(p + 0x080)); // 0245A336B328 0x80 PercentDecimalSeparator     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PercentGroupSeparator                     = GetString(new IntPtr(p + 0x088)); // 0245A336B348 0x88 PercentGroupSeparator       ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PercentSymbol                             = GetString(new IntPtr(p + 0x090)); // 0245A336B368 0x90 PercentSymbol               ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PerMilleSymbol                            = GetString(new IntPtr(p + 0x098)); // 0245A336B388 0x98 PerMilleSymbol              ( 000186671BA0 ModelPrimitiveType string string string String )
            value.NativeDigits                              = GetStringList(new IntPtr(p + 0x0A0)); // 0245A336B3A8 0xA0 NativeDigits                ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_dataItem                                = GetInt32(new IntPtr(p + 0x0A8)); // 0245A336B3C8 0xA8 M_dataItem                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.NumberDecimalDigits                       = GetInt32(new IntPtr(p + 0x0AC)); // 0245A336B3E8 0xAC NumberDecimalDigits         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.CurrencyDecimalDigits                     = GetInt32(new IntPtr(p + 0x0B0)); // 0245A336B408 0xB0 CurrencyDecimalDigits       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.CurrencyPositivePattern                   = GetInt32(new IntPtr(p + 0x0B4)); // 0245A336B428 0xB4 CurrencyPositivePattern     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.CurrencyNegativePattern                   = GetInt32(new IntPtr(p + 0x0B8)); // 0245A336B448 0xB8 CurrencyNegativePattern     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.NumberNegativePattern                     = GetInt32(new IntPtr(p + 0x0BC)); // 0245A336B468 0xBC NumberNegativePattern       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.PercentPositivePattern                    = GetInt32(new IntPtr(p + 0x0C0)); // 0245A336B488 0xC0 PercentPositivePattern      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.PercentNegativePattern                    = GetInt32(new IntPtr(p + 0x0C4)); // 0245A336B4A8 0xC4 PercentNegativePattern      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.PercentDecimalDigits                      = GetInt32(new IntPtr(p + 0x0C8)); // 0245A336B4C8 0xC8 PercentDecimalDigits        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.DigitSubstitution                         = GetInt32(new IntPtr(p + 0x0CC)); // 0245A336B4E8 0xCC DigitSubstitution           ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.IsReadOnly                                = GetBool(new IntPtr(p + 0x0D0)); // 0245A336B508 0xD0 IsReadOnly                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_useUserOverride                         = GetBool(new IntPtr(p + 0x0D1)); // 0245A336B528 0xD1 M_useUserOverride           ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_isInvariant                             = GetBool(new IntPtr(p + 0x0D2)); // 0245A336B548 0xD2 M_isInvariant               ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ValidForParseAsNumber                     = GetBool(new IntPtr(p + 0x0D3)); // 0245A336B568 0xD3 ValidForParseAsNumber       ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ValidForParseAsCurrency                   = GetBool(new IntPtr(p + 0x0D4)); // 0245A336B588 0xD4 ValidForParseAsCurrency     ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
