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
    public partial class ControlItem
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
            var value   = new ControlItem();

            value.Name                                      = (InternedString)GetInt32(new IntPtr(p + 0x010)); // 0270D76F39E0 0x10 Name                        ( 0001865FE140 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Layout                                    = (InternedString)GetInt32(new IntPtr(p + 0x020)); // 0270D76F3A00 0x20 Layout                      ( 0001865FE140 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Variants                                  = (InternedString)GetInt32(new IntPtr(p + 0x030)); // 0270D76F3A20 0x30 Variants                    ( 0001865FE140 ModelEnumType InternedString InternedString InternedString Int32 )
            value.UseStateFrom                              = GetString(new IntPtr(p + 0x040)); // 0270D76F3A40 0x40 UseStateFrom                ( 000186671910 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x048)); // 0270D76F3A60 0x48 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.ShortDisplayName                          = GetString(new IntPtr(p + 0x050)); // 0270D76F3A80 0x50 ShortDisplayName            ( 000186671910 ModelPrimitiveType string string string String )
            value.Offset                                    = GetUInt32(new IntPtr(p + 0x098)); // 0270D76F3B20 0x98 Offset                      ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Bit                                       = GetUInt32(new IntPtr(p + 0x09C)); // 0270D76F3B40 0x9C Bit                         ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.SizeInBits                                = GetUInt32(new IntPtr(p + 0x0A0)); // 0270D76F3B60 0xA0 SizeInBits                  ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Format                                    = (FourCC)GetInt32(new IntPtr(p + 0x0A4)); // 0270D76F3B80 0xA4 Format                      ( 0001865BB210 ModelEnumType FourCC FourCC FourCC Int32 )
            value.Flags                                     = (Flags)GetInt32(new IntPtr(p + 0x0A8)); // 0270D76F3BA0 0xA8 Flags                       ( 0001865256A0 ModelEnumType Flags Flags Flags Int32 )
            value.ArraySize                                 = GetInt32(new IntPtr(p + 0x0AC)); // 0270D76F3BC0 0xAC ArraySize                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DefaultState                              = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0B0)); // 0270D76F3BE0 0xB0 DefaultState                ( 0001865144C0 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )
            value.MinValue                                  = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0C0)); // 0270D76F3C00 0xC0 MinValue                    ( 0001865144C0 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )
            value.MaxValue                                  = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0D0)); // 0270D76F3C20 0xD0 MaxValue                    ( 0001865144C0 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )

            return value;
        }
    }
}
