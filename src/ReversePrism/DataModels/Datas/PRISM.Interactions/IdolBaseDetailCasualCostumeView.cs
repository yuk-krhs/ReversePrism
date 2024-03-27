using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 InStoryCostumeSettingView                000186636570 ModelClassType CostumeSettingView CostumeSettingView CostumeSettingView Pointer
    // 030 InOtherCostumeSettingView                000186636570 ModelClassType CostumeSettingView CostumeSettingView CostumeSettingView Pointer
    // 038 <ToCasualCostumeSelection>k__BackingField IObservable`1<IdolBaseCostumeTargetSceneType> IL2CPP_TYPE_GENERICINST
    // 040 <OnCostumeIconDetail>k__BackingField     IObservable`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    public partial class IdolBaseDetailCasualCostumeView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public CostumeSettingView?                      InStoryCostumeSettingView               { get; set; }
        public CostumeSettingView?                      InOtherCostumeSettingView               { get; set; }

        public static IdolBaseDetailCasualCostumeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailCasualCostumeView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA26C7C8 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.InStoryCostumeSettingView                 = GetObject<CostumeSettingView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CostumeSettingView.FromPointer); // 0270DA26C7E8 0x28 InStoryCostumeSettingView   ( 000186636570 ModelClassType CostumeSettingView CostumeSettingView CostumeSettingView Pointer )
            value.InOtherCostumeSettingView                 = GetObject<CostumeSettingView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CostumeSettingView.FromPointer); // 0270DA26C808 0x30 InOtherCostumeSettingView   ( 000186636570 ModelClassType CostumeSettingView CostumeSettingView CostumeSettingView Pointer )

            return value;
        }
    }
}
