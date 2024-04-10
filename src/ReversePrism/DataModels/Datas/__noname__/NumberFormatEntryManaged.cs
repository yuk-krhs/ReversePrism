using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Currency_decimal_digits                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 Currency_decimal_separator               0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Currency_group_separator                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C Currency_group_sizes0                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 Currency_group_sizes1                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 024 Currency_negative_pattern                0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 Currency_positive_pattern                0001865F2F90 ModelPrimitiveType int int int Int32
    // 02C Currency_symbol                          0001865F2F90 ModelPrimitiveType int int int Int32
    // 030 Nan_symbol                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 034 Negative_infinity_symbol                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 038 Negative_sign                            0001865F2F90 ModelPrimitiveType int int int Int32
    // 03C Number_decimal_digits                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 040 Number_decimal_separator                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 044 Number_group_separator                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 048 Number_group_sizes0                      0001865F2F90 ModelPrimitiveType int int int Int32
    // 04C Number_group_sizes1                      0001865F2F90 ModelPrimitiveType int int int Int32
    // 050 Number_negative_pattern                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 054 Per_mille_symbol                         0001865F2F90 ModelPrimitiveType int int int Int32
    // 058 Percent_negative_pattern                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 05C Percent_positive_pattern                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 060 Percent_symbol                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 064 Positive_infinity_symbol                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 068 Positive_sign                            0001865F2F90 ModelPrimitiveType int int int Int32
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

            value.Currency_decimal_digits                   = GetInt32(new IntPtr(p + 0x010)); // 024666D908C8 0x10 Currency_decimal_digits     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Currency_decimal_separator                = GetInt32(new IntPtr(p + 0x014)); // 024666D908E8 0x14 Currency_decimal_separator  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Currency_group_separator                  = GetInt32(new IntPtr(p + 0x018)); // 024666D90908 0x18 Currency_group_separator    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Currency_group_sizes0                     = GetInt32(new IntPtr(p + 0x01C)); // 024666D90928 0x1C Currency_group_sizes0       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Currency_group_sizes1                     = GetInt32(new IntPtr(p + 0x020)); // 024666D90948 0x20 Currency_group_sizes1       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Currency_negative_pattern                 = GetInt32(new IntPtr(p + 0x024)); // 024666D90968 0x24 Currency_negative_pattern   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Currency_positive_pattern                 = GetInt32(new IntPtr(p + 0x028)); // 024666D90988 0x28 Currency_positive_pattern   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Currency_symbol                           = GetInt32(new IntPtr(p + 0x02C)); // 024666D909A8 0x2C Currency_symbol             ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Nan_symbol                                = GetInt32(new IntPtr(p + 0x030)); // 024666D909C8 0x30 Nan_symbol                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Negative_infinity_symbol                  = GetInt32(new IntPtr(p + 0x034)); // 024666D909E8 0x34 Negative_infinity_symbol    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Negative_sign                             = GetInt32(new IntPtr(p + 0x038)); // 024666D90A08 0x38 Negative_sign               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Number_decimal_digits                     = GetInt32(new IntPtr(p + 0x03C)); // 024666D90A28 0x3C Number_decimal_digits       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Number_decimal_separator                  = GetInt32(new IntPtr(p + 0x040)); // 024666D90A48 0x40 Number_decimal_separator    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Number_group_separator                    = GetInt32(new IntPtr(p + 0x044)); // 024666D90A68 0x44 Number_group_separator      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Number_group_sizes0                       = GetInt32(new IntPtr(p + 0x048)); // 024666D90A88 0x48 Number_group_sizes0         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Number_group_sizes1                       = GetInt32(new IntPtr(p + 0x04C)); // 024666D90AA8 0x4C Number_group_sizes1         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Number_negative_pattern                   = GetInt32(new IntPtr(p + 0x050)); // 024666D90AC8 0x50 Number_negative_pattern     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Per_mille_symbol                          = GetInt32(new IntPtr(p + 0x054)); // 024666D90AE8 0x54 Per_mille_symbol            ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Percent_negative_pattern                  = GetInt32(new IntPtr(p + 0x058)); // 024666D90B08 0x58 Percent_negative_pattern    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Percent_positive_pattern                  = GetInt32(new IntPtr(p + 0x05C)); // 024666D90B28 0x5C Percent_positive_pattern    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Percent_symbol                            = GetInt32(new IntPtr(p + 0x060)); // 024666D90B48 0x60 Percent_symbol              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Positive_infinity_symbol                  = GetInt32(new IntPtr(p + 0x064)); // 024666D90B68 0x64 Positive_infinity_symbol    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Positive_sign                             = GetInt32(new IntPtr(p + 0x068)); // 024666D90B88 0x68 Positive_sign               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
