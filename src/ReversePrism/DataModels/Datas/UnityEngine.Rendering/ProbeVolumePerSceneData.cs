using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Asset                                    00018651FC00 ModelClassType ProbeVolumeAsset ProbeVolumeAsset ProbeVolumeAsset Pointer
    // 028 CellSharedDataAsset                      000186634EF0 ModelClassType TextAsset TextAsset TextAsset Pointer
    // 030 CellSupportDataAsset                     000186634EF0 ModelClassType TextAsset TextAsset TextAsset Pointer
    // 038 SerializedScenarios                      000185D28C88 ModelEnumListType List`1<SerializablePerScenarioDataItem> List`1<SerializablePerScenarioDataItem> List<SerializablePerScenarioDataItem> Pointer
    // 040 scenarios                                Dictionary`2<string, PerScenarioData> IL2CPP_TYPE_GENERICINST
    // 048 AssetLoaded                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 ActiveScenario                           000186671910 ModelPrimitiveType string string string String
    // 058 OtherScenario                            000186671910 ModelPrimitiveType string string string String
    public partial class ProbeVolumePerSceneData : DataModel
    {
        public ProbeVolumeAsset?                        Asset                                   { get; set; }
        public TextAsset?                               CellSharedDataAsset                     { get; set; }
        public TextAsset?                               CellSupportDataAsset                    { get; set; }
        public List<SerializablePerScenarioDataItem>?   SerializedScenarios                     { get; set; }
        public bool                                     AssetLoaded                             { get; set; }
        public string                                   ActiveScenario                          { get; set; }
        public string                                   OtherScenario                           { get; set; }

        public static ProbeVolumePerSceneData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeVolumePerSceneData() { Pointer= p0 };

            value.Asset                                     = GetObject<ProbeVolumeAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProbeVolumeAsset.FromPointer); // 02466925F260 0x20 Asset                       ( 00018651FC00 ModelClassType ProbeVolumeAsset ProbeVolumeAsset ProbeVolumeAsset Pointer )
            value.CellSharedDataAsset                       = GetObject<TextAsset>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextAsset.FromPointer); // 02466925F280 0x28 CellSharedDataAsset         ( 000186634EF0 ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.CellSupportDataAsset                      = GetObject<TextAsset>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextAsset.FromPointer); // 02466925F2A0 0x30 CellSupportDataAsset        ( 000186634EF0 ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.SerializedScenarios                       = GetEnumList<SerializablePerScenarioDataItem>(new IntPtr(p + 0x038)); // 02466925F2C0 0x38 SerializedScenarios         ( 000185D28C88 ModelEnumListType List`1<SerializablePerScenarioDataItem> List`1<SerializablePerScenarioDataItem> List<SerializablePerScenarioDataItem> Pointer )
            value.AssetLoaded                               = GetBool(new IntPtr(p + 0x048)); // 02466925F300 0x48 AssetLoaded                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ActiveScenario                            = GetString(new IntPtr(p + 0x050)); // 02466925F320 0x50 ActiveScenario              ( 000186671910 ModelPrimitiveType string string string String )
            value.OtherScenario                             = GetString(new IntPtr(p + 0x058)); // 02466925F340 0x58 OtherScenario               ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
