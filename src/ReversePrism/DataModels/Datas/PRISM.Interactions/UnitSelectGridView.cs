using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               000186710AA0 ModelClassType UnitSelectGridViewCell UnitSelectGridViewCell UnitSelectGridViewCell Pointer
    // 098 EmptyView                                0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 tweenerCore                              TweenerCore`3<float, float, FloatOptions> IL2CPP_TYPE_GENERICINST
    public partial class UnitSelectGridView
    {
        public UnitSelectGridViewCell?                  CellPrefab                              { get; set; }
        public GameObject?                              EmptyView                               { get; set; }

        public static UnitSelectGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitSelectGridView();

            value.CellPrefab                                = GetObject<UnitSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.UnitSelectGridViewCell.FromPointer); // 0270DA399B00 0x90 CellPrefab                  ( 000186710AA0 ModelClassType UnitSelectGridViewCell UnitSelectGridViewCell UnitSelectGridViewCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA399B20 0x98 EmptyView                   ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
