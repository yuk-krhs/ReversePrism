using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseAmount                                ModelPrimitiveType long long long Int64
    // 018 PopupViewModel                           ModelClassType StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel Pointer
    // 020 RecoveryItemModel                        ModelClassType StaminaRecoveryItemModel StaminaRecoveryItemModel StaminaRecoveryItemModel Pointer
    public partial class StaminaRecoveryUseItemViewModel : DataModel
    {
        public long                                     UseAmount                               { get; set; }
        public StaminaRecoveryPopupViewModel?           PopupViewModel                          { get; set; }
        public StaminaRecoveryItemModel?                RecoveryItemModel                       { get; set; }

        public static StaminaRecoveryUseItemViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryUseItemViewModel() { Pointer= p0 };

            value.UseAmount                                 = GetInt64(new IntPtr(p + 0x010)); // 0x10 UseAmount                   ( ModelPrimitiveType long long long Int64 )
            value.PopupViewModel                            = GetObject<StaminaRecoveryPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StaminaRecoveryPopupViewModel.FromPointer); // 0x18 PopupViewModel              ( ModelClassType StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel Pointer )
            value.RecoveryItemModel                         = GetObject<StaminaRecoveryItemModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaRecoveryItemModel.FromPointer); // 0x20 RecoveryItemModel           ( ModelClassType StaminaRecoveryItemModel StaminaRecoveryItemModel StaminaRecoveryItemModel Pointer )

            return value;
        }
    }
}
