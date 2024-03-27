using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               0001865BB970 ModelClassType ProfilePIdolSelectGridViewCell ProfilePIdolSelectGridViewCell ProfilePIdolSelectGridViewCell Pointer
    // 098 EmptyView                                0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ProfilePIdolSelectGridView
    {
        public ProfilePIdolSelectGridViewCell?          CellPrefab                              { get; set; }
        public GameObject?                              EmptyView                               { get; set; }

        public static ProfilePIdolSelectGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilePIdolSelectGridView();

            value.CellPrefab                                = GetObject<ProfilePIdolSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProfilePIdolSelectGridViewCell.FromPointer); // 0270DB719A80 0x90 CellPrefab                  ( 0001865BB970 ModelClassType ProfilePIdolSelectGridViewCell ProfilePIdolSelectGridViewCell ProfilePIdolSelectGridViewCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB719AA0 0x98 EmptyView                   ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
