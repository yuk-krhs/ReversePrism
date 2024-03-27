using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastSeenTTT                              000186606A10 ModelEnumType TTT TTT TTT Int32
    // 014 TokenCount                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 SepCount                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C NumCount                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 PosLoc                                   000186605790 ModelEnumType FormatLiterals FormatLiterals FormatLiterals Int32
    // 048 NegLoc                                   000186605790 ModelEnumType FormatLiterals FormatLiterals FormatLiterals Int32
    // 070 PosLocInit                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 071 NegLocInit                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 FullPosPattern                           000186671910 ModelPrimitiveType string string string String
    // 080 FullNegPattern                           000186671910 ModelPrimitiveType string string string String
    // 088 Numbers0                                 000186713370 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32
    // 0A8 Numbers1                                 000186713370 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32
    // 0C8 Numbers2                                 000186713370 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32
    // 0E8 Numbers3                                 000186713370 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32
    // 108 Numbers4                                 000186713370 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32
    // 128 _literals0                               ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 138 _literals1                               ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 148 _literals2                               ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 158 _literals3                               ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 168 _literals4                               ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 178 _literals5                               ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    public partial class TimeSpanRawInfo
    {
        public TTT                                      LastSeenTTT                             { get; set; }
        public int                                      TokenCount                              { get; set; }
        public int                                      SepCount                                { get; set; }
        public int                                      NumCount                                { get; set; }
        public FormatLiterals                           PosLoc                                  { get; set; }
        public FormatLiterals                           NegLoc                                  { get; set; }
        public bool                                     PosLocInit                              { get; set; }
        public bool                                     NegLocInit                              { get; set; }
        public string                                   FullPosPattern                          { get; set; }
        public string                                   FullNegPattern                          { get; set; }
        public TimeSpanToken                            Numbers0                                { get; set; }
        public TimeSpanToken                            Numbers1                                { get; set; }
        public TimeSpanToken                            Numbers2                                { get; set; }
        public TimeSpanToken                            Numbers3                                { get; set; }
        public TimeSpanToken                            Numbers4                                { get; set; }

        public static TimeSpanRawInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeSpanRawInfo();

            value.LastSeenTTT                               = (TTT)GetInt32(new IntPtr(p + 0x010)); // 0270D6D34088 0x10 LastSeenTTT                 ( 000186606A10 ModelEnumType TTT TTT TTT Int32 )
            value.TokenCount                                = GetInt32(new IntPtr(p + 0x014)); // 0270D6D340A8 0x14 TokenCount                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.SepCount                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D6D340C8 0x18 SepCount                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.NumCount                                  = GetInt32(new IntPtr(p + 0x01C)); // 0270D6D340E8 0x1C NumCount                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.PosLoc                                    = (FormatLiterals)GetInt32(new IntPtr(p + 0x020)); // 0270D6D34108 0x20 PosLoc                      ( 000186605790 ModelEnumType FormatLiterals FormatLiterals FormatLiterals Int32 )
            value.NegLoc                                    = (FormatLiterals)GetInt32(new IntPtr(p + 0x048)); // 0270D6D34128 0x48 NegLoc                      ( 000186605790 ModelEnumType FormatLiterals FormatLiterals FormatLiterals Int32 )
            value.PosLocInit                                = GetBool(new IntPtr(p + 0x070)); // 0270D6D34148 0x70 PosLocInit                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NegLocInit                                = GetBool(new IntPtr(p + 0x071)); // 0270D6D34168 0x71 NegLocInit                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FullPosPattern                            = GetString(new IntPtr(p + 0x078)); // 0270D6D34188 0x78 FullPosPattern              ( 000186671910 ModelPrimitiveType string string string String )
            value.FullNegPattern                            = GetString(new IntPtr(p + 0x080)); // 0270D6D341A8 0x80 FullNegPattern              ( 000186671910 ModelPrimitiveType string string string String )
            value.Numbers0                                  = (TimeSpanToken)GetInt32(new IntPtr(p + 0x088)); // 0270D6D341C8 0x88 Numbers0                    ( 000186713370 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32 )
            value.Numbers1                                  = (TimeSpanToken)GetInt32(new IntPtr(p + 0x0A8)); // 0270D6D341E8 0xA8 Numbers1                    ( 000186713370 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32 )
            value.Numbers2                                  = (TimeSpanToken)GetInt32(new IntPtr(p + 0x0C8)); // 0270D6D34208 0xC8 Numbers2                    ( 000186713370 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32 )
            value.Numbers3                                  = (TimeSpanToken)GetInt32(new IntPtr(p + 0x0E8)); // 0270D6D34228 0xE8 Numbers3                    ( 000186713370 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32 )
            value.Numbers4                                  = (TimeSpanToken)GetInt32(new IntPtr(p + 0x108)); // 0270D6D34248 0x108 Numbers4                    ( 000186713370 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32 )

            return value;
        }
    }
}
