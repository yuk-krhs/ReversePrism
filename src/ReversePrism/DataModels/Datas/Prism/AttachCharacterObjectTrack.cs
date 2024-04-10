using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 MixerBehaviour                           00018670FF80 ModelClassType AttachCharacterObjectMixerBehaviour AttachCharacterObjectMixerBehaviour AttachCharacterObjectMixerBehaviour Pointer
    public partial class AttachCharacterObjectTrack : DataModel
    {
        public AttachCharacterObjectMixerBehaviour?     MixerBehaviour                          { get; set; }

        public static AttachCharacterObjectTrack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttachCharacterObjectTrack() { Pointer= p0 };

            value.MixerBehaviour                            = GetObject<AttachCharacterObjectMixerBehaviour>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.AttachCharacterObjectMixerBehaviour.FromPointer); // 024664E71AD8 0xA0 MixerBehaviour              ( 00018670FF80 ModelClassType AttachCharacterObjectMixerBehaviour AttachCharacterObjectMixerBehaviour AttachCharacterObjectMixerBehaviour Pointer )

            return value;
        }
    }
}
