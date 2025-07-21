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
    // 018 MaxAvailableLiveBoost                    ModelPrimitiveType int int int Int32
    // 000 IsEventFieldNumber                       int IL2CPP_TYPE_I4
    // 01C IsEvent                                  ModelPrimitiveType bool bool bool Bool
    // 000 AutoLiveFieldNumber                      int IL2CPP_TYPE_I4
    // 020 AutoLive                                 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    // 000 SkipLiveFieldNumber                      int IL2CPP_TYPE_I4
    // 028 SkipLive                                 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    // 000 EventPeriodFieldNumber                   int IL2CPP_TYPE_I4
    // 030 EventPeriod                              ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 038 MstEventId                               ModelPrimitiveType int int int Int32
    // 000 EventBreakTimeFieldNumber                int IL2CPP_TYPE_I4
    // 040 EventBreakTime                           ModelClassType EventBreakTimeStatus EventBreakTimeStatus EventBreakTimeStatus Pointer
    public partial class GetStartLiveInfoReply : DataModel
    {
        public int                                      MaxAvailableLiveBoost                   { get; set; }
        public bool                                     IsEvent                                 { get; set; }
        public StaminaStatus?                           AutoLive                                { get; set; }
        public StaminaStatus?                           SkipLive                                { get; set; }
        public PeriodStatus?                            EventPeriod                             { get; set; }
        public int                                      MstEventId                              { get; set; }
        public EventBreakTimeStatus?                    EventBreakTime                          { get; set; }

        public static GetStartLiveInfoReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetStartLiveInfoReply() { Pointer= p0 };

            value.MaxAvailableLiveBoost                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 MaxAvailableLiveBoost       ( ModelPrimitiveType int int int Int32 )
            value.IsEvent                                   = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsEvent                     ( ModelPrimitiveType bool bool bool Bool )
            value.AutoLive                                  = GetObject<StaminaStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaStatus.FromPointer); // 0x20 AutoLive                    ( ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )
            value.SkipLive                                  = GetObject<StaminaStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.StaminaStatus.FromPointer); // 0x28 SkipLive                    ( ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )
            value.EventPeriod                               = GetObject<PeriodStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.PeriodStatus.FromPointer); // 0x30 EventPeriod                 ( ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x038)); // 0x38 MstEventId                  ( ModelPrimitiveType int int int Int32 )
            value.EventBreakTime                            = GetObject<EventBreakTimeStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.EventBreakTimeStatus.FromPointer); // 0x40 EventBreakTime              ( ModelClassType EventBreakTimeStatus EventBreakTimeStatus EventBreakTimeStatus Pointer )

            return value;
        }
    }
}
