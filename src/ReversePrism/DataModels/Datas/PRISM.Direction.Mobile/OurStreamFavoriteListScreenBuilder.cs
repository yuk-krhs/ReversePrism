using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewPrefab                               0001866F3900 ModelClassType OurStreamFavoriteListScreenView OurStreamFavoriteListScreenView OurStreamFavoriteListScreenView Pointer
    // 028 ViewParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class OurStreamFavoriteListScreenBuilder : DataModel
    {
        public OurStreamFavoriteListScreenView?         ViewPrefab                              { get; set; }
        public Transform?                               ViewParent                              { get; set; }

        public static OurStreamFavoriteListScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamFavoriteListScreenBuilder() { Pointer= p0 };

            value.ViewPrefab                                = GetObject<OurStreamFavoriteListScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.OurStreamFavoriteListScreenView.FromPointer); // 02466B6D57C0 0x20 ViewPrefab                  ( 0001866F3900 ModelClassType OurStreamFavoriteListScreenView OurStreamFavoriteListScreenView OurStreamFavoriteListScreenView Pointer )
            value.ViewParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466B6D57E0 0x28 ViewParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
