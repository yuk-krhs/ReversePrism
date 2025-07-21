using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               ModelClassType UnitSelectGridViewCell UnitSelectGridViewCell UnitSelectGridViewCell Pointer
    // 098 EmptyView                                ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 tweenerCore                              TweenerCore`3<float, float, FloatOptions> IL2CPP_TYPE_GENERICINST
    public partial class UnitSelectGridView : DataModel
    {
        public UnitSelectGridViewCell?                  CellPrefab                              { get; set; }
        public GameObject?                              EmptyView                               { get; set; }

        public static UnitSelectGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitSelectGridView() { Pointer= p0 };

            value.CellPrefab                                = GetObject<UnitSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.UnitSelectGridViewCell.FromPointer); // 0x90 CellPrefab                  ( ModelClassType UnitSelectGridViewCell UnitSelectGridViewCell UnitSelectGridViewCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 EmptyView                   ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
