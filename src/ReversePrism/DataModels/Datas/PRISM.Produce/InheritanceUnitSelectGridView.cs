using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               0001866F0270 ModelClassType InheritanceUnitSelectGridViewCell InheritanceUnitSelectGridViewCell InheritanceUnitSelectGridViewCell Pointer
    // 098 EmptyView                                0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    public partial class InheritanceUnitSelectGridView
    {
        public InheritanceUnitSelectGridViewCell?       CellPrefab                              { get; set; }
        public GameObject?                              EmptyView                               { get; set; }

        public static InheritanceUnitSelectGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InheritanceUnitSelectGridView();

            value.CellPrefab                                = GetObject<InheritanceUnitSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.InheritanceUnitSelectGridViewCell.FromPointer); // 0270D59A8210 0x90 CellPrefab                  ( 0001866F0270 ModelClassType InheritanceUnitSelectGridViewCell InheritanceUnitSelectGridViewCell InheritanceUnitSelectGridViewCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0270D59A8230 0x98 EmptyView                   ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
