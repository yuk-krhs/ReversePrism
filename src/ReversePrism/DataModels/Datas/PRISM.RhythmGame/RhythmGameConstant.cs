using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LaneCount                                int IL2CPP_TYPE_I4
    // 000 MaxSkillCount                            int IL2CPP_TYPE_I4
    // 000 LaneLength                               float IL2CPP_TYPE_R4
    // 000 MinObjectVisibleTimeRate                 float IL2CPP_TYPE_R4
    // 000 MaxObjectVisibleTimeRate                 float IL2CPP_TYPE_R4
    // 000 RESOURCE_TAG                             string IL2CPP_TYPE_STRING
    public partial class RhythmGameConstant : DataModel
    {

        public static RhythmGameConstant? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameConstant() { Pointer= p0 };


            return value;
        }
    }
}
