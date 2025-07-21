using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               ModelClassType ProfilePIdolSelectGridViewCell ProfilePIdolSelectGridViewCell ProfilePIdolSelectGridViewCell Pointer
    // 098 EmptyView                                ModelClassType GameObject GameObject GameObject Pointer
    public partial class ProfilePIdolSelectGridView : DataModel
    {
        public ProfilePIdolSelectGridViewCell?          CellPrefab                              { get; set; }
        public GameObject?                              EmptyView                               { get; set; }

        public static ProfilePIdolSelectGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilePIdolSelectGridView() { Pointer= p0 };

            value.CellPrefab                                = GetObject<ProfilePIdolSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProfilePIdolSelectGridViewCell.FromPointer); // 0x90 CellPrefab                  ( ModelClassType ProfilePIdolSelectGridViewCell ProfilePIdolSelectGridViewCell ProfilePIdolSelectGridViewCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 EmptyView                   ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
