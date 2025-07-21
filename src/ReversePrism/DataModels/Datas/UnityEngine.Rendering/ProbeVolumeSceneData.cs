using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_SceneGUID                              PropertyInfo IL2CPP_TYPE_CLASS
    // 010 SerializedBounds                         ModelEnumListType List`1<SerializableBoundItem> List`1<SerializableBoundItem> List<SerializableBoundItem> Pointer
    // 018 SerializedHasVolumes                     ModelEnumListType List`1<SerializableHasPVItem> List`1<SerializableHasPVItem> List<SerializableHasPVItem> Pointer
    // 020 SerializedProfiles                       ModelEnumListType List`1<SerializablePVProfile> List`1<SerializablePVProfile> List<SerializablePVProfile> Pointer
    // 028 SerializedBakeSettings                   ModelEnumListType List`1<SerializablePVBakeSettings> List`1<SerializablePVBakeSettings> List<SerializablePVBakeSettings> Pointer
    // 030 SerializedBakingSets                     ModelClassListType List`1<BakingSet> List`1<BakingSet> List<BakingSet> Pointer
    // 038 ParentAsset                              ModelClassType Object Object Object Pointer
    // 040 ParentSceneDataPropertyName              ModelPrimitiveType string string string String
    // 048 sceneBounds                              Dictionary`2<string, Bounds> IL2CPP_TYPE_GENERICINST
    // 050 hasProbeVolumes                          Dictionary`2<string, bool> IL2CPP_TYPE_GENERICINST
    // 058 sceneProfiles                            Dictionary`2<string, ProbeReferenceVolumeProfile> IL2CPP_TYPE_GENERICINST
    // 060 sceneBakingSettings                      Dictionary`2<string, ProbeVolumeBakingProcessSettings> IL2CPP_TYPE_GENERICINST
    // 068 BakingSets                               ModelClassListType List`1<BakingSet> List`1<BakingSet> List<BakingSet> Pointer
    // 070 M_LightingScenario                       ModelPrimitiveType string string string String
    // 078 M_OtherScenario                          ModelPrimitiveType string string string String
    // 080 M_ScenarioBlendingFactor                 ModelPrimitiveType float float float Single
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

            value.SerializedBounds                          = GetEnumList<SerializableBoundItem>(new IntPtr(p + 0x010)); // 0x10 SerializedBounds            ( ModelEnumListType List`1<SerializableBoundItem> List`1<SerializableBoundItem> List<SerializableBoundItem> Pointer )
            value.SerializedHasVolumes                      = GetEnumList<SerializableHasPVItem>(new IntPtr(p + 0x018)); // 0x18 SerializedHasVolumes        ( ModelEnumListType List`1<SerializableHasPVItem> List`1<SerializableHasPVItem> List<SerializableHasPVItem> Pointer )
            value.SerializedProfiles                        = GetEnumList<SerializablePVProfile>(new IntPtr(p + 0x020)); // 0x20 SerializedProfiles          ( ModelEnumListType List`1<SerializablePVProfile> List`1<SerializablePVProfile> List<SerializablePVProfile> Pointer )
            value.SerializedBakeSettings                    = GetEnumList<SerializablePVBakeSettings>(new IntPtr(p + 0x028)); // 0x28 SerializedBakeSettings      ( ModelEnumListType List`1<SerializablePVBakeSettings> List`1<SerializablePVBakeSettings> List<SerializablePVBakeSettings> Pointer )
            value.SerializedBakingSets                      = GetObjectList<BakingSet>(new IntPtr(p + 0x030), ReversePrism.DataModels.BakingSet.FromPointer); // 0x30 SerializedBakingSets        ( ModelClassListType List`1<BakingSet> List`1<BakingSet> List<BakingSet> Pointer )
            value.ParentAsset                               = GetObject<Object>(new IntPtr(p + 0x038), ReversePrism.DataModels.Object.FromPointer); // 0x38 ParentAsset                 ( ModelClassType Object Object Object Pointer )
            value.ParentSceneDataPropertyName               = GetString(new IntPtr(p + 0x040)); // 0x40 ParentSceneDataPropertyName ( ModelPrimitiveType string string string String )
            value.BakingSets                                = GetObjectList<BakingSet>(new IntPtr(p + 0x068), ReversePrism.DataModels.BakingSet.FromPointer); // 0x68 BakingSets                  ( ModelClassListType List`1<BakingSet> List`1<BakingSet> List<BakingSet> Pointer )
            value.M_LightingScenario                        = GetString(new IntPtr(p + 0x070)); // 0x70 M_LightingScenario          ( ModelPrimitiveType string string string String )
            value.M_OtherScenario                           = GetString(new IntPtr(p + 0x078)); // 0x78 M_OtherScenario             ( ModelPrimitiveType string string string String )
            value.M_ScenarioBlendingFactor                  = GetSingle(new IntPtr(p + 0x080)); // 0x80 M_ScenarioBlendingFactor    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
