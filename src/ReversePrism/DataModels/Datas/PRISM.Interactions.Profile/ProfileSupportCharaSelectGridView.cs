using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               0001865C46C0 ModelClassType ProfileSupportCharaSelectGridViewCell ProfileSupportCharaSelectGridViewCell ProfileSupportCharaSelectGridViewCell Pointer
    // 098 EmptyView                                0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
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

            value.CellPrefab                                = GetObject<ProfileSupportCharaSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProfileSupportCharaSelectGridViewCell.FromPointer); // 02466B7BA618 0x90 CellPrefab                  ( 0001865C46C0 ModelClassType ProfileSupportCharaSelectGridViewCell ProfileSupportCharaSelectGridViewCell ProfileSupportCharaSelectGridViewCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 02466B7BA638 0x98 EmptyView                   ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
