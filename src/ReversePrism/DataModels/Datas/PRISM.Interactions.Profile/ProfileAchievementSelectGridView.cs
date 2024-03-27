using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               0001865A7BA0 ModelClassType ProfileAchievementSelectGridViewCell ProfileAchievementSelectGridViewCell ProfileAchievementSelectGridViewCell Pointer
    // 098 EmptyView                                0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ProfileAchievementSelectGridView
    {
        public ProfileAchievementSelectGridViewCell?    CellPrefab                              { get; set; }
        public GameObject?                              EmptyView                               { get; set; }

        public static ProfileAchievementSelectGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileAchievementSelectGridView();

            value.CellPrefab                                = GetObject<ProfileAchievementSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProfileAchievementSelectGridViewCell.FromPointer); // 0270DB702768 0x90 CellPrefab                  ( 0001865A7BA0 ModelClassType ProfileAchievementSelectGridViewCell ProfileAchievementSelectGridViewCell ProfileAchievementSelectGridViewCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB702788 0x98 EmptyView                   ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
