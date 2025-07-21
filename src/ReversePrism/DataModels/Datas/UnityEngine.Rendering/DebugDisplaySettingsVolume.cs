using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VolumeDebugSettings                      ModelClassType IVolumeDebugSettings2 IVolumeDebugSettings2 IVolumeDebugSettings2 Pointer
    // 018 VolumeComponentEnumIndex                 ModelPrimitiveType int int int Int32
    public partial class DebugDisplaySettingsVolume : DataModel
    {
        public IVolumeDebugSettings2?                   VolumeDebugSettings                     { get; set; }
        public int                                      VolumeComponentEnumIndex                { get; set; }

        public static DebugDisplaySettingsVolume? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugDisplaySettingsVolume() { Pointer= p0 };

            value.VolumeDebugSettings                       = GetObject<IVolumeDebugSettings2>(new IntPtr(p + 0x010), ReversePrism.DataModels.IVolumeDebugSettings2.FromPointer); // 0x10 VolumeDebugSettings         ( ModelClassType IVolumeDebugSettings2 IVolumeDebugSettings2 IVolumeDebugSettings2 Pointer )
            value.VolumeComponentEnumIndex                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 VolumeComponentEnumIndex    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
