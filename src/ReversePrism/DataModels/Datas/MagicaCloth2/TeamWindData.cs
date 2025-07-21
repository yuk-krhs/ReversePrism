using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 windZoneList                             FixedList128Bytes`1<TeamWindInfo> IL2CPP_TYPE_GENERICINST
    // 090 MovingWind                               ModelEnumType TeamWindInfo TeamWindInfo TeamWindInfo Int32
    public partial class TeamWindData : DataModel
    {
        public TeamWindInfo                             MovingWind                              { get; set; }

        public static TeamWindData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TeamWindData() { Pointer= p0 };

            value.MovingWind                                = (TeamWindInfo)GetInt32(new IntPtr(p + 0x090)); // 0x90 MovingWind                  ( ModelEnumType TeamWindInfo TeamWindInfo TeamWindInfo Int32 )

            return value;
        }
    }
}
