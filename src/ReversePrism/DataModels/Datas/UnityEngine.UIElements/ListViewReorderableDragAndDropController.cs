using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 M_ListView                               ModelClassType BaseListView BaseListView BaseListView Pointer
    public partial class ListViewReorderableDragAndDropController : DataModel
    {
        public BaseListView?                            M_ListView                              { get; set; }

        public static ListViewReorderableDragAndDropController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListViewReorderableDragAndDropController() { Pointer= p0 };

            value.M_ListView                                = GetObject<BaseListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.BaseListView.FromPointer); // 0x28 M_ListView                  ( ModelClassType BaseListView BaseListView BaseListView Pointer )

            return value;
        }
    }
}
