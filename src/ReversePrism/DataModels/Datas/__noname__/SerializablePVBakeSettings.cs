using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SceneGUID                                ModelPrimitiveType string string string String
    // 018 Settings                                 ModelEnumType ProbeVolumeBakingProcessSettings ProbeVolumeBakingProcessSettings ProbeVolumeBakingProcessSettings Int32
    public partial class SerializablePVBakeSettings : DataModel
    {
        public string                                   SceneGUID                               { get; set; }
        public ProbeVolumeBakingProcessSettings         Settings                                { get; set; }

        public static SerializablePVBakeSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializablePVBakeSettings() { Pointer= p0 };

            value.SceneGUID                                 = GetString(new IntPtr(p + 0x010)); // 0x10 SceneGUID                   ( ModelPrimitiveType string string string String )
            value.Settings                                  = (ProbeVolumeBakingProcessSettings)GetInt32(new IntPtr(p + 0x018)); // 0x18 Settings                    ( ModelEnumType ProbeVolumeBakingProcessSettings ProbeVolumeBakingProcessSettings ProbeVolumeBakingProcessSettings Int32 )

            return value;
        }
    }
}
