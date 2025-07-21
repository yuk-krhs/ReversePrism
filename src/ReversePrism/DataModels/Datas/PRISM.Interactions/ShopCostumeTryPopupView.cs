using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoCostumeContent                         ModelClassType ShopDetailCostumeCell ShopDetailCostumeCell ShopDetailCostumeCell Pointer
    // 028 CostumeParent                            ModelClassType Transform Transform Transform Pointer
    // 030 BgContent                                ModelClassType Transform Transform Transform Pointer
    // 038 ShadeContent                             ModelClassType Transform Transform Transform Pointer
    // 040 <OnCostumeDetail>k__BackingField         IObservable`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    // 048 <OnClickDressUpRoom>k__BackingField      IObservable`1<ShopDetailCostumeViewModel> IL2CPP_TYPE_GENERICINST
    // 050 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 CurrentPopupSize                         ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32
    // 060 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ShopCostumeTryPopupView : DataModel
    {
        public ShopDetailCostumeCell?                   GoCostumeContent                        { get; set; }
        public Transform?                               CostumeParent                           { get; set; }
        public Transform?                               BgContent                               { get; set; }
        public Transform?                               ShadeContent                            { get; set; }
        public PopupSizeType                            CurrentPopupSize                        { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ShopCostumeTryPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopCostumeTryPopupView() { Pointer= p0 };

            value.GoCostumeContent                          = GetObject<ShopDetailCostumeCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopDetailCostumeCell.FromPointer); // 0x20 GoCostumeContent            ( ModelClassType ShopDetailCostumeCell ShopDetailCostumeCell ShopDetailCostumeCell Pointer )
            value.CostumeParent                             = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 CostumeParent               ( ModelClassType Transform Transform Transform Pointer )
            value.BgContent                                 = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 BgContent                   ( ModelClassType Transform Transform Transform Pointer )
            value.ShadeContent                              = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0x38 ShadeContent                ( ModelClassType Transform Transform Transform Pointer )
            value.CurrentPopupSize                          = (PopupSizeType)GetInt32(new IntPtr(p + 0x058)); // 0x58 CurrentPopupSize            ( ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32 )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x60 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
