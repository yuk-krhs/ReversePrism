using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartLiveReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StartTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 018 StartType                                000186582F90 ModelEnumType LiveStartType LiveStartType LiveStartType Int32
    // 000 AutoLiveFieldNumber                      int IL2CPP_TYPE_I4
    // 020 AutoLive                                 00018656B490 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    // 000 SkipLiveFieldNumber                      int IL2CPP_TYPE_I4
    // 028 SkipLive                                 00018656B490 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    // 000 LiveBonusFieldNumber                     int IL2CPP_TYPE_I4
    // 030 LiveBonus                                00018656B490 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    // 000 LiveTokenFieldNumber                     int IL2CPP_TYPE_I4
    // 038 LiveToken                                000186671910 ModelPrimitiveType string string string String
    public partial class StartLiveReply
    {
        public LiveStartType                            StartType                               { get; set; }
        public StaminaStatus?                           AutoLive                                { get; set; }
        public StaminaStatus?                           SkipLive                                { get; set; }
        public StaminaStatus?                           LiveBonus                               { get; set; }
        public string                                   LiveToken                               { get; set; }

        public static StartLiveReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartLiveReply();

            value.StartType                                 = (LiveStartType)GetInt32(new IntPtr(p + 0x018)); // 0270D21FBAA0 0x18 StartType                   ( 000186582F90 ModelEnumType LiveStartType LiveStartType LiveStartType Int32 )
            value.AutoLive                                  = GetObject<StaminaStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaStatus.FromPointer); // 0270D21FBAE0 0x20 AutoLive                    ( 00018656B490 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )
            value.SkipLive                                  = GetObject<StaminaStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.StaminaStatus.FromPointer); // 0270D21FBB20 0x28 SkipLive                    ( 00018656B490 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )
            value.LiveBonus                                 = GetObject<StaminaStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.StaminaStatus.FromPointer); // 0270D21FBB60 0x30 LiveBonus                   ( 00018656B490 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )
            value.LiveToken                                 = GetString(new IntPtr(p + 0x038)); // 0270D21FBBA0 0x38 LiveToken                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
