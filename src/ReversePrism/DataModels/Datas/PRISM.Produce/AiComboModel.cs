using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AiPatternDataTargetList                  000185CCC478 ModelClassListType List`1<AiPatternData> List`1<AiPatternData> List<AiPatternData> Pointer
    // 018 AiPatternDataAllList                     000185CCC478 ModelClassListType List`1<AiPatternData> List`1<AiPatternData> List<AiPatternData> Pointer
    public partial class AiComboModel
    {
        public List<AiPatternData>?                     AiPatternDataTargetList                 { get; set; }
        public List<AiPatternData>?                     AiPatternDataAllList                    { get; set; }

        public static AiComboModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiComboModel();

            value.AiPatternDataTargetList                   = GetObjectList<AiPatternData>(new IntPtr(p + 0x010), ReversePrism.DataModels.AiPatternData.FromPointer); // 0270D5A6F338 0x10 AiPatternDataTargetList     ( 000185CCC478 ModelClassListType List`1<AiPatternData> List`1<AiPatternData> List<AiPatternData> Pointer )
            value.AiPatternDataAllList                      = GetObjectList<AiPatternData>(new IntPtr(p + 0x018), ReversePrism.DataModels.AiPatternData.FromPointer); // 0270D5A6F358 0x18 AiPatternDataAllList        ( 000185CCC478 ModelClassListType List`1<AiPatternData> List`1<AiPatternData> List<AiPatternData> Pointer )

            return value;
        }
    }
}
