using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RecoveryItemModel                        0001865660D0 ModelClassType StaminaRecoveryItemModel StaminaRecoveryItemModel StaminaRecoveryItemModel Pointer
    // 018 UseAmount                                0001865F7700 ModelPrimitiveType long long long Int64
    public partial class StaminaRecoveryUseItemModel
    {
        public StaminaRecoveryItemModel?                RecoveryItemModel                       { get; set; }
        public long                                     UseAmount                               { get; set; }

        public static StaminaRecoveryUseItemModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryUseItemModel();

            value.RecoveryItemModel                         = GetObject<StaminaRecoveryItemModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.StaminaRecoveryItemModel.FromPointer); // 0270D56108B0 0x10 RecoveryItemModel           ( 0001865660D0 ModelClassType StaminaRecoveryItemModel StaminaRecoveryItemModel StaminaRecoveryItemModel Pointer )
            value.UseAmount                                 = GetInt64(new IntPtr(p + 0x018)); // 0270D56108D0 0x18 UseAmount                   ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
