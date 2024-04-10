using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_TriggerControlIndex                    000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 M_Phase                                  00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 M_Flags                                  00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 M_TimerDuration                          0001866656B0 ModelPrimitiveType float float float Single
    // 018 M_StartTime                              0001865C2950 ModelPrimitiveType double double double Double
    // 020 M_TimerStartTime                         0001865C2950 ModelPrimitiveType double double double Double
    // 028 M_PerformedTime                          0001865C2950 ModelPrimitiveType double double double Double
    // 030 M_TotalTimeoutCompletionTimeDone         0001866656B0 ModelPrimitiveType float float float Single
    // 034 M_TotalTimeoutCompletionTimeRemaining    0001866656B0 ModelPrimitiveType float float float Single
    // 038 M_TimerMonitorIndex                      0001865F7700 ModelPrimitiveType long long long Int64
    public partial class InteractionState : DataModel
    {
        public ushort                                   M_TriggerControlIndex                   { get; set; }
        public sbyte                                    M_Phase                                 { get; set; }
        public sbyte                                    M_Flags                                 { get; set; }
        public float                                    M_TimerDuration                         { get; set; }
        public double                                   M_StartTime                             { get; set; }
        public double                                   M_TimerStartTime                        { get; set; }
        public double                                   M_PerformedTime                         { get; set; }
        public float                                    M_TotalTimeoutCompletionTimeDone        { get; set; }
        public float                                    M_TotalTimeoutCompletionTimeRemaining   { get; set; }
        public long                                     M_TimerMonitorIndex                     { get; set; }

        public static InteractionState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InteractionState() { Pointer= p0 };

            value.M_TriggerControlIndex                     = GetUInt16(new IntPtr(p + 0x010)); // 0246676DAC50 0x10 M_TriggerControlIndex       ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_Phase                                   = GetSByte(new IntPtr(p + 0x012)); // 0246676DAC70 0x12 M_Phase                     ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_Flags                                   = GetSByte(new IntPtr(p + 0x013)); // 0246676DAC90 0x13 M_Flags                     ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_TimerDuration                           = GetSingle(new IntPtr(p + 0x014)); // 0246676DACB0 0x14 M_TimerDuration             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_StartTime                               = GetDouble(new IntPtr(p + 0x018)); // 0246676DACD0 0x18 M_StartTime                 ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_TimerStartTime                          = GetDouble(new IntPtr(p + 0x020)); // 0246676DACF0 0x20 M_TimerStartTime            ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_PerformedTime                           = GetDouble(new IntPtr(p + 0x028)); // 0246676DAD10 0x28 M_PerformedTime             ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_TotalTimeoutCompletionTimeDone          = GetSingle(new IntPtr(p + 0x030)); // 0246676DAD30 0x30 M_TotalTimeoutCompletionTimeDone ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_TotalTimeoutCompletionTimeRemaining     = GetSingle(new IntPtr(p + 0x034)); // 0246676DAD50 0x34 M_TotalTimeoutCompletionTimeRemaining ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_TimerMonitorIndex                       = GetInt64(new IntPtr(p + 0x038)); // 0246676DAD70 0x38 M_TimerMonitorIndex         ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
