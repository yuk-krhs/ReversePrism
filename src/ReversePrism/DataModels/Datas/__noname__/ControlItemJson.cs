using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Layout                                   0001866722E0 ModelPrimitiveType string string string String
    // 020 Variants                                 0001866722E0 ModelPrimitiveType string string string String
    // 028 Usage                                    0001866722E0 ModelPrimitiveType string string string String
    // 030 Alias                                    0001866722E0 ModelPrimitiveType string string string String
    // 038 UseStateFrom                             0001866722E0 ModelPrimitiveType string string string String
    // 040 Offset                                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 044 Bit                                      0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 048 SizeInBits                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 050 Format                                   0001866722E0 ModelPrimitiveType string string string String
    // 058 ArraySize                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 060 Usages                                   000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 068 Aliases                                  000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 070 Parameters                               0001866722E0 ModelPrimitiveType string string string String
    // 078 Processors                               0001866722E0 ModelPrimitiveType string string string String
    // 080 DisplayName                              0001866722E0 ModelPrimitiveType string string string String
    // 088 ShortDisplayName                         0001866722E0 ModelPrimitiveType string string string String
    // 090 Noisy                                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 091 DontReset                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 092 Synthetic                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 098 DefaultState                             0001866722E0 ModelPrimitiveType string string string String
    // 0A0 MinValue                                 0001866722E0 ModelPrimitiveType string string string String
    // 0A8 MaxValue                                 0001866722E0 ModelPrimitiveType string string string String
    public partial class ControlItemJson
    {
        public string                                   Name                                    { get; set; }
        public string                                   Layout                                  { get; set; }
        public string                                   Variants                                { get; set; }
        public string                                   Usage                                   { get; set; }
        public string                                   Alias                                   { get; set; }
        public string                                   UseStateFrom                            { get; set; }
        public uint                                     Offset                                  { get; set; }
        public uint                                     Bit                                     { get; set; }
        public uint                                     SizeInBits                              { get; set; }
        public string                                   Format                                  { get; set; }
        public int                                      ArraySize                               { get; set; }
        public List<string>?                            Usages                                  { get; set; }
        public List<string>?                            Aliases                                 { get; set; }
        public string                                   Parameters                              { get; set; }
        public string                                   Processors                              { get; set; }
        public string                                   DisplayName                             { get; set; }
        public string                                   ShortDisplayName                        { get; set; }
        public bool                                     Noisy                                   { get; set; }
        public bool                                     DontReset                               { get; set; }
        public bool                                     Synthetic                               { get; set; }
        public string                                   DefaultState                            { get; set; }
        public string                                   MinValue                                { get; set; }
        public string                                   MaxValue                                { get; set; }

        public static ControlItemJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ControlItemJson();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D7860BB0 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Layout                                    = GetString(new IntPtr(p + 0x018)); // 0270D7860BD0 0x18 Layout                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Variants                                  = GetString(new IntPtr(p + 0x020)); // 0270D7860BF0 0x20 Variants                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Usage                                     = GetString(new IntPtr(p + 0x028)); // 0270D7860C10 0x28 Usage                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Alias                                     = GetString(new IntPtr(p + 0x030)); // 0270D7860C30 0x30 Alias                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.UseStateFrom                              = GetString(new IntPtr(p + 0x038)); // 0270D7860C50 0x38 UseStateFrom                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Offset                                    = GetUInt32(new IntPtr(p + 0x040)); // 0270D7860C70 0x40 Offset                      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Bit                                       = GetUInt32(new IntPtr(p + 0x044)); // 0270D7860C90 0x44 Bit                         ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.SizeInBits                                = GetUInt32(new IntPtr(p + 0x048)); // 0270D7860CB0 0x48 SizeInBits                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Format                                    = GetString(new IntPtr(p + 0x050)); // 0270D7860CD0 0x50 Format                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ArraySize                                 = GetInt32(new IntPtr(p + 0x058)); // 0270D7860CF0 0x58 ArraySize                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Usages                                    = GetStringList(new IntPtr(p + 0x060)); // 0270D7860D10 0x60 Usages                      ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Aliases                                   = GetStringList(new IntPtr(p + 0x068)); // 0270D7860D30 0x68 Aliases                     ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Parameters                                = GetString(new IntPtr(p + 0x070)); // 0270D7860D50 0x70 Parameters                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Processors                                = GetString(new IntPtr(p + 0x078)); // 0270D7860D70 0x78 Processors                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x080)); // 0270D7860D90 0x80 DisplayName                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ShortDisplayName                          = GetString(new IntPtr(p + 0x088)); // 0270D7860DB0 0x88 ShortDisplayName            ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Noisy                                     = GetBool(new IntPtr(p + 0x090)); // 0270D7860DD0 0x90 Noisy                       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DontReset                                 = GetBool(new IntPtr(p + 0x091)); // 0270D7860DF0 0x91 DontReset                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Synthetic                                 = GetBool(new IntPtr(p + 0x092)); // 0270D7860E10 0x92 Synthetic                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DefaultState                              = GetString(new IntPtr(p + 0x098)); // 0270D7860E30 0x98 DefaultState                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.MinValue                                  = GetString(new IntPtr(p + 0x0A0)); // 0270D7860E50 0xA0 MinValue                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.MaxValue                                  = GetString(new IntPtr(p + 0x0A8)); // 0270D7860E70 0xA8 MaxValue                    ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
