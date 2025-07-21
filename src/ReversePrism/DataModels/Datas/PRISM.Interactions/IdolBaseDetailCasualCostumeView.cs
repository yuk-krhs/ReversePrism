using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 InStoryCostumeSettingView                ModelClassType CostumeSettingView CostumeSettingView CostumeSettingView Pointer
    // 030 InOtherCostumeSettingView                ModelClassType CostumeSettingView CostumeSettingView CostumeSettingView Pointer
    // 038 <ToCasualCostumeSelection>k__BackingField IObservable`1<IdolBaseCostumeTargetSceneType> IL2CPP_TYPE_GENERICINST
    // 040 <OnCostumeIconDetail>k__BackingField     IObservable`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    public partial class IdolBaseDetailCasualCostumeView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public CostumeSettingView?                      InStoryCostumeSettingView               { get; set; }
        public CostumeSettingView?                      InOtherCostumeSettingView               { get; set; }

        public static IdolBaseDetailCasualCostumeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailCasualCostumeView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.InStoryCostumeSettingView                 = GetObject<CostumeSettingView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CostumeSettingView.FromPointer); // 0x28 InStoryCostumeSettingView   ( ModelClassType CostumeSettingView CostumeSettingView CostumeSettingView Pointer )
            value.InOtherCostumeSettingView                 = GetObject<CostumeSettingView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CostumeSettingView.FromPointer); // 0x30 InOtherCostumeSettingView   ( ModelClassType CostumeSettingView CostumeSettingView CostumeSettingView Pointer )

            return value;
        }
    }
}
