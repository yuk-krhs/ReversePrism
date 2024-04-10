using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               00018655ACD0 ModelClassType FavoriteIconSelectGridViewCell FavoriteIconSelectGridViewCell FavoriteIconSelectGridViewCell Pointer
    // 098 EmptyView                                0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    public partial class FavoriteIconSelectGridView : DataModel
    {
        public FavoriteIconSelectGridViewCell?          CellPrefab                              { get; set; }
        public GameObject?                              EmptyView                               { get; set; }

        public static FavoriteIconSelectGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FavoriteIconSelectGridView() { Pointer= p0 };

            value.CellPrefab                                = GetObject<FavoriteIconSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.FavoriteIconSelectGridViewCell.FromPointer); // 02466A39C028 0x90 CellPrefab                  ( 00018655ACD0 ModelClassType FavoriteIconSelectGridViewCell FavoriteIconSelectGridViewCell FavoriteIconSelectGridViewCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 02466A39C048 0x98 EmptyView                   ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
