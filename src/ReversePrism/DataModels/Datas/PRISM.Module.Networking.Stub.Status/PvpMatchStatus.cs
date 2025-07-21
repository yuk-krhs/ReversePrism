using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PvpMatchStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelfProfileFieldNumber                   int IL2CPP_TYPE_I4
    // 018 SelfProfile                              ModelClassType PvpMatchProfileStatus PvpMatchProfileStatus PvpMatchProfileStatus Pointer
    // 000 SelfUnitFieldNumber                      int IL2CPP_TYPE_I4
    // 020 SelfUnit                                 ModelClassType PvpInGameSelfUnitStatus PvpInGameSelfUnitStatus PvpInGameSelfUnitStatus Pointer
    // 000 OpponentProfileFieldNumber               int IL2CPP_TYPE_I4
    // 028 OpponentProfile                          ModelClassType PvpMatchProfileStatus PvpMatchProfileStatus PvpMatchProfileStatus Pointer
    // 000 OpponentUnitFieldNumber                  int IL2CPP_TYPE_I4
    // 030 OpponentUnit                             ModelClassType PvpInGameOpponentUnitStatus PvpInGameOpponentUnitStatus PvpInGameOpponentUnitStatus Pointer
    // 000 PvpEventEffectFieldNumber                int IL2CPP_TYPE_I4
    // 038 PvpEventEffect                           ModelClassType PvpEventEffectStatus PvpEventEffectStatus PvpEventEffectStatus Pointer
    public partial class PvpMatchStatus : DataModel
    {
        public PvpMatchProfileStatus?                   SelfProfile                             { get; set; }
        public PvpInGameSelfUnitStatus?                 SelfUnit                                { get; set; }
        public PvpMatchProfileStatus?                   OpponentProfile                         { get; set; }
        public PvpInGameOpponentUnitStatus?             OpponentUnit                            { get; set; }
        public PvpEventEffectStatus?                    PvpEventEffect                          { get; set; }

        public static PvpMatchStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpMatchStatus() { Pointer= p0 };

            value.SelfProfile                               = GetObject<PvpMatchProfileStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.PvpMatchProfileStatus.FromPointer); // 0x18 SelfProfile                 ( ModelClassType PvpMatchProfileStatus PvpMatchProfileStatus PvpMatchProfileStatus Pointer )
            value.SelfUnit                                  = GetObject<PvpInGameSelfUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpInGameSelfUnitStatus.FromPointer); // 0x20 SelfUnit                    ( ModelClassType PvpInGameSelfUnitStatus PvpInGameSelfUnitStatus PvpInGameSelfUnitStatus Pointer )
            value.OpponentProfile                           = GetObject<PvpMatchProfileStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.PvpMatchProfileStatus.FromPointer); // 0x28 OpponentProfile             ( ModelClassType PvpMatchProfileStatus PvpMatchProfileStatus PvpMatchProfileStatus Pointer )
            value.OpponentUnit                              = GetObject<PvpInGameOpponentUnitStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.PvpInGameOpponentUnitStatus.FromPointer); // 0x30 OpponentUnit                ( ModelClassType PvpInGameOpponentUnitStatus PvpInGameOpponentUnitStatus PvpInGameOpponentUnitStatus Pointer )
            value.PvpEventEffect                            = GetObject<PvpEventEffectStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.PvpEventEffectStatus.FromPointer); // 0x38 PvpEventEffect              ( ModelClassType PvpEventEffectStatus PvpEventEffectStatus PvpEventEffectStatus Pointer )

            return value;
        }
    }
}
