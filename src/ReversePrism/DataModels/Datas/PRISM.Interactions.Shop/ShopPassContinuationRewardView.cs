using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PassTypeImage                            ModelClassType Image Image Image Pointer
    // 028 ItemViewContent                          ModelClassType Transform Transform Transform Pointer
    // 030 ItemViewContainer                        ModelClassListType ShopPassContinuationRewardItemView[] ShopPassContinuationRewardItemView[] List<ShopPassContinuationRewardItemView> Pointer
    // 038 NextStepContainer                        ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 ViewModels                               ModelClassListType List`1<ShopPassContinuationRewardItemViewModel> List`1<ShopPassContinuationRewardItemViewModel> List<ShopPassContinuationRewardItemViewModel> Pointer
    public partial class ShopPassContinuationRewardView : DataModel
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
            var value   = new ShopPassContinuationRewardView() { Pointer= p0 };

            value.PassTypeImage                             = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 PassTypeImage               ( ModelClassType Image Image Image Pointer )
            value.ItemViewContent                           = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 ItemViewContent             ( ModelClassType Transform Transform Transform Pointer )
            value.ItemViewContainer                         = GetObjectList<ShopPassContinuationRewardItemView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ShopPassContinuationRewardItemView.FromPointer); // 0x30 ItemViewContainer           ( ModelClassListType ShopPassContinuationRewardItemView[] ShopPassContinuationRewardItemView[] List<ShopPassContinuationRewardItemView> Pointer )
            value.NextStepContainer                         = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 NextStepContainer           ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ViewModels                                = GetObjectList<ShopPassContinuationRewardItemViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShopPassContinuationRewardItemViewModel.FromPointer); // 0x40 ViewModels                  ( ModelClassListType List`1<ShopPassContinuationRewardItemViewModel> List`1<ShopPassContinuationRewardItemViewModel> List<ShopPassContinuationRewardItemViewModel> Pointer )

            return value;
        }
    }
}
