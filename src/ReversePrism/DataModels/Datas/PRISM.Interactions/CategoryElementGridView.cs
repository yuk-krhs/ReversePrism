using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 categoryCellPrefab                       FancyGridViewCell`2<ICategoryElementGridCellViewModel, CategoryElementGridContext> IL2CPP_TYPE_GENERICINST
    // 098 elementCellPrefab                        FancyGridViewCell`2<ICategoryElementGridCellViewModel, CategoryElementGridContext> IL2CPP_TYPE_GENERICINST
    // 0A0 EmptyView                                ModelClassType GameObject GameObject GameObject Pointer
    public partial class CategoryElementGridView : DataModel
    {
        public GameObject?                              EmptyView                               { get; set; }

        public static CategoryElementGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CategoryElementGridView() { Pointer= p0 };

            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 EmptyView                   ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
