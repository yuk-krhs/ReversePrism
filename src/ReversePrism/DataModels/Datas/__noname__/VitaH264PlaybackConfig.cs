using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseH264Playback                          ModelPrimitiveType bool bool bool Bool
    // 014 MaxWidth                                 ModelPrimitiveType int int int Int32
    // 018 MaxHeight                                ModelPrimitiveType int int int Int32
    // 01C GetMemoryFromTexture                     ModelPrimitiveType bool bool bool Bool
    public partial class VitaH264PlaybackConfig : DataModel
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
            var value   = new VitaH264PlaybackConfig() { Pointer= p0 };

            value.UseH264Playback                           = GetBool(new IntPtr(p + 0x010)); // 0x10 UseH264Playback             ( ModelPrimitiveType bool bool bool Bool )
            value.MaxWidth                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 MaxWidth                    ( ModelPrimitiveType int int int Int32 )
            value.MaxHeight                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MaxHeight                   ( ModelPrimitiveType int int int Int32 )
            value.GetMemoryFromTexture                      = GetBool(new IntPtr(p + 0x01C)); // 0x1C GetMemoryFromTexture        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
