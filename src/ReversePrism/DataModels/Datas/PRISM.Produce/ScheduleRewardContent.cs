using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardContents                           000185D034E8 ModelClassListType List`1<RewardContent> List`1<RewardContent> List<RewardContent> Pointer
    // 028 ParameterContent                         00018671BD80 ModelClassType ParameterContent ParameterContent ParameterContent Pointer
    public partial class ScheduleRewardContent : DataModel
    {
        public List<RewardContent>?                     RewardContents                          { get; set; }
        public ParameterContent?                        ParameterContent                        { get; set; }

        public static ScheduleRewardContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleRewardContent() { Pointer= p0 };

            value.RewardContents                            = GetObjectList<RewardContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardContent.FromPointer); // 024665D91930 0x20 RewardContents              ( 000185D034E8 ModelClassListType List`1<RewardContent> List`1<RewardContent> List<RewardContent> Pointer )
            value.ParameterContent                          = GetObject<ParameterContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.ParameterContent.FromPointer); // 024665D91950 0x28 ParameterContent            ( 00018671BD80 ModelClassType ParameterContent ParameterContent ParameterContent Pointer )

            return value;
        }
    }
}
