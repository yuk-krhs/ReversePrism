using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetStartLiveInfoReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MaxAvailableLiveBoostFieldNumber         int IL2CPP_TYPE_I4
    // 018 MaxAvailableLiveBoost                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsEventFieldNumber                       int IL2CPP_TYPE_I4
    // 01C IsEvent                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 AutoLiveFieldNumber                      int IL2CPP_TYPE_I4
    // 020 AutoLive                                 00018656B490 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    // 000 SkipLiveFieldNumber                      int IL2CPP_TYPE_I4
    // 028 SkipLive                                 00018656B490 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    // 000 EventPeriodFieldNumber                   int IL2CPP_TYPE_I4
    // 030 EventPeriod                              000186734A00 ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    public partial class GetStartLiveInfoReply : DataModel
    {
        public int                                      MaxAvailableLiveBoost                   { get; set; }
        public bool                                     IsEvent                                 { get; set; }
        public StaminaStatus?                           AutoLive                                { get; set; }
        public StaminaStatus?                           SkipLive                                { get; set; }
        public PeriodStatus?                            EventPeriod                             { get; set; }

        public static GetStartLiveInfoReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetStartLiveInfoReply() { Pointer= p0 };

            value.MaxAvailableLiveBoost                     = GetInt32(new IntPtr(p + 0x018)); // 02466218CB88 0x18 MaxAvailableLiveBoost       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsEvent                                   = GetBool(new IntPtr(p + 0x01C)); // 02466218CBC8 0x1C IsEvent                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AutoLive                                  = GetObject<StaminaStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaStatus.FromPointer); // 02466218CC08 0x20 AutoLive                    ( 00018656B490 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )
            value.SkipLive                                  = GetObject<StaminaStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.StaminaStatus.FromPointer); // 02466218CC48 0x28 SkipLive                    ( 00018656B490 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )
            value.EventPeriod                               = GetObject<PeriodStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.PeriodStatus.FromPointer); // 02466218CC88 0x30 EventPeriod                 ( 000186734A00 ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )

            return value;
        }
    }
}
