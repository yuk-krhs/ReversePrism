using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Clip                                   ModelClassType AudioClip AudioClip AudioClip Pointer
    // 020 M_Loop                                   ModelPrimitiveType bool bool bool Bool
    // 024 M_bufferingTime                          ModelPrimitiveType float float float Single
    // 028 M_ClipProperties                         ModelClassType AudioClipProperties AudioClipProperties AudioClipProperties Pointer
    public partial class AudioPlayableAsset : DataModel
    {
        public AudioClip?                               M_Clip                                  { get; set; }
        public bool                                     M_Loop                                  { get; set; }
        public float                                    M_bufferingTime                         { get; set; }
        public AudioClipProperties?                     M_ClipProperties                        { get; set; }

        public static AudioPlayableAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AudioPlayableAsset() { Pointer= p0 };

            value.M_Clip                                    = GetObject<AudioClip>(new IntPtr(p + 0x018), ReversePrism.DataModels.AudioClip.FromPointer); // 0x18 M_Clip                      ( ModelClassType AudioClip AudioClip AudioClip Pointer )
            value.M_Loop                                    = GetBool(new IntPtr(p + 0x020)); // 0x20 M_Loop                      ( ModelPrimitiveType bool bool bool Bool )
            value.M_bufferingTime                           = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_bufferingTime             ( ModelPrimitiveType float float float Single )
            value.M_ClipProperties                          = GetObject<AudioClipProperties>(new IntPtr(p + 0x028), ReversePrism.DataModels.AudioClipProperties.FromPointer); // 0x28 M_ClipProperties            ( ModelClassType AudioClipProperties AudioClipProperties AudioClipProperties Pointer )

            return value;
        }
    }
}
