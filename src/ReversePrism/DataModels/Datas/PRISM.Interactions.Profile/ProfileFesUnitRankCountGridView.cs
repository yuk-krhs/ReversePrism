using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               0001865B3F90 ModelClassType ProfileFesUnitRankCountGridViewCell ProfileFesUnitRankCountGridViewCell ProfileFesUnitRankCountGridViewCell Pointer
    public partial class ProfileFesUnitRankCountGridView
    {
        public ProfileFesUnitRankCountGridViewCell?     CellPrefab                              { get; set; }

        public static ProfileFesUnitRankCountGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFesUnitRankCountGridView();

            value.CellPrefab                                = GetObject<ProfileFesUnitRankCountGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProfileFesUnitRankCountGridViewCell.FromPointer); // 0270DB712A78 0x90 CellPrefab                  ( 0001865B3F90 ModelClassType ProfileFesUnitRankCountGridViewCell ProfileFesUnitRankCountGridViewCell ProfileFesUnitRankCountGridViewCell Pointer )

            return value;
        }
    }
}
