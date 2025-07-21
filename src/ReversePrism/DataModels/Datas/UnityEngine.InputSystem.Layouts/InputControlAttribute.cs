using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Layout                                   ModelPrimitiveType string string string String
    // 018 Variants                                 ModelPrimitiveType string string string String
    // 020 Name                                     ModelPrimitiveType string string string String
    // 028 Format                                   ModelPrimitiveType string string string String
    // 030 Usage                                    ModelPrimitiveType string string string String
    // 038 Usages                                   ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 Parameters                               ModelPrimitiveType string string string String
    // 048 Processors                               ModelPrimitiveType string string string String
    // 050 Alias                                    ModelPrimitiveType string string string String
    // 058 Aliases                                  ModelPrimitiveListType string[] string[] List<string> Pointer
    // 060 UseStateFrom                             ModelPrimitiveType string string string String
    // 068 Bit                                      ModelPrimitiveType uint uint uint UInt32
    // 06C Offset                                   ModelPrimitiveType uint uint uint UInt32
    // 070 SizeInBits                               ModelPrimitiveType uint uint uint UInt32
    // 074 ArraySize                                ModelPrimitiveType int int int Int32
    // 078 DisplayName                              ModelPrimitiveType string string string String
    // 080 ShortDisplayName                         ModelPrimitiveType string string string String
    // 088 Noisy                                    ModelPrimitiveType bool bool bool Bool
    // 089 Synthetic                                ModelPrimitiveType bool bool bool Bool
    // 08A DontReset                                ModelPrimitiveType bool bool bool Bool
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

            value.Layout                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Layout                      ( ModelPrimitiveType string string string String )
            value.Variants                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Variants                    ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.Format                                    = GetString(new IntPtr(p + 0x028)); // 0x28 Format                      ( ModelPrimitiveType string string string String )
            value.Usage                                     = GetString(new IntPtr(p + 0x030)); // 0x30 Usage                       ( ModelPrimitiveType string string string String )
            value.Usages                                    = GetStringList(new IntPtr(p + 0x038)); // 0x38 Usages                      ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Parameters                                = GetString(new IntPtr(p + 0x040)); // 0x40 Parameters                  ( ModelPrimitiveType string string string String )
            value.Processors                                = GetString(new IntPtr(p + 0x048)); // 0x48 Processors                  ( ModelPrimitiveType string string string String )
            value.Alias                                     = GetString(new IntPtr(p + 0x050)); // 0x50 Alias                       ( ModelPrimitiveType string string string String )
            value.Aliases                                   = GetStringList(new IntPtr(p + 0x058)); // 0x58 Aliases                     ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.UseStateFrom                              = GetString(new IntPtr(p + 0x060)); // 0x60 UseStateFrom                ( ModelPrimitiveType string string string String )
            value.Bit                                       = GetUInt32(new IntPtr(p + 0x068)); // 0x68 Bit                         ( ModelPrimitiveType uint uint uint UInt32 )
            value.Offset                                    = GetUInt32(new IntPtr(p + 0x06C)); // 0x6C Offset                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.SizeInBits                                = GetUInt32(new IntPtr(p + 0x070)); // 0x70 SizeInBits                  ( ModelPrimitiveType uint uint uint UInt32 )
            value.ArraySize                                 = GetInt32(new IntPtr(p + 0x074)); // 0x74 ArraySize                   ( ModelPrimitiveType int int int Int32 )
            value.DisplayName                               = GetString(new IntPtr(p + 0x078)); // 0x78 DisplayName                 ( ModelPrimitiveType string string string String )
            value.ShortDisplayName                          = GetString(new IntPtr(p + 0x080)); // 0x80 ShortDisplayName            ( ModelPrimitiveType string string string String )
            value.Noisy                                     = GetBool(new IntPtr(p + 0x088)); // 0x88 Noisy                       ( ModelPrimitiveType bool bool bool Bool )
            value.Synthetic                                 = GetBool(new IntPtr(p + 0x089)); // 0x89 Synthetic                   ( ModelPrimitiveType bool bool bool Bool )
            value.DontReset                                 = GetBool(new IntPtr(p + 0x08A)); // 0x8A DontReset                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
