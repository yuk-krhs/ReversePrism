using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 IconViews                                000185CA2828 ModelClassListType SCharaIconRectView[] SCharaIconRectView[] List<SCharaIconRectView> Pointer
    public partial class EnhancedSCharaSelectGridCellView : DataModel
    {
        public List<SCharaIconRectView>?                IconViews                               { get; set; }

        public static EnhancedSCharaSelectGridCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnhancedSCharaSelectGridCellView() { Pointer= p0 };

            value.IconViews                                 = GetObjectList<SCharaIconRectView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 02466A2AD2E8 0x38 IconViews                   ( 000185CA2828 ModelClassListType SCharaIconRectView[] SCharaIconRectView[] List<SCharaIconRectView> Pointer )

            return value;
        }
    }
}
