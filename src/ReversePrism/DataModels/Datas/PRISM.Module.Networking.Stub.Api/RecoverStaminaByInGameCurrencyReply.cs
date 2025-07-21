using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RecoverStaminaByInGameCurrencyReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AfterStaminaFieldNumber                  int IL2CPP_TYPE_I4
    // 018 AfterStamina                             ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 020 HavingGroup                              ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class RecoverStaminaByInGameCurrencyReply : DataModel
    {
        public StaminaStatus?                           AfterStamina                            { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static RecoverStaminaByInGameCurrencyReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecoverStaminaByInGameCurrencyReply() { Pointer= p0 };

            value.AfterStamina                              = GetObject<StaminaStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StaminaStatus.FromPointer); // 0x18 AfterStamina                ( ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0x20 HavingGroup                 ( ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
