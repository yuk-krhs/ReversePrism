using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BasePath                                 string IL2CPP_TYPE_STRING
    // 000 PopupPath                                string IL2CPP_TYPE_STRING
    // 000 SelectItemPopupPath                      string IL2CPP_TYPE_STRING
    // 010 StaminaRecoveryItemModels                000185CA6F68 ModelClassListType StaminaRecoveryItemModel[] StaminaRecoveryItemModel[] List<StaminaRecoveryItemModel> Pointer
    // 018 StaminaRecoveryUseItemModels             000185CA7168 ModelClassListType StaminaRecoveryUseItemModel[] StaminaRecoveryUseItemModel[] List<StaminaRecoveryUseItemModel> Pointer
    // 020 StaminaRecoveryUseJewelModel             000186569B80 ModelClassType StaminaRecoveryUseJewelModel StaminaRecoveryUseJewelModel StaminaRecoveryUseJewelModel Pointer
    // 028 StaminaModel                             000186564B10 ModelClassType StaminaModel StaminaModel StaminaModel Pointer
    // 030 popupIdList                              Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 038 JewelModel                               00018674B3C0 ModelClassType JewelModel JewelModel JewelModel Pointer
    public partial class StaminaRecoveryManager
    {
        public List<StaminaRecoveryItemModel>?          StaminaRecoveryItemModels               { get; set; }
        public List<StaminaRecoveryUseItemModel>?       StaminaRecoveryUseItemModels            { get; set; }
        public StaminaRecoveryUseJewelModel?            StaminaRecoveryUseJewelModel            { get; set; }
        public StaminaModel?                            StaminaModel                            { get; set; }
        public JewelModel?                              JewelModel                              { get; set; }

        public static StaminaRecoveryManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryManager();

            value.StaminaRecoveryItemModels                 = GetObjectList<StaminaRecoveryItemModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.StaminaRecoveryItemModel.FromPointer); // 0270D560FF10 0x10 StaminaRecoveryItemModels   ( 000185CA6F68 ModelClassListType StaminaRecoveryItemModel[] StaminaRecoveryItemModel[] List<StaminaRecoveryItemModel> Pointer )
            value.StaminaRecoveryUseItemModels              = GetObjectList<StaminaRecoveryUseItemModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StaminaRecoveryUseItemModel.FromPointer); // 0270D560FF30 0x18 StaminaRecoveryUseItemModels ( 000185CA7168 ModelClassListType StaminaRecoveryUseItemModel[] StaminaRecoveryUseItemModel[] List<StaminaRecoveryUseItemModel> Pointer )
            value.StaminaRecoveryUseJewelModel              = GetObject<StaminaRecoveryUseJewelModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaRecoveryUseJewelModel.FromPointer); // 0270D560FF50 0x20 StaminaRecoveryUseJewelModel ( 000186569B80 ModelClassType StaminaRecoveryUseJewelModel StaminaRecoveryUseJewelModel StaminaRecoveryUseJewelModel Pointer )
            value.StaminaModel                              = GetObject<StaminaModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.StaminaModel.FromPointer); // 0270D560FF70 0x28 StaminaModel                ( 000186564B10 ModelClassType StaminaModel StaminaModel StaminaModel Pointer )
            value.JewelModel                                = GetObject<JewelModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.JewelModel.FromPointer); // 0270D560FFB0 0x38 JewelModel                  ( 00018674B3C0 ModelClassType JewelModel JewelModel JewelModel Pointer )

            return value;
        }
    }
}
