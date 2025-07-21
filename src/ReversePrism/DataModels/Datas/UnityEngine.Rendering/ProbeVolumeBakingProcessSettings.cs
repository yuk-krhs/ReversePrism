using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Version                                ModelEnumType SettingsVersion SettingsVersion SettingsVersion Int32
    // 014 DilationSettings                         ModelEnumType ProbeDilationSettings ProbeDilationSettings ProbeDilationSettings Int32
    // 028 VirtualOffsetSettings                    ModelEnumType VirtualOffsetSettings VirtualOffsetSettings VirtualOffsetSettings Int32
    public partial class ProbeVolumeBakingProcessSettings : DataModel
    {
        public SettingsVersion                          M_Version                               { get; set; }
        public ProbeDilationSettings                    DilationSettings                        { get; set; }
        public VirtualOffsetSettings                    VirtualOffsetSettings                   { get; set; }

        public static ProbeVolumeBakingProcessSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeVolumeBakingProcessSettings() { Pointer= p0 };

            value.M_Version                                 = (SettingsVersion)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Version                   ( ModelEnumType SettingsVersion SettingsVersion SettingsVersion Int32 )
            value.DilationSettings                          = (ProbeDilationSettings)GetInt32(new IntPtr(p + 0x014)); // 0x14 DilationSettings            ( ModelEnumType ProbeDilationSettings ProbeDilationSettings ProbeDilationSettings Int32 )
            value.VirtualOffsetSettings                     = (VirtualOffsetSettings)GetInt32(new IntPtr(p + 0x028)); // 0x28 VirtualOffsetSettings       ( ModelEnumType VirtualOffsetSettings VirtualOffsetSettings VirtualOffsetSettings Int32 )

            return value;
        }
    }
}
