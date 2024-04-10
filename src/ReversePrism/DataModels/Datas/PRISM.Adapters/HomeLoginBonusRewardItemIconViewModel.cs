using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StepStatus                               0001865A45A0 ModelClassType ILoginBonusStepStatus ILoginBonusStepStatus ILoginBonusStepStatus Pointer
    // 018 RewardList                               000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    public partial class HomeLoginBonusRewardItemIconViewModel : DataModel
    {
        public ILoginBonusStepStatus?                   StepStatus                              { get; set; }
        public List<IProductWithAmountStatus>?          RewardList                              { get; set; }

        public static HomeLoginBonusRewardItemIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeLoginBonusRewardItemIconViewModel() { Pointer= p0 };

            value.StepStatus                                = GetObject<ILoginBonusStepStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILoginBonusStepStatus.FromPointer); // 024666405FB0 0x10 StepStatus                  ( 0001865A45A0 ModelClassType ILoginBonusStepStatus ILoginBonusStepStatus ILoginBonusStepStatus Pointer )
            value.RewardList                                = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 024666405FD0 0x18 RewardList                  ( 000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
