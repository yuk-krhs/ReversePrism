using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 SceneGUIDs                               000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 020 Settings                                 000186520410 ModelEnumType ProbeVolumeBakingProcessSettings ProbeVolumeBakingProcessSettings ProbeVolumeBakingProcessSettings Int32
    // 050 Profile                                  00018651F180 ModelClassType ProbeReferenceVolumeProfile ProbeReferenceVolumeProfile ProbeReferenceVolumeProfile Pointer
    // 058 LightingScenarios                        000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class BakingSet
    {
        public string                                   Name                                    { get; set; }
        public List<string>?                            SceneGUIDs                              { get; set; }
        public ProbeVolumeBakingProcessSettings         Settings                                { get; set; }
        public ProbeReferenceVolumeProfile?             Profile                                 { get; set; }
        public List<string>?                            LightingScenarios                       { get; set; }

        public static BakingSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BakingSet();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D922BB00 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SceneGUIDs                                = GetStringList(new IntPtr(p + 0x018)); // 0270D922BB20 0x18 SceneGUIDs                  ( 000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Settings                                  = (ProbeVolumeBakingProcessSettings)GetInt32(new IntPtr(p + 0x020)); // 0270D922BB40 0x20 Settings                    ( 000186520410 ModelEnumType ProbeVolumeBakingProcessSettings ProbeVolumeBakingProcessSettings ProbeVolumeBakingProcessSettings Int32 )
            value.Profile                                   = GetObject<ProbeReferenceVolumeProfile>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProbeReferenceVolumeProfile.FromPointer); // 0270D922BB60 0x50 Profile                     ( 00018651F180 ModelClassType ProbeReferenceVolumeProfile ProbeReferenceVolumeProfile ProbeReferenceVolumeProfile Pointer )
            value.LightingScenarios                         = GetStringList(new IntPtr(p + 0x058)); // 0270D922BB80 0x58 LightingScenarios           ( 000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
