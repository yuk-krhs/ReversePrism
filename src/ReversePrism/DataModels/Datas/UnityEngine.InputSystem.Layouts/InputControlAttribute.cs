using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Layout                                   000186671910 ModelPrimitiveType string string string String
    // 018 Variants                                 000186671910 ModelPrimitiveType string string string String
    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 028 Format                                   000186671910 ModelPrimitiveType string string string String
    // 030 Usage                                    000186671910 ModelPrimitiveType string string string String
    // 038 Usages                                   000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 Parameters                               000186671910 ModelPrimitiveType string string string String
    // 048 Processors                               000186671910 ModelPrimitiveType string string string String
    // 050 Alias                                    000186671910 ModelPrimitiveType string string string String
    // 058 Aliases                                  000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 060 UseStateFrom                             000186671910 ModelPrimitiveType string string string String
    // 068 Bit                                      000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 06C Offset                                   000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 070 SizeInBits                               000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 074 ArraySize                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 080 ShortDisplayName                         000186671910 ModelPrimitiveType string string string String
    // 088 Noisy                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 089 Synthetic                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 08A DontReset                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 090 <defaultState>k__BackingField            <object> IL2CPP_TYPE_OBJECT
    // 098 <minValue>k__BackingField                <object> IL2CPP_TYPE_OBJECT
    // 0A0 <maxValue>k__BackingField                <object> IL2CPP_TYPE_OBJECT
    public partial class InputControlAttribute : DataModel
    {
        public string                                   Layout                                  { get; set; }
        public string                                   Variants                                { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   Format                                  { get; set; }
        public string                                   Usage                                   { get; set; }
        public List<string>?                            Usages                                  { get; set; }
        public string                                   Parameters                              { get; set; }
        public string                                   Processors                              { get; set; }
        public string                                   Alias                                   { get; set; }
        public List<string>?                            Aliases                                 { get; set; }
        public string                                   UseStateFrom                            { get; set; }
        public uint                                     Bit                                     { get; set; }
        public uint                                     Offset                                  { get; set; }
        public uint                                     SizeInBits                              { get; set; }
        public int                                      ArraySize                               { get; set; }
        public string                                   DisplayName                             { get; set; }
        public string                                   ShortDisplayName                        { get; set; }
        public bool                                     Noisy                                   { get; set; }
        public bool                                     Synthetic                               { get; set; }
        public bool                                     DontReset                               { get; set; }

        public static InputControlAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputControlAttribute() { Pointer= p0 };

            value.Layout                                    = GetString(new IntPtr(p + 0x010)); // 024667894660 0x10 Layout                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Variants                                  = GetString(new IntPtr(p + 0x018)); // 024667894680 0x18 Variants                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0246678946A0 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Format                                    = GetString(new IntPtr(p + 0x028)); // 0246678946C0 0x28 Format                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Usage                                     = GetString(new IntPtr(p + 0x030)); // 0246678946E0 0x30 Usage                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Usages                                    = GetStringList(new IntPtr(p + 0x038)); // 024667894700 0x38 Usages                      ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Parameters                                = GetString(new IntPtr(p + 0x040)); // 024667894720 0x40 Parameters                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Processors                                = GetString(new IntPtr(p + 0x048)); // 024667894740 0x48 Processors                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Alias                                     = GetString(new IntPtr(p + 0x050)); // 024667894760 0x50 Alias                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Aliases                                   = GetStringList(new IntPtr(p + 0x058)); // 024667894780 0x58 Aliases                     ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.UseStateFrom                              = GetString(new IntPtr(p + 0x060)); // 0246678947A0 0x60 UseStateFrom                ( 000186671910 ModelPrimitiveType string string string String )
            value.Bit                                       = GetUInt32(new IntPtr(p + 0x068)); // 0246678947C0 0x68 Bit                         ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Offset                                    = GetUInt32(new IntPtr(p + 0x06C)); // 0246678947E0 0x6C Offset                      ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.SizeInBits                                = GetUInt32(new IntPtr(p + 0x070)); // 024667894800 0x70 SizeInBits                  ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.ArraySize                                 = GetInt32(new IntPtr(p + 0x074)); // 024667894820 0x74 ArraySize                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DisplayName                               = GetString(new IntPtr(p + 0x078)); // 024667894840 0x78 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.ShortDisplayName                          = GetString(new IntPtr(p + 0x080)); // 024667894860 0x80 ShortDisplayName            ( 000186671910 ModelPrimitiveType string string string String )
            value.Noisy                                     = GetBool(new IntPtr(p + 0x088)); // 024667894880 0x88 Noisy                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Synthetic                                 = GetBool(new IntPtr(p + 0x089)); // 0246678948A0 0x89 Synthetic                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DontReset                                 = GetBool(new IntPtr(p + 0x08A)); // 0246678948C0 0x8A DontReset                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
