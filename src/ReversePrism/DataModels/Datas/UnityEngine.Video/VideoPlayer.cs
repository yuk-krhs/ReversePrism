using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 PrepareCompleted                         ModelClassType EventHandler EventHandler EventHandler Pointer
    // 020 LoopPointReached                         ModelClassType EventHandler EventHandler EventHandler Pointer
    // 028 Started                                  ModelClassType EventHandler EventHandler EventHandler Pointer
    // 030 FrameDropped                             ModelClassType EventHandler EventHandler EventHandler Pointer
    // 038 ErrorReceived                            ModelClassType ErrorEventHandler ErrorEventHandler ErrorEventHandler Pointer
    // 040 SeekCompleted                            ModelClassType EventHandler EventHandler EventHandler Pointer
    // 048 ClockResyncOccurred                      ModelClassType TimeEventHandler TimeEventHandler TimeEventHandler Pointer
    // 050 FrameReady                               ModelClassType FrameReadyEventHandler FrameReadyEventHandler FrameReadyEventHandler Pointer
    public partial class VideoPlayer : DataModel
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
            var value   = new VideoPlayer() { Pointer= p0 };

            value.PrepareCompleted                          = GetObject<EventHandler>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventHandler.FromPointer); // 0x18 PrepareCompleted            ( ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.LoopPointReached                          = GetObject<EventHandler>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventHandler.FromPointer); // 0x20 LoopPointReached            ( ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.Started                                   = GetObject<EventHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.EventHandler.FromPointer); // 0x28 Started                     ( ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.FrameDropped                              = GetObject<EventHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.EventHandler.FromPointer); // 0x30 FrameDropped                ( ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.ErrorReceived                             = GetObject<ErrorEventHandler>(new IntPtr(p + 0x038), ReversePrism.DataModels.ErrorEventHandler.FromPointer); // 0x38 ErrorReceived               ( ModelClassType ErrorEventHandler ErrorEventHandler ErrorEventHandler Pointer )
            value.SeekCompleted                             = GetObject<EventHandler>(new IntPtr(p + 0x040), ReversePrism.DataModels.EventHandler.FromPointer); // 0x40 SeekCompleted               ( ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.ClockResyncOccurred                       = GetObject<TimeEventHandler>(new IntPtr(p + 0x048), ReversePrism.DataModels.TimeEventHandler.FromPointer); // 0x48 ClockResyncOccurred         ( ModelClassType TimeEventHandler TimeEventHandler TimeEventHandler Pointer )
            value.FrameReady                                = GetObject<FrameReadyEventHandler>(new IntPtr(p + 0x050), ReversePrism.DataModels.FrameReadyEventHandler.FromPointer); // 0x50 FrameReady                  ( ModelClassType FrameReadyEventHandler FrameReadyEventHandler FrameReadyEventHandler Pointer )

            return value;
        }
    }
}
