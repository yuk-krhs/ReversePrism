using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               000186635220 ModelClassType CostumeSetSelectGridViewCell CostumeSetSelectGridViewCell CostumeSetSelectGridViewCell Pointer
    // 098 EmptyView                                0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    public partial class CostumeSetSelectGridView
    {
        public CostumeSetSelectGridViewCell?            CellPrefab                              { get; set; }
        public GameObject?                              EmptyView                               { get; set; }

        public static CostumeSetSelectGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeSetSelectGridView();

            value.CellPrefab                                = GetObject<CostumeSetSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.CostumeSetSelectGridViewCell.FromPointer); // 0270DA2A02F8 0x90 CellPrefab                  ( 000186635220 ModelClassType CostumeSetSelectGridViewCell CostumeSetSelectGridViewCell CostumeSetSelectGridViewCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA2A0318 0x98 EmptyView                   ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
