using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PatentDeltaY                             float IL2CPP_TYPE_R4
    // 000 DoubleClickInterval                      float IL2CPP_TYPE_R4
    // 000 AbandonInterval                          float IL2CPP_TYPE_R4
    // 000 DefaultCameraPositionY                   float IL2CPP_TYPE_R4
    // 000 BaseFov                                  float IL2CPP_TYPE_R4
    // 000 TapTolerant                              float IL2CPP_TYPE_R4
    // 000 VoiceIntervalMin                         float IL2CPP_TYPE_R4
    // 000 VoiceIntervalMax                         float IL2CPP_TYPE_R4
    // 000 VoiceStartWaitTime                       float IL2CPP_TYPE_R4
    // 000 DressUpRoomScenarioName                  string IL2CPP_TYPE_STRING
    // 000 FittingRoomScenarioName                  string IL2CPP_TYPE_STRING
    // 000 VoiceCueSheetSuffix                      string IL2CPP_TYPE_STRING
    // 000 FittingRoomMotionStartTime               float IL2CPP_TYPE_R4
    public partial class DressUpRoomConst
    {

        public static DressUpRoomConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomConst();


            return value;
        }
    }
}
