using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 IconViews                                ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer
    public partial class EnhancedPIdolSelectGridCellView : DataModel
    {
        public List<PFIdolIconView>?                    IconViews                               { get; set; }

        public static EnhancedPIdolSelectGridCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnhancedPIdolSelectGridCellView() { Pointer= p0 };

            value.IconViews                                 = GetObjectList<PFIdolIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x38 IconViews                   ( ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer )

            return value;
        }
    }
}
