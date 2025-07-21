using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 IconViews                                ModelClassListType PieceIconView[] PieceIconView[] List<PieceIconView> Pointer
    public partial class EnhancedPieceSelectGridCellView : DataModel
    {
        public List<PieceIconView>?                     IconViews                               { get; set; }

        public static EnhancedPieceSelectGridCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnhancedPieceSelectGridCellView() { Pointer= p0 };

            value.IconViews                                 = GetObjectList<PieceIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PieceIconView.FromPointer); // 0x38 IconViews                   ( ModelClassListType PieceIconView[] PieceIconView[] List<PieceIconView> Pointer )

            return value;
        }
    }
}
