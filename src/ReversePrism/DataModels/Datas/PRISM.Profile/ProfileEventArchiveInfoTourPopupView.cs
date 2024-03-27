using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               0001865B1330 ModelClassType ProfileEventArchiveInfoTourPopupViewCell ProfileEventArchiveInfoTourPopupViewCell ProfileEventArchiveInfoTourPopupViewCell Pointer
    // 098 EmptyView                                0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ProfileEventArchiveInfoTourPopupView
    {
        public ProfileEventArchiveInfoTourPopupViewCell? CellPrefab                              { get; set; }
        public GameObject?                              EmptyView                               { get; set; }

        public static ProfileEventArchiveInfoTourPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEventArchiveInfoTourPopupView();

            value.CellPrefab                                = GetObject<ProfileEventArchiveInfoTourPopupViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProfileEventArchiveInfoTourPopupViewCell.FromPointer); // 0270DB6E16E8 0x90 CellPrefab                  ( 0001865B1330 ModelClassType ProfileEventArchiveInfoTourPopupViewCell ProfileEventArchiveInfoTourPopupViewCell ProfileEventArchiveInfoTourPopupViewCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB6E1708 0x98 EmptyView                   ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
