using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 FavoriteIconView                         00018655B1C0 ModelClassType FavoriteIconView FavoriteIconView FavoriteIconView Pointer
    public partial class FavoriteIconSelectGridViewCell : DataModel
    {
        public FavoriteIconView?                        FavoriteIconView                        { get; set; }

        public static FavoriteIconSelectGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FavoriteIconSelectGridViewCell() { Pointer= p0 };

            value.FavoriteIconView                          = GetObject<FavoriteIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FavoriteIconView.FromPointer); // 02466A39C1F8 0x30 FavoriteIconView            ( 00018655B1C0 ModelClassType FavoriteIconView FavoriteIconView FavoriteIconView Pointer )

            return value;
        }
    }
}
