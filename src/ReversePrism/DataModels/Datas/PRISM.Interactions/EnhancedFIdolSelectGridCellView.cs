using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 IconViews                                000185B99CC0 ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer
    public partial class EnhancedFIdolSelectGridCellView
    {
        public List<PFIdolIconView>?                    IconViews                               { get; set; }

        public static EnhancedFIdolSelectGridCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnhancedFIdolSelectGridCellView();

            value.IconViews                                 = GetObjectList<PFIdolIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270DA237610 0x38 IconViews                   ( 000185B99CC0 ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer )

            return value;
        }
    }
}
