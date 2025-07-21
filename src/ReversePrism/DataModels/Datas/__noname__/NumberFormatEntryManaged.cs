using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Currency_decimal_digits                  ModelPrimitiveType int int int Int32
    // 014 Currency_decimal_separator               ModelPrimitiveType int int int Int32
    // 018 Currency_group_separator                 ModelPrimitiveType int int int Int32
    // 01C Currency_group_sizes0                    ModelPrimitiveType int int int Int32
    // 020 Currency_group_sizes1                    ModelPrimitiveType int int int Int32
    // 024 Currency_negative_pattern                ModelPrimitiveType int int int Int32
    // 028 Currency_positive_pattern                ModelPrimitiveType int int int Int32
    // 02C Currency_symbol                          ModelPrimitiveType int int int Int32
    // 030 Nan_symbol                               ModelPrimitiveType int int int Int32
    // 034 Negative_infinity_symbol                 ModelPrimitiveType int int int Int32
    // 038 Negative_sign                            ModelPrimitiveType int int int Int32
    // 03C Number_decimal_digits                    ModelPrimitiveType int int int Int32
    // 040 Number_decimal_separator                 ModelPrimitiveType int int int Int32
    // 044 Number_group_separator                   ModelPrimitiveType int int int Int32
    // 048 Number_group_sizes0                      ModelPrimitiveType int int int Int32
    // 04C Number_group_sizes1                      ModelPrimitiveType int int int Int32
    // 050 Number_negative_pattern                  ModelPrimitiveType int int int Int32
    // 054 Per_mille_symbol                         ModelPrimitiveType int int int Int32
    // 058 Percent_negative_pattern                 ModelPrimitiveType int int int Int32
    // 05C Percent_positive_pattern                 ModelPrimitiveType int int int Int32
    // 060 Percent_symbol                           ModelPrimitiveType int int int Int32
    // 064 Positive_infinity_symbol                 ModelPrimitiveType int int int Int32
    // 068 Positive_sign                            ModelPrimitiveType int int int Int32
    public partial class NumberFormatEntryManaged : DataModel
    {
        public int                                      Currency_decimal_digits                 { get; set; }
        public int                                      Currency_decimal_separator              { get; set; }
        public int                                      Currency_group_separator                { get; set; }
        public int                                      Currency_group_sizes0                   { get; set; }
        public int                                      Currency_group_sizes1                   { get; set; }
        public int                                      Currency_negative_pattern               { get; set; }
        public int                                      Currency_positive_pattern               { get; set; }
        public int                                      Currency_symbol                         { get; set; }
        public int                                      Nan_symbol                              { get; set; }
        public int                                      Negative_infinity_symbol                { get; set; }
        public int                                      Negative_sign                           { get; set; }
        public int                                      Number_decimal_digits                   { get; set; }
        public int                                      Number_decimal_separator                { get; set; }
        public int                                      Number_group_separator                  { get; set; }
        public int                                      Number_group_sizes0                     { get; set; }
        public int                                      Number_group_sizes1                     { get; set; }
        public int                                      Number_negative_pattern                 { get; set; }
        public int                                      Per_mille_symbol                        { get; set; }
        public int                                      Percent_negative_pattern                { get; set; }
        public int                                      Percent_positive_pattern                { get; set; }
        public int                                      Percent_symbol                          { get; set; }
        public int                                      Positive_infinity_symbol                { get; set; }
        public int                                      Positive_sign                           { get; set; }

        public static NumberFormatEntryManaged? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NumberFormatEntryManaged() { Pointer= p0 };

            value.Currency_decimal_digits                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 Currency_decimal_digits     ( ModelPrimitiveType int int int Int32 )
            value.Currency_decimal_separator                = GetInt32(new IntPtr(p + 0x014)); // 0x14 Currency_decimal_separator  ( ModelPrimitiveType int int int Int32 )
            value.Currency_group_separator                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 Currency_group_separator    ( ModelPrimitiveType int int int Int32 )
            value.Currency_group_sizes0                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Currency_group_sizes0       ( ModelPrimitiveType int int int Int32 )
            value.Currency_group_sizes1                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Currency_group_sizes1       ( ModelPrimitiveType int int int Int32 )
            value.Currency_negative_pattern                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 Currency_negative_pattern   ( ModelPrimitiveType int int int Int32 )
            value.Currency_positive_pattern                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 Currency_positive_pattern   ( ModelPrimitiveType int int int Int32 )
            value.Currency_symbol                           = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Currency_symbol             ( ModelPrimitiveType int int int Int32 )
            value.Nan_symbol                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 Nan_symbol                  ( ModelPrimitiveType int int int Int32 )
            value.Negative_infinity_symbol                  = GetInt32(new IntPtr(p + 0x034)); // 0x34 Negative_infinity_symbol    ( ModelPrimitiveType int int int Int32 )
            value.Negative_sign                             = GetInt32(new IntPtr(p + 0x038)); // 0x38 Negative_sign               ( ModelPrimitiveType int int int Int32 )
            value.Number_decimal_digits                     = GetInt32(new IntPtr(p + 0x03C)); // 0x3C Number_decimal_digits       ( ModelPrimitiveType int int int Int32 )
            value.Number_decimal_separator                  = GetInt32(new IntPtr(p + 0x040)); // 0x40 Number_decimal_separator    ( ModelPrimitiveType int int int Int32 )
            value.Number_group_separator                    = GetInt32(new IntPtr(p + 0x044)); // 0x44 Number_group_separator      ( ModelPrimitiveType int int int Int32 )
            value.Number_group_sizes0                       = GetInt32(new IntPtr(p + 0x048)); // 0x48 Number_group_sizes0         ( ModelPrimitiveType int int int Int32 )
            value.Number_group_sizes1                       = GetInt32(new IntPtr(p + 0x04C)); // 0x4C Number_group_sizes1         ( ModelPrimitiveType int int int Int32 )
            value.Number_negative_pattern                   = GetInt32(new IntPtr(p + 0x050)); // 0x50 Number_negative_pattern     ( ModelPrimitiveType int int int Int32 )
            value.Per_mille_symbol                          = GetInt32(new IntPtr(p + 0x054)); // 0x54 Per_mille_symbol            ( ModelPrimitiveType int int int Int32 )
            value.Percent_negative_pattern                  = GetInt32(new IntPtr(p + 0x058)); // 0x58 Percent_negative_pattern    ( ModelPrimitiveType int int int Int32 )
            value.Percent_positive_pattern                  = GetInt32(new IntPtr(p + 0x05C)); // 0x5C Percent_positive_pattern    ( ModelPrimitiveType int int int Int32 )
            value.Percent_symbol                            = GetInt32(new IntPtr(p + 0x060)); // 0x60 Percent_symbol              ( ModelPrimitiveType int int int Int32 )
            value.Positive_infinity_symbol                  = GetInt32(new IntPtr(p + 0x064)); // 0x64 Positive_infinity_symbol    ( ModelPrimitiveType int int int Int32 )
            value.Positive_sign                             = GetInt32(new IntPtr(p + 0x068)); // 0x68 Positive_sign               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
