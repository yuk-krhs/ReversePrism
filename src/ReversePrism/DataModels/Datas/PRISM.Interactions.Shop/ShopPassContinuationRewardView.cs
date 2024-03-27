using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PassTypeImage                            0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 ItemViewContent                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 ItemViewContainer                        000185CA3CC8 ModelClassListType ShopPassContinuationRewardItemView[] ShopPassContinuationRewardItemView[] List<ShopPassContinuationRewardItemView> Pointer
    // 038 NextStepContainer                        000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 ViewModels                               000185D09138 ModelClassListType List`1<ShopPassContinuationRewardItemViewModel> List`1<ShopPassContinuationRewardItemViewModel> List<ShopPassContinuationRewardItemViewModel> Pointer
    public partial class ShopPassContinuationRewardView
    {
        public Image?                                   PassTypeImage                           { get; set; }
        public Transform?                               ItemViewContent                         { get; set; }
        public List<ShopPassContinuationRewardItemView>? ItemViewContainer                       { get; set; }
        public List<GameObject>?                        NextStepContainer                       { get; set; }
        public List<ShopPassContinuationRewardItemViewModel>? ViewModels                              { get; set; }

        public static ShopPassContinuationRewardView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPassContinuationRewardView();

            value.PassTypeImage                             = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270DB820730 0x20 PassTypeImage               ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ItemViewContent                           = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB820750 0x28 ItemViewContent             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ItemViewContainer                         = GetObjectList<ShopPassContinuationRewardItemView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ShopPassContinuationRewardItemView.FromPointer); // 0270DB820770 0x30 ItemViewContainer           ( 000185CA3CC8 ModelClassListType ShopPassContinuationRewardItemView[] ShopPassContinuationRewardItemView[] List<ShopPassContinuationRewardItemView> Pointer )
            value.NextStepContainer                         = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB820790 0x38 NextStepContainer           ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ViewModels                                = GetObjectList<ShopPassContinuationRewardItemViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShopPassContinuationRewardItemViewModel.FromPointer); // 0270DB8207B0 0x40 ViewModels                  ( 000185D09138 ModelClassListType List`1<ShopPassContinuationRewardItemViewModel> List`1<ShopPassContinuationRewardItemViewModel> List<ShopPassContinuationRewardItemViewModel> Pointer )

            return value;
        }
    }
}
