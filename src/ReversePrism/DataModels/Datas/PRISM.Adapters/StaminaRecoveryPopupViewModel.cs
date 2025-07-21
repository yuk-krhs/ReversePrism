using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseItemViewModels                        ModelClassListType StaminaRecoveryUseItemViewModel[] StaminaRecoveryUseItemViewModel[] List<StaminaRecoveryUseItemViewModel> Pointer
    // 018 StaminaModel                             ModelClassType StaminaModel StaminaModel StaminaModel Pointer
    // 020 JewelModel                               ModelClassType JewelModel JewelModel JewelModel Pointer
    // 028 UseJewelModel                            ModelClassType StaminaRecoveryUseJewelModel StaminaRecoveryUseJewelModel StaminaRecoveryUseJewelModel Pointer
    public partial class StaminaRecoveryPopupViewModel : DataModel
    {
        public List<StaminaRecoveryUseItemViewModel>?   UseItemViewModels                       { get; set; }
        public StaminaModel?                            StaminaModel                            { get; set; }
        public JewelModel?                              JewelModel                              { get; set; }
        public StaminaRecoveryUseJewelModel?            UseJewelModel                           { get; set; }

        public static StaminaRecoveryPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryPopupViewModel() { Pointer= p0 };

            value.UseItemViewModels                         = GetObjectList<StaminaRecoveryUseItemViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.StaminaRecoveryUseItemViewModel.FromPointer); // 0x10 UseItemViewModels           ( ModelClassListType StaminaRecoveryUseItemViewModel[] StaminaRecoveryUseItemViewModel[] List<StaminaRecoveryUseItemViewModel> Pointer )
            value.StaminaModel                              = GetObject<StaminaModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StaminaModel.FromPointer); // 0x18 StaminaModel                ( ModelClassType StaminaModel StaminaModel StaminaModel Pointer )
            value.JewelModel                                = GetObject<JewelModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.JewelModel.FromPointer); // 0x20 JewelModel                  ( ModelClassType JewelModel JewelModel JewelModel Pointer )
            value.UseJewelModel                             = GetObject<StaminaRecoveryUseJewelModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.StaminaRecoveryUseJewelModel.FromPointer); // 0x28 UseJewelModel               ( ModelClassType StaminaRecoveryUseJewelModel StaminaRecoveryUseJewelModel StaminaRecoveryUseJewelModel Pointer )

            return value;
        }
    }
}
