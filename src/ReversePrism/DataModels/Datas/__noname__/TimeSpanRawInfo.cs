using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastSeenTTT                              ModelEnumType TTT TTT TTT Int32
    // 014 TokenCount                               ModelPrimitiveType int int int Int32
    // 018 SepCount                                 ModelPrimitiveType int int int Int32
    // 01C NumCount                                 ModelPrimitiveType int int int Int32
    // 020 PosLoc                                   ModelEnumType FormatLiterals FormatLiterals FormatLiterals Int32
    // 048 NegLoc                                   ModelEnumType FormatLiterals FormatLiterals FormatLiterals Int32
    // 070 PosLocInit                               ModelPrimitiveType bool bool bool Bool
    // 071 NegLocInit                               ModelPrimitiveType bool bool bool Bool
    // 078 FullPosPattern                           ModelPrimitiveType string string string String
    // 080 FullNegPattern                           ModelPrimitiveType string string string String
    // 088 Numbers0                                 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32
    // 0A8 Numbers1                                 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32
    // 0C8 Numbers2                                 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32
    // 0E8 Numbers3                                 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32
    // 108 Numbers4                                 ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32
    // 128 _literals0                               ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 138 _literals1                               ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 148 _literals2                               ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 158 _literals3                               ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 168 _literals4                               ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 178 _literals5                               ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    public partial class TimeSpanRawInfo : DataModel
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
            var value   = new TimeSpanRawInfo() { Pointer= p0 };

            value.LastSeenTTT                               = (TTT)GetInt32(new IntPtr(p + 0x010)); // 0x10 LastSeenTTT                 ( ModelEnumType TTT TTT TTT Int32 )
            value.TokenCount                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 TokenCount                  ( ModelPrimitiveType int int int Int32 )
            value.SepCount                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 SepCount                    ( ModelPrimitiveType int int int Int32 )
            value.NumCount                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C NumCount                    ( ModelPrimitiveType int int int Int32 )
            value.PosLoc                                    = (FormatLiterals)GetInt32(new IntPtr(p + 0x020)); // 0x20 PosLoc                      ( ModelEnumType FormatLiterals FormatLiterals FormatLiterals Int32 )
            value.NegLoc                                    = (FormatLiterals)GetInt32(new IntPtr(p + 0x048)); // 0x48 NegLoc                      ( ModelEnumType FormatLiterals FormatLiterals FormatLiterals Int32 )
            value.PosLocInit                                = GetBool(new IntPtr(p + 0x070)); // 0x70 PosLocInit                  ( ModelPrimitiveType bool bool bool Bool )
            value.NegLocInit                                = GetBool(new IntPtr(p + 0x071)); // 0x71 NegLocInit                  ( ModelPrimitiveType bool bool bool Bool )
            value.FullPosPattern                            = GetString(new IntPtr(p + 0x078)); // 0x78 FullPosPattern              ( ModelPrimitiveType string string string String )
            value.FullNegPattern                            = GetString(new IntPtr(p + 0x080)); // 0x80 FullNegPattern              ( ModelPrimitiveType string string string String )
            value.Numbers0                                  = (TimeSpanToken)GetInt32(new IntPtr(p + 0x088)); // 0x88 Numbers0                    ( ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32 )
            value.Numbers1                                  = (TimeSpanToken)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 Numbers1                    ( ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32 )
            value.Numbers2                                  = (TimeSpanToken)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 Numbers2                    ( ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32 )
            value.Numbers3                                  = (TimeSpanToken)GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 Numbers3                    ( ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32 )
            value.Numbers4                                  = (TimeSpanToken)GetInt32(new IntPtr(p + 0x108)); // 0x108 Numbers4                    ( ModelEnumType TimeSpanToken TimeSpanToken TimeSpanToken Int32 )

            return value;
        }
    }
}
