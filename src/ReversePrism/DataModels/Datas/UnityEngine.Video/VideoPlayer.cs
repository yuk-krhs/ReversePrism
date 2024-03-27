using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 PrepareCompleted                         0001866DF240 ModelClassType EventHandler EventHandler EventHandler Pointer
    // 020 LoopPointReached                         0001866DF240 ModelClassType EventHandler EventHandler EventHandler Pointer
    // 028 Started                                  0001866DF240 ModelClassType EventHandler EventHandler EventHandler Pointer
    // 030 FrameDropped                             0001866DF240 ModelClassType EventHandler EventHandler EventHandler Pointer
    // 038 ErrorReceived                            0001866DED40 ModelClassType ErrorEventHandler ErrorEventHandler ErrorEventHandler Pointer
    // 040 SeekCompleted                            0001866DF240 ModelClassType EventHandler EventHandler EventHandler Pointer
    // 048 ClockResyncOccurred                      0001866DFC00 ModelClassType TimeEventHandler TimeEventHandler TimeEventHandler Pointer
    // 050 FrameReady                               0001866DF720 ModelClassType FrameReadyEventHandler FrameReadyEventHandler FrameReadyEventHandler Pointer
    public partial class VideoPlayer
    {
        public EventHandler?                            PrepareCompleted                        { get; set; }
        public EventHandler?                            LoopPointReached                        { get; set; }
        public EventHandler?                            Started                                 { get; set; }
        public EventHandler?                            FrameDropped                            { get; set; }
        public ErrorEventHandler?                       ErrorReceived                           { get; set; }
        public EventHandler?                            SeekCompleted                           { get; set; }
        public TimeEventHandler?                        ClockResyncOccurred                     { get; set; }
        public FrameReadyEventHandler?                  FrameReady                              { get; set; }

        public static VideoPlayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VideoPlayer();

            value.PrepareCompleted                          = GetObject<EventHandler>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventHandler.FromPointer); // 0270020E5528 0x18 PrepareCompleted            ( 0001866DF240 ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.LoopPointReached                          = GetObject<EventHandler>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventHandler.FromPointer); // 0270020E5548 0x20 LoopPointReached            ( 0001866DF240 ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.Started                                   = GetObject<EventHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.EventHandler.FromPointer); // 0270020E5568 0x28 Started                     ( 0001866DF240 ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.FrameDropped                              = GetObject<EventHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.EventHandler.FromPointer); // 0270020E5588 0x30 FrameDropped                ( 0001866DF240 ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.ErrorReceived                             = GetObject<ErrorEventHandler>(new IntPtr(p + 0x038), ReversePrism.DataModels.ErrorEventHandler.FromPointer); // 0270020E55A8 0x38 ErrorReceived               ( 0001866DED40 ModelClassType ErrorEventHandler ErrorEventHandler ErrorEventHandler Pointer )
            value.SeekCompleted                             = GetObject<EventHandler>(new IntPtr(p + 0x040), ReversePrism.DataModels.EventHandler.FromPointer); // 0270020E55C8 0x40 SeekCompleted               ( 0001866DF240 ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.ClockResyncOccurred                       = GetObject<TimeEventHandler>(new IntPtr(p + 0x048), ReversePrism.DataModels.TimeEventHandler.FromPointer); // 0270020E55E8 0x48 ClockResyncOccurred         ( 0001866DFC00 ModelClassType TimeEventHandler TimeEventHandler TimeEventHandler Pointer )
            value.FrameReady                                = GetObject<FrameReadyEventHandler>(new IntPtr(p + 0x050), ReversePrism.DataModels.FrameReadyEventHandler.FromPointer); // 0270020E5608 0x50 FrameReady                  ( 0001866DF720 ModelClassType FrameReadyEventHandler FrameReadyEventHandler FrameReadyEventHandler Pointer )

            return value;
        }
    }
}
