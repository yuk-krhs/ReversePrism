using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RecoverStaminaByItemMultiReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AfterStaminaFieldNumber                  int IL2CPP_TYPE_I4
    // 018 AfterStamina                             00018656B490 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 020 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class RecoverStaminaByItemMultiReply : DataModel
    {
        public StaminaStatus?                           AfterStamina                            { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static RecoverStaminaByItemMultiReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecoverStaminaByItemMultiReply() { Pointer= p0 };

            value.AfterStamina                              = GetObject<StaminaStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StaminaStatus.FromPointer); // 0246628D15F0 0x18 AfterStamina                ( 00018656B490 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0246628D1630 0x20 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
