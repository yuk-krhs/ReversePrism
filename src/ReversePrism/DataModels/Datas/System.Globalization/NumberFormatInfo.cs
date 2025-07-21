using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 invariantInfo                            NumberFormatInfo IL2CPP_TYPE_CLASS
    // 010 NumberGroupSizes                         ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 CurrencyGroupSizes                       ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 PercentGroupSizes                        ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 PositiveSign                             ModelPrimitiveType string string string String
    // 030 NegativeSign                             ModelPrimitiveType string string string String
    // 038 NumberDecimalSeparator                   ModelPrimitiveType string string string String
    // 040 NumberGroupSeparator                     ModelPrimitiveType string string string String
    // 048 CurrencyGroupSeparator                   ModelPrimitiveType string string string String
    // 050 CurrencyDecimalSeparator                 ModelPrimitiveType string string string String
    // 058 CurrencySymbol                           ModelPrimitiveType string string string String
    // 060 AnsiCurrencySymbol                       ModelPrimitiveType string string string String
    // 068 NanSymbol                                ModelPrimitiveType string string string String
    // 070 PositiveInfinitySymbol                   ModelPrimitiveType string string string String
    // 078 NegativeInfinitySymbol                   ModelPrimitiveType string string string String
    // 080 PercentDecimalSeparator                  ModelPrimitiveType string string string String
    // 088 PercentGroupSeparator                    ModelPrimitiveType string string string String
    // 090 PercentSymbol                            ModelPrimitiveType string string string String
    // 098 PerMilleSymbol                           ModelPrimitiveType string string string String
    // 0A0 NativeDigits                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A8 M_dataItem                               ModelPrimitiveType int int int Int32
    // 0AC NumberDecimalDigits                      ModelPrimitiveType int int int Int32
    // 0B0 CurrencyDecimalDigits                    ModelPrimitiveType int int int Int32
    // 0B4 CurrencyPositivePattern                  ModelPrimitiveType int int int Int32
    // 0B8 CurrencyNegativePattern                  ModelPrimitiveType int int int Int32
    // 0BC NumberNegativePattern                    ModelPrimitiveType int int int Int32
    // 0C0 PercentPositivePattern                   ModelPrimitiveType int int int Int32
    // 0C4 PercentNegativePattern                   ModelPrimitiveType int int int Int32
    // 0C8 PercentDecimalDigits                     ModelPrimitiveType int int int Int32
    // 0CC DigitSubstitution                        ModelPrimitiveType int int int Int32
    // 0D0 IsReadOnly                               ModelPrimitiveType bool bool bool Bool
    // 0D1 M_useUserOverride                        ModelPrimitiveType bool bool bool Bool
    // 0D2 M_isInvariant                            ModelPrimitiveType bool bool bool Bool
    // 0D3 ValidForParseAsNumber                    ModelPrimitiveType bool bool bool Bool
    // 0D4 ValidForParseAsCurrency                  ModelPrimitiveType bool bool bool Bool
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

            value.NumberGroupSizes                          = GetInt32List(new IntPtr(p + 0x010)); // 0x10 NumberGroupSizes            ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CurrencyGroupSizes                        = GetInt32List(new IntPtr(p + 0x018)); // 0x18 CurrencyGroupSizes          ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PercentGroupSizes                         = GetInt32List(new IntPtr(p + 0x020)); // 0x20 PercentGroupSizes           ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PositiveSign                              = GetString(new IntPtr(p + 0x028)); // 0x28 PositiveSign                ( ModelPrimitiveType string string string String )
            value.NegativeSign                              = GetString(new IntPtr(p + 0x030)); // 0x30 NegativeSign                ( ModelPrimitiveType string string string String )
            value.NumberDecimalSeparator                    = GetString(new IntPtr(p + 0x038)); // 0x38 NumberDecimalSeparator      ( ModelPrimitiveType string string string String )
            value.NumberGroupSeparator                      = GetString(new IntPtr(p + 0x040)); // 0x40 NumberGroupSeparator        ( ModelPrimitiveType string string string String )
            value.CurrencyGroupSeparator                    = GetString(new IntPtr(p + 0x048)); // 0x48 CurrencyGroupSeparator      ( ModelPrimitiveType string string string String )
            value.CurrencyDecimalSeparator                  = GetString(new IntPtr(p + 0x050)); // 0x50 CurrencyDecimalSeparator    ( ModelPrimitiveType string string string String )
            value.CurrencySymbol                            = GetString(new IntPtr(p + 0x058)); // 0x58 CurrencySymbol              ( ModelPrimitiveType string string string String )
            value.AnsiCurrencySymbol                        = GetString(new IntPtr(p + 0x060)); // 0x60 AnsiCurrencySymbol          ( ModelPrimitiveType string string string String )
            value.NanSymbol                                 = GetString(new IntPtr(p + 0x068)); // 0x68 NanSymbol                   ( ModelPrimitiveType string string string String )
            value.PositiveInfinitySymbol                    = GetString(new IntPtr(p + 0x070)); // 0x70 PositiveInfinitySymbol      ( ModelPrimitiveType string string string String )
            value.NegativeInfinitySymbol                    = GetString(new IntPtr(p + 0x078)); // 0x78 NegativeInfinitySymbol      ( ModelPrimitiveType string string string String )
            value.PercentDecimalSeparator                   = GetString(new IntPtr(p + 0x080)); // 0x80 PercentDecimalSeparator     ( ModelPrimitiveType string string string String )
            value.PercentGroupSeparator                     = GetString(new IntPtr(p + 0x088)); // 0x88 PercentGroupSeparator       ( ModelPrimitiveType string string string String )
            value.PercentSymbol                             = GetString(new IntPtr(p + 0x090)); // 0x90 PercentSymbol               ( ModelPrimitiveType string string string String )
            value.PerMilleSymbol                            = GetString(new IntPtr(p + 0x098)); // 0x98 PerMilleSymbol              ( ModelPrimitiveType string string string String )
            value.NativeDigits                              = GetStringList(new IntPtr(p + 0x0A0)); // 0xA0 NativeDigits                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_dataItem                                = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 M_dataItem                  ( ModelPrimitiveType int int int Int32 )
            value.NumberDecimalDigits                       = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC NumberDecimalDigits         ( ModelPrimitiveType int int int Int32 )
            value.CurrencyDecimalDigits                     = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 CurrencyDecimalDigits       ( ModelPrimitiveType int int int Int32 )
            value.CurrencyPositivePattern                   = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 CurrencyPositivePattern     ( ModelPrimitiveType int int int Int32 )
            value.CurrencyNegativePattern                   = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 CurrencyNegativePattern     ( ModelPrimitiveType int int int Int32 )
            value.NumberNegativePattern                     = GetInt32(new IntPtr(p + 0x0BC)); // 0xBC NumberNegativePattern       ( ModelPrimitiveType int int int Int32 )
            value.PercentPositivePattern                    = GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 PercentPositivePattern      ( ModelPrimitiveType int int int Int32 )
            value.PercentNegativePattern                    = GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 PercentNegativePattern      ( ModelPrimitiveType int int int Int32 )
            value.PercentDecimalDigits                      = GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 PercentDecimalDigits        ( ModelPrimitiveType int int int Int32 )
            value.DigitSubstitution                         = GetInt32(new IntPtr(p + 0x0CC)); // 0xCC DigitSubstitution           ( ModelPrimitiveType int int int Int32 )
            value.IsReadOnly                                = GetBool(new IntPtr(p + 0x0D0)); // 0xD0 IsReadOnly                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_useUserOverride                         = GetBool(new IntPtr(p + 0x0D1)); // 0xD1 M_useUserOverride           ( ModelPrimitiveType bool bool bool Bool )
            value.M_isInvariant                             = GetBool(new IntPtr(p + 0x0D2)); // 0xD2 M_isInvariant               ( ModelPrimitiveType bool bool bool Bool )
            value.ValidForParseAsNumber                     = GetBool(new IntPtr(p + 0x0D3)); // 0xD3 ValidForParseAsNumber       ( ModelPrimitiveType bool bool bool Bool )
            value.ValidForParseAsCurrency                   = GetBool(new IntPtr(p + 0x0D4)); // 0xD4 ValidForParseAsCurrency     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
