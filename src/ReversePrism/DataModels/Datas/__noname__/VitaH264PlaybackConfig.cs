using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseH264Playback                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 MaxWidth                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 MaxHeight                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C GetMemoryFromTexture                     000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class VitaH264PlaybackConfig
    {
        public bool                                     UseH264Playback                         { get; set; }
        public int                                      MaxWidth                                { get; set; }
        public int                                      MaxHeight                               { get; set; }
        public bool                                     GetMemoryFromTexture                    { get; set; }

        public static VitaH264PlaybackConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VitaH264PlaybackConfig();

            value.UseH264Playback                           = GetBool(new IntPtr(p + 0x010)); // 0270D117CA70 0x10 UseH264Playback             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.MaxWidth                                  = GetInt32(new IntPtr(p + 0x014)); // 0270D117CA90 0x14 MaxWidth                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxHeight                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D117CAB0 0x18 MaxHeight                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.GetMemoryFromTexture                      = GetBool(new IntPtr(p + 0x01C)); // 0270D117CAD0 0x1C GetMemoryFromTexture        ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
