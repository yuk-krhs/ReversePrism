using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Layout                                   ModelPrimitiveType string string string String
    // 020 Variants                                 ModelPrimitiveType string string string String
    // 028 Usage                                    ModelPrimitiveType string string string String
    // 030 Alias                                    ModelPrimitiveType string string string String
    // 038 UseStateFrom                             ModelPrimitiveType string string string String
    // 040 Offset                                   ModelPrimitiveType uint uint uint UInt32
    // 044 Bit                                      ModelPrimitiveType uint uint uint UInt32
    // 048 SizeInBits                               ModelPrimitiveType uint uint uint UInt32
    // 050 Format                                   ModelPrimitiveType string string string String
    // 058 ArraySize                                ModelPrimitiveType int int int Int32
    // 060 Usages                                   ModelPrimitiveListType string[] string[] List<string> Pointer
    // 068 Aliases                                  ModelPrimitiveListType string[] string[] List<string> Pointer
    // 070 Parameters                               ModelPrimitiveType string string string String
    // 078 Processors                               ModelPrimitiveType string string string String
    // 080 DisplayName                              ModelPrimitiveType string string string String
    // 088 ShortDisplayName                         ModelPrimitiveType string string string String
    // 090 Noisy                                    ModelPrimitiveType bool bool bool Bool
    // 091 DontReset                                ModelPrimitiveType bool bool bool Bool
    // 092 Synthetic                                ModelPrimitiveType bool bool bool Bool
    // 098 DefaultState                             ModelPrimitiveType string string string String
    // 0A0 MinValue                                 ModelPrimitiveType string string string String
    // 0A8 MaxValue                                 ModelPrimitiveType string string string String
    public partial class ControlItemJson : DataModel
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
            var value   = new ControlItemJson() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Layout                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Layout                      ( ModelPrimitiveType string string string String )
            value.Variants                                  = GetString(new IntPtr(p + 0x020)); // 0x20 Variants                    ( ModelPrimitiveType string string string String )
            value.Usage                                     = GetString(new IntPtr(p + 0x028)); // 0x28 Usage                       ( ModelPrimitiveType string string string String )
            value.Alias                                     = GetString(new IntPtr(p + 0x030)); // 0x30 Alias                       ( ModelPrimitiveType string string string String )
            value.UseStateFrom                              = GetString(new IntPtr(p + 0x038)); // 0x38 UseStateFrom                ( ModelPrimitiveType string string string String )
            value.Offset                                    = GetUInt32(new IntPtr(p + 0x040)); // 0x40 Offset                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.Bit                                       = GetUInt32(new IntPtr(p + 0x044)); // 0x44 Bit                         ( ModelPrimitiveType uint uint uint UInt32 )
            value.SizeInBits                                = GetUInt32(new IntPtr(p + 0x048)); // 0x48 SizeInBits                  ( ModelPrimitiveType uint uint uint UInt32 )
            value.Format                                    = GetString(new IntPtr(p + 0x050)); // 0x50 Format                      ( ModelPrimitiveType string string string String )
            value.ArraySize                                 = GetInt32(new IntPtr(p + 0x058)); // 0x58 ArraySize                   ( ModelPrimitiveType int int int Int32 )
            value.Usages                                    = GetStringList(new IntPtr(p + 0x060)); // 0x60 Usages                      ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Aliases                                   = GetStringList(new IntPtr(p + 0x068)); // 0x68 Aliases                     ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Parameters                                = GetString(new IntPtr(p + 0x070)); // 0x70 Parameters                  ( ModelPrimitiveType string string string String )
            value.Processors                                = GetString(new IntPtr(p + 0x078)); // 0x78 Processors                  ( ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x080)); // 0x80 DisplayName                 ( ModelPrimitiveType string string string String )
            value.ShortDisplayName                          = GetString(new IntPtr(p + 0x088)); // 0x88 ShortDisplayName            ( ModelPrimitiveType string string string String )
            value.Noisy                                     = GetBool(new IntPtr(p + 0x090)); // 0x90 Noisy                       ( ModelPrimitiveType bool bool bool Bool )
            value.DontReset                                 = GetBool(new IntPtr(p + 0x091)); // 0x91 DontReset                   ( ModelPrimitiveType bool bool bool Bool )
            value.Synthetic                                 = GetBool(new IntPtr(p + 0x092)); // 0x92 Synthetic                   ( ModelPrimitiveType bool bool bool Bool )
            value.DefaultState                              = GetString(new IntPtr(p + 0x098)); // 0x98 DefaultState                ( ModelPrimitiveType string string string String )
            value.MinValue                                  = GetString(new IntPtr(p + 0x0A0)); // 0xA0 MinValue                    ( ModelPrimitiveType string string string String )
            value.MaxValue                                  = GetString(new IntPtr(p + 0x0A8)); // 0xA8 MaxValue                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
