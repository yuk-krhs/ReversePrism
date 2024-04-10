using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               000186587770 ModelClassType ProduceSupportCharaSelectGridViewCell ProduceSupportCharaSelectGridViewCell ProduceSupportCharaSelectGridViewCell Pointer
    // 098 EmptyView                                0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ProduceSupportCharaSelectGridView : DataModel
    {
        public ProduceSupportCharaSelectGridViewCell?   CellPrefab                              { get; set; }
        public GameObject?                              EmptyView                               { get; set; }

        public static ProduceSupportCharaSelectGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSupportCharaSelectGridView() { Pointer= p0 };

            value.CellPrefab                                = GetObject<ProduceSupportCharaSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceSupportCharaSelectGridViewCell.FromPointer); // 02466A17C4D0 0x90 CellPrefab                  ( 000186587770 ModelClassType ProduceSupportCharaSelectGridViewCell ProduceSupportCharaSelectGridViewCell ProduceSupportCharaSelectGridViewCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 02466A17C4F0 0x98 EmptyView                   ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
