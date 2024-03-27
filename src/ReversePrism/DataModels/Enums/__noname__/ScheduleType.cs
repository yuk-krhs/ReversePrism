using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ScheduleType
    {
        None,
        VocalLesson,
        DanceLesson,
        VisualLesson,
        SpecialLesson,
        Working,
        Training,
        Rest,
        Advice,
        Outing,
        Shopping,
        Audition,
        MiniLive,
        TalkShow,
        Num,
    }
}
