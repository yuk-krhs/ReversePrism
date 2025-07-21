using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseH264Playback                          ModelPrimitiveType bool bool bool Bool
    public partial class PCH264PlaybackConfig : DataModel
    {
        public bool                                     UseH264Playback                         { get; set; }

        public static PCH264PlaybackConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCH264PlaybackConfig() { Pointer= p0 };

            value.UseH264Playback                           = GetBool(new IntPtr(p + 0x010)); // 0x10 UseH264Playback             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
