using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelEnumType InternedString InternedString InternedString Int32
    // 020 Layout                                   ModelEnumType InternedString InternedString InternedString Int32
    // 030 Variants                                 ModelEnumType InternedString InternedString InternedString Int32
    // 040 UseStateFrom                             ModelPrimitiveType string string string String
    // 048 DisplayName                              ModelPrimitiveType string string string String
    // 050 ShortDisplayName                         ModelPrimitiveType string string string String
    // 058 <usages>k__BackingField                  ReadOnlyArray`1<InternedString> IL2CPP_TYPE_GENERICINST
    // 068 <aliases>k__BackingField                 ReadOnlyArray`1<InternedString> IL2CPP_TYPE_GENERICINST
    // 078 <parameters>k__BackingField              ReadOnlyArray`1<NamedValue> IL2CPP_TYPE_GENERICINST
    // 088 <processors>k__BackingField              ReadOnlyArray`1<NameAndParameters> IL2CPP_TYPE_GENERICINST
    // 098 Offset                                   ModelPrimitiveType uint uint uint UInt32
    // 09C Bit                                      ModelPrimitiveType uint uint uint UInt32
    // 0A0 SizeInBits                               ModelPrimitiveType uint uint uint UInt32
    // 0A4 Format                                   ModelEnumType FourCC FourCC FourCC Int32
    // 0A8 Flags                                    ModelEnumType Flags Flags Flags Int32
    // 0AC ArraySize                                ModelPrimitiveType int int int Int32
    // 0B0 DefaultState                             ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32
    // 0C0 MinValue                                 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32
    // 0D0 MaxValue                                 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32
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

            value.Name                                      = (InternedString)GetInt32(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Layout                                    = (InternedString)GetInt32(new IntPtr(p + 0x020)); // 0x20 Layout                      ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Variants                                  = (InternedString)GetInt32(new IntPtr(p + 0x030)); // 0x30 Variants                    ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.UseStateFrom                              = GetString(new IntPtr(p + 0x040)); // 0x40 UseStateFrom                ( ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x048)); // 0x48 DisplayName                 ( ModelPrimitiveType string string string String )
            value.ShortDisplayName                          = GetString(new IntPtr(p + 0x050)); // 0x50 ShortDisplayName            ( ModelPrimitiveType string string string String )
            value.Offset                                    = GetUInt32(new IntPtr(p + 0x098)); // 0x98 Offset                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.Bit                                       = GetUInt32(new IntPtr(p + 0x09C)); // 0x9C Bit                         ( ModelPrimitiveType uint uint uint UInt32 )
            value.SizeInBits                                = GetUInt32(new IntPtr(p + 0x0A0)); // 0xA0 SizeInBits                  ( ModelPrimitiveType uint uint uint UInt32 )
            value.Format                                    = (FourCC)GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 Format                      ( ModelEnumType FourCC FourCC FourCC Int32 )
            value.Flags                                     = (Flags)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 Flags                       ( ModelEnumType Flags Flags Flags Int32 )
            value.ArraySize                                 = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC ArraySize                   ( ModelPrimitiveType int int int Int32 )
            value.DefaultState                              = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 DefaultState                ( ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )
            value.MinValue                                  = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 MinValue                    ( ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )
            value.MaxValue                                  = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 MaxValue                    ( ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )

            return value;
        }
    }
}
