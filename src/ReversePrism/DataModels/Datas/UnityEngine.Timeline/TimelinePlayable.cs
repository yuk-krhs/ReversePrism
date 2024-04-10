using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_IntervalTree                           IntervalTree`1<RuntimeElement> IL2CPP_TYPE_GENERICINST
    // 018 M_ActiveClips                            000185D048E8 ModelClassListType List`1<RuntimeElement> List`1<RuntimeElement> List<RuntimeElement> Pointer
    // 020 M_CurrentListOfActiveClips               000185D048E8 ModelClassListType List`1<RuntimeElement> List`1<RuntimeElement> List<RuntimeElement> Pointer
    // 028 M_ActiveBit                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 M_EvaluateCallbacks                      000185CE95E8 ModelClassListType List`1<ITimelineEvaluateCallback> List`1<ITimelineEvaluateCallback> List<ITimelineEvaluateCallback> Pointer
    // 038 m_PlayableCache                          Dictionary`2<TrackAsset, Playable> IL2CPP_TYPE_GENERICINST
    // 000 muteAudioScrubbing                       bool IL2CPP_TYPE_BOOLEAN
    public partial class TimelinePlayable : DataModel
    {
        public List<RuntimeElement>?                    M_ActiveClips                           { get; set; }
        public List<RuntimeElement>?                    M_CurrentListOfActiveClips              { get; set; }
        public int                                      M_ActiveBit                             { get; set; }
        public List<ITimelineEvaluateCallback>?         M_EvaluateCallbacks                     { get; set; }

        public static TimelinePlayable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimelinePlayable() { Pointer= p0 };

            value.M_ActiveClips                             = GetObjectList<RuntimeElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.RuntimeElement.FromPointer); // 02466B3115C8 0x18 M_ActiveClips               ( 000185D048E8 ModelClassListType List`1<RuntimeElement> List`1<RuntimeElement> List<RuntimeElement> Pointer )
            value.M_CurrentListOfActiveClips                = GetObjectList<RuntimeElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.RuntimeElement.FromPointer); // 02466B3115E8 0x20 M_CurrentListOfActiveClips  ( 000185D048E8 ModelClassListType List`1<RuntimeElement> List`1<RuntimeElement> List<RuntimeElement> Pointer )
            value.M_ActiveBit                               = GetInt32(new IntPtr(p + 0x028)); // 02466B311608 0x28 M_ActiveBit                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_EvaluateCallbacks                       = GetObjectList<ITimelineEvaluateCallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.ITimelineEvaluateCallback.FromPointer); // 02466B311628 0x30 M_EvaluateCallbacks         ( 000185CE95E8 ModelClassListType List`1<ITimelineEvaluateCallback> List`1<ITimelineEvaluateCallback> List<ITimelineEvaluateCallback> Pointer )

            return value;
        }
    }
}
