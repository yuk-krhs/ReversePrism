using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OrderedCostumeIconView                   ModelClassType CostumeIconView CostumeIconView CostumeIconView Pointer
    // 028 RequiredItemIconPrefab                   ModelClassType RequiredItemIconView RequiredItemIconView RequiredItemIconView Pointer
    // 030 ItemPager                                ModelClassType ItemPager ItemPager ItemPager Pointer
    // 038 BtnHowToGet                              ModelClassType UIButton UIButton UIButton Pointer
    // 040 GoInsufficientWarning                    ModelClassType GameObject GameObject GameObject Pointer
    // 048 onCostumeDetail                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 058 Insufficient                             ModelPrimitiveType bool bool bool Bool
    // 060 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class DressOrderConfirmedPopupView : DataModel
    {
        public CostumeIconView?                         OrderedCostumeIconView                  { get; set; }
        public RequiredItemIconView?                    RequiredItemIconPrefab                  { get; set; }
        public ItemPager?                               ItemPager                               { get; set; }
        public UIButton?                                BtnHowToGet                             { get; set; }
        public GameObject?                              GoInsufficientWarning                   { get; set; }
        public bool                                     Insufficient                            { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static DressOrderConfirmedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressOrderConfirmedPopupView() { Pointer= p0 };

            value.OrderedCostumeIconView                    = GetObject<CostumeIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CostumeIconView.FromPointer); // 0x20 OrderedCostumeIconView      ( ModelClassType CostumeIconView CostumeIconView CostumeIconView Pointer )
            value.RequiredItemIconPrefab                    = GetObject<RequiredItemIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.RequiredItemIconView.FromPointer); // 0x28 RequiredItemIconPrefab      ( ModelClassType RequiredItemIconView RequiredItemIconView RequiredItemIconView Pointer )
            value.ItemPager                                 = GetObject<ItemPager>(new IntPtr(p + 0x030), ReversePrism.DataModels.ItemPager.FromPointer); // 0x30 ItemPager                   ( ModelClassType ItemPager ItemPager ItemPager Pointer )
            value.BtnHowToGet                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 BtnHowToGet                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.GoInsufficientWarning                     = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 GoInsufficientWarning       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Insufficient                              = GetBool(new IntPtr(p + 0x058)); // 0x58 Insufficient                ( ModelPrimitiveType bool bool bool Bool )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x60 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
