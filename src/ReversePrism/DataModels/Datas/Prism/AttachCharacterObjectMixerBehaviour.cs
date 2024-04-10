using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 CurrentClip                              00018666DB50 ModelClassType TimelineClip TimelineClip TimelineClip Pointer
    public partial class AttachCharacterObjectMixerBehaviour : DataModel
    {
        public TimelineClip?                            CurrentClip                             { get; set; }

        public static AttachCharacterObjectMixerBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttachCharacterObjectMixerBehaviour() { Pointer= p0 };

            value.CurrentClip                               = GetObject<TimelineClip>(new IntPtr(p + 0x038), ReversePrism.DataModels.TimelineClip.FromPointer); // 024664E718B8 0x38 CurrentClip                 ( 00018666DB50 ModelClassType TimelineClip TimelineClip TimelineClip Pointer )

            return value;
        }
    }
}
