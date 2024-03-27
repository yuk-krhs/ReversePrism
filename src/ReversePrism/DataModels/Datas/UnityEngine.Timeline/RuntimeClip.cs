using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Clip                                   00018666DB50 ModelClassType TimelineClip TimelineClip TimelineClip Pointer
    // 020 M_Playable                               00018674C270 ModelEnumType Playable Playable Playable Int32
    // 030 M_ParentMixer                            00018674C270 ModelEnumType Playable Playable Playable Int32
    public partial class RuntimeClip
    {
        public TimelineClip?                            M_Clip                                  { get; set; }
        public Playable                                 M_Playable                              { get; set; }
        public Playable                                 M_ParentMixer                           { get; set; }

        public static RuntimeClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeClip();

            value.M_Clip                                    = GetObject<TimelineClip>(new IntPtr(p + 0x018), ReversePrism.DataModels.TimelineClip.FromPointer); // 0270073020F8 0x18 M_Clip                      ( 00018666DB50 ModelClassType TimelineClip TimelineClip TimelineClip Pointer )
            value.M_Playable                                = (Playable)GetInt32(new IntPtr(p + 0x020)); // 027007302118 0x20 M_Playable                  ( 00018674C270 ModelEnumType Playable Playable Playable Int32 )
            value.M_ParentMixer                             = (Playable)GetInt32(new IntPtr(p + 0x030)); // 027007302138 0x30 M_ParentMixer               ( 00018674C270 ModelEnumType Playable Playable Playable Int32 )

            return value;
        }
    }
}
