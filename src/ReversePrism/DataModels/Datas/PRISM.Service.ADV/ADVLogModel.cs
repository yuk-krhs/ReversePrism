using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScenarioId                               0001866C4FD0 ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 018 Title                                    000186672F10 ModelPrimitiveType string string string String
    // 020 ContentList                              000185CE0698 ModelClassListType List`1<IADVLogNodeData> List`1<IADVLogNodeData> List<IADVLogNodeData> Pointer
    // 028 MasterData                               00018660B7A0 ModelClassType MasterData MasterData MasterData Pointer
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

            value.ScenarioId                                = GetObject<ScenarioID>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScenarioID.FromPointer); // 024666989BB0 0x10 ScenarioId                  ( 0001866C4FD0 ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 024666989BD0 0x18 Title                       ( 000186672F10 ModelPrimitiveType string string string String )
            value.ContentList                               = GetObjectList<IADVLogNodeData>(new IntPtr(p + 0x020), ReversePrism.DataModels.IADVLogNodeData.FromPointer); // 024666989BF0 0x20 ContentList                 ( 000185CE0698 ModelClassListType List`1<IADVLogNodeData> List`1<IADVLogNodeData> List<IADVLogNodeData> Pointer )
            value.MasterData                                = GetObject<MasterData>(new IntPtr(p + 0x028), ReversePrism.DataModels.MasterData.FromPointer); // 024666989C10 0x28 MasterData                  ( 00018660B7A0 ModelClassType MasterData MasterData MasterData Pointer )

            return value;
        }
    }
}
