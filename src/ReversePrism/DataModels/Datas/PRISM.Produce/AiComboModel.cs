using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AiPatternDataTargetList                  ModelClassListType List`1<AiPatternData> List`1<AiPatternData> List<AiPatternData> Pointer
    // 018 AiPatternDataAllList                     ModelClassListType List`1<AiPatternData> List`1<AiPatternData> List<AiPatternData> Pointer
    public partial class AiComboModel : DataModel
    {
        public List<AiPatternData>?                     AiPatternDataTargetList                 { get; set; }
        public List<AiPatternData>?                     AiPatternDataAllList                    { get; set; }

        public static AiComboModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiComboModel() { Pointer= p0 };

            value.AiPatternDataTargetList                   = GetObjectList<AiPatternData>(new IntPtr(p + 0x010), ReversePrism.DataModels.AiPatternData.FromPointer); // 0x10 AiPatternDataTargetList     ( ModelClassListType List`1<AiPatternData> List`1<AiPatternData> List<AiPatternData> Pointer )
            value.AiPatternDataAllList                      = GetObjectList<AiPatternData>(new IntPtr(p + 0x018), ReversePrism.DataModels.AiPatternData.FromPointer); // 0x18 AiPatternDataAllList        ( ModelClassListType List`1<AiPatternData> List`1<AiPatternData> List<AiPatternData> Pointer )

            return value;
        }
    }
}
