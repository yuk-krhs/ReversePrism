using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 Shifter                                  ModelClassType UIShifter UIShifter UIShifter Pointer
    // 080 ShifterCells                             ModelClassListType HomeBannerListViewCell[] HomeBannerListViewCell[] List<HomeBannerListViewCell> Pointer
    public partial class HomeBannerView : DataModel
    {
        public UIShifter?                               Shifter                                 { get; set; }
        public List<HomeBannerListViewCell>?            ShifterCells                            { get; set; }

        public static HomeBannerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeBannerView() { Pointer= p0 };

            value.Shifter                                   = GetObject<UIShifter>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIShifter.FromPointer); // 0x78 Shifter                     ( ModelClassType UIShifter UIShifter UIShifter Pointer )
            value.ShifterCells                              = GetObjectList<HomeBannerListViewCell>(new IntPtr(p + 0x080), ReversePrism.DataModels.HomeBannerListViewCell.FromPointer); // 0x80 ShifterCells                ( ModelClassListType HomeBannerListViewCell[] HomeBannerListViewCell[] List<HomeBannerListViewCell> Pointer )

            return value;
        }
    }
}
