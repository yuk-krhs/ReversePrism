using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SceneGUID                                0001866722E0 ModelPrimitiveType string string string String
    // 018 Profile                                  00018651F180 ModelClassType ProbeReferenceVolumeProfile ProbeReferenceVolumeProfile ProbeReferenceVolumeProfile Pointer
    public partial class SerializablePVProfile
    {
        public string                                   SceneGUID                               { get; set; }
        public ProbeReferenceVolumeProfile?             Profile                                 { get; set; }

        public static SerializablePVProfile? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializablePVProfile();

            value.SceneGUID                                 = GetString(new IntPtr(p + 0x010)); // 0270D922BA80 0x10 SceneGUID                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Profile                                   = GetObject<ProbeReferenceVolumeProfile>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProbeReferenceVolumeProfile.FromPointer); // 0270D922BAA0 0x18 Profile                     ( 00018651F180 ModelClassType ProbeReferenceVolumeProfile ProbeReferenceVolumeProfile ProbeReferenceVolumeProfile Pointer )

            return value;
        }
    }
}
