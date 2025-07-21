using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               ModelClassType ProfileSupportCharaSelectGridViewCell ProfileSupportCharaSelectGridViewCell ProfileSupportCharaSelectGridViewCell Pointer
    // 098 EmptyView                                ModelClassType GameObject GameObject GameObject Pointer
    public partial class ProfileSupportCharaSelectGridView : DataModel
    {
        public ProfileSupportCharaSelectGridViewCell?   CellPrefab                              { get; set; }
        public GameObject?                              EmptyView                               { get; set; }

        public static ProfileSupportCharaSelectGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileSupportCharaSelectGridView() { Pointer= p0 };

            value.CellPrefab                                = GetObject<ProfileSupportCharaSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProfileSupportCharaSelectGridViewCell.FromPointer); // 0x90 CellPrefab                  ( ModelClassType ProfileSupportCharaSelectGridViewCell ProfileSupportCharaSelectGridViewCell ProfileSupportCharaSelectGridViewCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 EmptyView                   ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
