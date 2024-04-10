using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001865FE140 ModelEnumType InternedString InternedString InternedString Int32
    // 020 Layout                                   0001865FE140 ModelEnumType InternedString InternedString InternedString Int32
    // 030 Variants                                 0001865FE140 ModelEnumType InternedString InternedString InternedString Int32
    // 040 UseStateFrom                             000186671910 ModelPrimitiveType string string string String
    // 048 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 050 ShortDisplayName                         000186671910 ModelPrimitiveType string string string String
    // 058 <usages>k__BackingField                  ReadOnlyArray`1<InternedString> IL2CPP_TYPE_GENERICINST
    // 068 <aliases>k__BackingField                 ReadOnlyArray`1<InternedString> IL2CPP_TYPE_GENERICINST
    // 078 <parameters>k__BackingField              ReadOnlyArray`1<NamedValue> IL2CPP_TYPE_GENERICINST
    // 088 <processors>k__BackingField              ReadOnlyArray`1<NameAndParameters> IL2CPP_TYPE_GENERICINST
    // 098 Offset                                   000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 09C Bit                                      000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 0A0 SizeInBits                               000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 0A4 Format                                   0001865BB210 ModelEnumType FourCC FourCC FourCC Int32
    // 0A8 Flags                                    0001865256A0 ModelEnumType Flags Flags Flags Int32
    // 0AC ArraySize                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0B0 DefaultState                             0001865144C0 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32
    // 0C0 MinValue                                 0001865144C0 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32
    // 0D0 MaxValue                                 0001865144C0 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32
    public partial class ControlItem : DataModel
    {
        public InternedString                           Name                                    { get; set; }
        public InternedString                           Layout                                  { get; set; }
        public InternedString                           Variants                                { get; set; }
        public string                                   UseStateFrom                            { get; set; }
        public string                                   DisplayName                             { get; set; }
        public string                                   ShortDisplayName                        { get; set; }
        public uint                                     Offset                                  { get; set; }
        public uint                                     Bit                                     { get; set; }
        public uint                                     SizeInBits                              { get; set; }
        public FourCC                                   Format                                  { get; set; }
        public Flags                                    Flags                                   { get; set; }
        public int                                      ArraySize                               { get; set; }
        public PrimitiveValue                           DefaultState                            { get; set; }
        public PrimitiveValue                           MinValue                                { get; set; }
        public PrimitiveValue                           MaxValue                                { get; set; }

        public static ControlItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ControlItem() { Pointer= p0 };

            value.Name                                      = (InternedString)GetInt32(new IntPtr(p + 0x010)); // 02466774B1B0 0x10 Name                        ( 0001865FE140 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Layout                                    = (InternedString)GetInt32(new IntPtr(p + 0x020)); // 02466774B1D0 0x20 Layout                      ( 0001865FE140 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Variants                                  = (InternedString)GetInt32(new IntPtr(p + 0x030)); // 02466774B1F0 0x30 Variants                    ( 0001865FE140 ModelEnumType InternedString InternedString InternedString Int32 )
            value.UseStateFrom                              = GetString(new IntPtr(p + 0x040)); // 02466774B210 0x40 UseStateFrom                ( 000186671910 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x048)); // 02466774B230 0x48 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.ShortDisplayName                          = GetString(new IntPtr(p + 0x050)); // 02466774B250 0x50 ShortDisplayName            ( 000186671910 ModelPrimitiveType string string string String )
            value.Offset                                    = GetUInt32(new IntPtr(p + 0x098)); // 02466774B2F0 0x98 Offset                      ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Bit                                       = GetUInt32(new IntPtr(p + 0x09C)); // 02466774B310 0x9C Bit                         ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.SizeInBits                                = GetUInt32(new IntPtr(p + 0x0A0)); // 02466774B330 0xA0 SizeInBits                  ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Format                                    = (FourCC)GetInt32(new IntPtr(p + 0x0A4)); // 02466774B350 0xA4 Format                      ( 0001865BB210 ModelEnumType FourCC FourCC FourCC Int32 )
            value.Flags                                     = (Flags)GetInt32(new IntPtr(p + 0x0A8)); // 02466774B370 0xA8 Flags                       ( 0001865256A0 ModelEnumType Flags Flags Flags Int32 )
            value.ArraySize                                 = GetInt32(new IntPtr(p + 0x0AC)); // 02466774B390 0xAC ArraySize                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DefaultState                              = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0B0)); // 02466774B3B0 0xB0 DefaultState                ( 0001865144C0 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )
            value.MinValue                                  = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0C0)); // 02466774B3D0 0xC0 MinValue                    ( 0001865144C0 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )
            value.MaxValue                                  = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0D0)); // 02466774B3F0 0xD0 MaxValue                    ( 0001865144C0 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )

            return value;
        }
    }
}
