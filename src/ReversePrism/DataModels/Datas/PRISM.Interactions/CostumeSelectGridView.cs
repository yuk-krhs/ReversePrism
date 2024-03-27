using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               000186632570 ModelClassType CostumeSelectGridViewCell CostumeSelectGridViewCell CostumeSelectGridViewCell Pointer
    // 098 EmptyView                                0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    public partial class CostumeSelectGridView
    {
        public CostumeSelectGridViewCell?               CellPrefab                              { get; set; }
        public GameObject?                              EmptyView                               { get; set; }

        public static CostumeSelectGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeSelectGridView();

            value.CellPrefab                                = GetObject<CostumeSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.CostumeSelectGridViewCell.FromPointer); // 0270DA2A6B50 0x90 CellPrefab                  ( 000186632570 ModelClassType CostumeSelectGridViewCell CostumeSelectGridViewCell CostumeSelectGridViewCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA2A6B70 0x98 EmptyView                   ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
