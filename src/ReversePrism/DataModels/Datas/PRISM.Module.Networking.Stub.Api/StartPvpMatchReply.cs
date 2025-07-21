using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartPvpMatchReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MatchFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Match                                    ModelClassType PvpMatchStatus PvpMatchStatus PvpMatchStatus Pointer
    // 000 PvpStaminaFieldNumber                    int IL2CPP_TYPE_I4
    // 020 PvpStamina                               ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    // 000 IsChangedOpponentUnitFieldNumber         int IL2CPP_TYPE_I4
    // 028 IsChangedOpponentUnit                    ModelPrimitiveType bool bool bool Bool
    public partial class StartPvpMatchReply : DataModel
    {
        public PvpMatchStatus?                          Match                                   { get; set; }
        public StaminaStatus?                           PvpStamina                              { get; set; }
        public bool                                     IsChangedOpponentUnit                   { get; set; }

        public static StartPvpMatchReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartPvpMatchReply() { Pointer= p0 };

            value.Match                                     = GetObject<PvpMatchStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.PvpMatchStatus.FromPointer); // 0x18 Match                       ( ModelClassType PvpMatchStatus PvpMatchStatus PvpMatchStatus Pointer )
            value.PvpStamina                                = GetObject<StaminaStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaStatus.FromPointer); // 0x20 PvpStamina                  ( ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )
            value.IsChangedOpponentUnit                     = GetBool(new IntPtr(p + 0x028)); // 0x28 IsChangedOpponentUnit       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
