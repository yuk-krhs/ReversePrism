using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScenarioId                               ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 018 Title                                    ModelPrimitiveType string string string String
    // 020 ContentList                              ModelClassListType List`1<IADVLogNodeData> List`1<IADVLogNodeData> List<IADVLogNodeData> Pointer
    // 028 MasterData                               ModelClassType MasterData MasterData MasterData Pointer
    public partial class ADVLogModel : DataModel
    {
        public ScenarioID?                              ScenarioId                              { get; set; }
        public string                                   Title                                   { get; set; }
        public List<IADVLogNodeData>?                   ContentList                             { get; set; }
        public MasterData?                              MasterData                              { get; set; }

        public static ADVLogModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogModel() { Pointer= p0 };

            value.ScenarioId                                = GetObject<ScenarioID>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScenarioID.FromPointer); // 0x10 ScenarioId                  ( ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Title                       ( ModelPrimitiveType string string string String )
            value.ContentList                               = GetObjectList<IADVLogNodeData>(new IntPtr(p + 0x020), ReversePrism.DataModels.IADVLogNodeData.FromPointer); // 0x20 ContentList                 ( ModelClassListType List`1<IADVLogNodeData> List`1<IADVLogNodeData> List<IADVLogNodeData> Pointer )
            value.MasterData                                = GetObject<MasterData>(new IntPtr(p + 0x028), ReversePrism.DataModels.MasterData.FromPointer); // 0x28 MasterData                  ( ModelClassType MasterData MasterData MasterData Pointer )

            return value;
        }
    }
}
