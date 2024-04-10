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
    // 018 SelfProfile                              0001865E9970 ModelClassType PvpMatchProfileStatus PvpMatchProfileStatus PvpMatchProfileStatus Pointer
    // 000 SelfUnitFieldNumber                      int IL2CPP_TYPE_I4
    // 020 SelfUnit                                 0001865E78E0 ModelClassType PvpInGameSelfUnitStatus PvpInGameSelfUnitStatus PvpInGameSelfUnitStatus Pointer
    // 000 OpponentProfileFieldNumber               int IL2CPP_TYPE_I4
    // 028 OpponentProfile                          0001865E9970 ModelClassType PvpMatchProfileStatus PvpMatchProfileStatus PvpMatchProfileStatus Pointer
    // 000 OpponentUnitFieldNumber                  int IL2CPP_TYPE_I4
    // 030 OpponentUnit                             0001865E6360 ModelClassType PvpInGameOpponentUnitStatus PvpInGameOpponentUnitStatus PvpInGameOpponentUnitStatus Pointer
    // 000 PvpEventEffectFieldNumber                int IL2CPP_TYPE_I4
    // 038 PvpEventEffect                           0001865E39A0 ModelClassType PvpEventEffectStatus PvpEventEffectStatus PvpEventEffectStatus Pointer
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

            value.SelfProfile                               = GetObject<PvpMatchProfileStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.PvpMatchProfileStatus.FromPointer); // 02466139D3E0 0x18 SelfProfile                 ( 0001865E9970 ModelClassType PvpMatchProfileStatus PvpMatchProfileStatus PvpMatchProfileStatus Pointer )
            value.SelfUnit                                  = GetObject<PvpInGameSelfUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpInGameSelfUnitStatus.FromPointer); // 02466139D420 0x20 SelfUnit                    ( 0001865E78E0 ModelClassType PvpInGameSelfUnitStatus PvpInGameSelfUnitStatus PvpInGameSelfUnitStatus Pointer )
            value.OpponentProfile                           = GetObject<PvpMatchProfileStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.PvpMatchProfileStatus.FromPointer); // 02466139D460 0x28 OpponentProfile             ( 0001865E9970 ModelClassType PvpMatchProfileStatus PvpMatchProfileStatus PvpMatchProfileStatus Pointer )
            value.OpponentUnit                              = GetObject<PvpInGameOpponentUnitStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.PvpInGameOpponentUnitStatus.FromPointer); // 02466139D4A0 0x30 OpponentUnit                ( 0001865E6360 ModelClassType PvpInGameOpponentUnitStatus PvpInGameOpponentUnitStatus PvpInGameOpponentUnitStatus Pointer )
            value.PvpEventEffect                            = GetObject<PvpEventEffectStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.PvpEventEffectStatus.FromPointer); // 02466139D4E0 0x38 PvpEventEffect              ( 0001865E39A0 ModelClassType PvpEventEffectStatus PvpEventEffectStatus PvpEventEffectStatus Pointer )

            return value;
        }
    }
}
