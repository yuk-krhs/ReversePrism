using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum NoteType
    {
        None,
        Regular,
        Flick,
        SlideStart,
        SlideJoint,
        SlideEnd,
        Skill,
        Auto,
        SlideInvisible,
        Kime,
    }
}
