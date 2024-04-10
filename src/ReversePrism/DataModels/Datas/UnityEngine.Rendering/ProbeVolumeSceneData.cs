using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_SceneGUID                              PropertyInfo IL2CPP_TYPE_CLASS
    // 010 SerializedBounds                         000185D29188 ModelEnumListType List`1<SerializableBoundItem> List`1<SerializableBoundItem> List<SerializableBoundItem> Pointer
    // 018 SerializedHasVolumes                     000185D293D8 ModelEnumListType List`1<SerializableHasPVItem> List`1<SerializableHasPVItem> List<SerializableHasPVItem> Pointer
    // 020 SerializedProfiles                       000185D298D8 ModelEnumListType List`1<SerializablePVProfile> List`1<SerializablePVProfile> List<SerializablePVProfile> Pointer
    // 028 SerializedBakeSettings                   000185D29628 ModelEnumListType List`1<SerializablePVBakeSettings> List`1<SerializablePVBakeSettings> List<SerializablePVBakeSettings> Pointer
    // 030 SerializedBakingSets                     000185D28E78 ModelClassListType List`1<BakingSet> List`1<BakingSet> List<BakingSet> Pointer
    // 038 ParentAsset                              0001866384B0 ModelClassType Object Object Object Pointer
    // 040 ParentSceneDataPropertyName              000186671BA0 ModelPrimitiveType string string string String
    // 048 sceneBounds                              Dictionary`2<string, Bounds> IL2CPP_TYPE_GENERICINST
    // 050 hasProbeVolumes                          Dictionary`2<string, bool> IL2CPP_TYPE_GENERICINST
    // 058 sceneProfiles                            Dictionary`2<string, ProbeReferenceVolumeProfile> IL2CPP_TYPE_GENERICINST
    // 060 sceneBakingSettings                      Dictionary`2<string, ProbeVolumeBakingProcessSettings> IL2CPP_TYPE_GENERICINST
    // 068 BakingSets                               000185D28F38 ModelClassListType List`1<BakingSet> List`1<BakingSet> List<BakingSet> Pointer
    // 070 M_LightingScenario                       000186671910 ModelPrimitiveType string string string String
    // 078 M_OtherScenario                          000186671910 ModelPrimitiveType string string string String
    // 080 M_ScenarioBlendingFactor                 0001866656B0 ModelPrimitiveType float float float Single
    public partial class ProbeVolumeSceneData : DataModel
    {
        public List<SerializableBoundItem>?             SerializedBounds                        { get; set; }
        public List<SerializableHasPVItem>?             SerializedHasVolumes                    { get; set; }
        public List<SerializablePVProfile>?             SerializedProfiles                      { get; set; }
        public List<SerializablePVBakeSettings>?        SerializedBakeSettings                  { get; set; }
        public List<BakingSet>?                         SerializedBakingSets                    { get; set; }
        public Object?                                  ParentAsset                             { get; set; }
        public string                                   ParentSceneDataPropertyName             { get; set; }
        public List<BakingSet>?                         BakingSets                              { get; set; }
        public string                                   M_LightingScenario                      { get; set; }
        public string                                   M_OtherScenario                         { get; set; }
        public float                                    M_ScenarioBlendingFactor                { get; set; }

        public static ProbeVolumeSceneData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeVolumeSceneData() { Pointer= p0 };

            value.SerializedBounds                          = GetEnumList<SerializableBoundItem>(new IntPtr(p + 0x010)); // 024669240060 0x10 SerializedBounds            ( 000185D29188 ModelEnumListType List`1<SerializableBoundItem> List`1<SerializableBoundItem> List<SerializableBoundItem> Pointer )
            value.SerializedHasVolumes                      = GetEnumList<SerializableHasPVItem>(new IntPtr(p + 0x018)); // 024669240080 0x18 SerializedHasVolumes        ( 000185D293D8 ModelEnumListType List`1<SerializableHasPVItem> List`1<SerializableHasPVItem> List<SerializableHasPVItem> Pointer )
            value.SerializedProfiles                        = GetEnumList<SerializablePVProfile>(new IntPtr(p + 0x020)); // 0246692400A0 0x20 SerializedProfiles          ( 000185D298D8 ModelEnumListType List`1<SerializablePVProfile> List`1<SerializablePVProfile> List<SerializablePVProfile> Pointer )
            value.SerializedBakeSettings                    = GetEnumList<SerializablePVBakeSettings>(new IntPtr(p + 0x028)); // 0246692400C0 0x28 SerializedBakeSettings      ( 000185D29628 ModelEnumListType List`1<SerializablePVBakeSettings> List`1<SerializablePVBakeSettings> List<SerializablePVBakeSettings> Pointer )
            value.SerializedBakingSets                      = GetObjectList<BakingSet>(new IntPtr(p + 0x030), ReversePrism.DataModels.BakingSet.FromPointer); // 0246692400E0 0x30 SerializedBakingSets        ( 000185D28E78 ModelClassListType List`1<BakingSet> List`1<BakingSet> List<BakingSet> Pointer )
            value.ParentAsset                               = GetObject<Object>(new IntPtr(p + 0x038), ReversePrism.DataModels.Object.FromPointer); // 024669240100 0x38 ParentAsset                 ( 0001866384B0 ModelClassType Object Object Object Pointer )
            value.ParentSceneDataPropertyName               = GetString(new IntPtr(p + 0x040)); // 024669240120 0x40 ParentSceneDataPropertyName ( 000186671BA0 ModelPrimitiveType string string string String )
            value.BakingSets                                = GetObjectList<BakingSet>(new IntPtr(p + 0x068), ReversePrism.DataModels.BakingSet.FromPointer); // 0246692401C0 0x68 BakingSets                  ( 000185D28F38 ModelClassListType List`1<BakingSet> List`1<BakingSet> List<BakingSet> Pointer )
            value.M_LightingScenario                        = GetString(new IntPtr(p + 0x070)); // 0246692401E0 0x70 M_LightingScenario          ( 000186671910 ModelPrimitiveType string string string String )
            value.M_OtherScenario                           = GetString(new IntPtr(p + 0x078)); // 024669240200 0x78 M_OtherScenario             ( 000186671910 ModelPrimitiveType string string string String )
            value.M_ScenarioBlendingFactor                  = GetSingle(new IntPtr(p + 0x080)); // 024669240220 0x80 M_ScenarioBlendingFactor    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
