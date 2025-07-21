using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 IconViews                                ModelClassListType FUnitIconView[] FUnitIconView[] List<FUnitIconView> Pointer
    public partial class EnhancedUnitSelectGridCellView : DataModel
    {
        public List<FUnitIconView>?                     IconViews                               { get; set; }

        public static EnhancedUnitSelectGridCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnhancedUnitSelectGridCellView() { Pointer= p0 };

            value.IconViews                                 = GetObjectList<FUnitIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0x38 IconViews                   ( ModelClassListType FUnitIconView[] FUnitIconView[] List<FUnitIconView> Pointer )

            return value;
        }
    }
}
