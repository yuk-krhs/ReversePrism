using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 Shifter                                  0001866F2990 ModelClassType UIShifter UIShifter UIShifter Pointer
    // 090 ShifterCells                             000185B844D0 ModelClassListType HomeBannerListViewCell[] HomeBannerListViewCell[] List<HomeBannerListViewCell> Pointer
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

            value.Shifter                                   = GetObject<UIShifter>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIShifter.FromPointer); // 0245A5AF1BB8 0x88 Shifter                     ( 0001866F2990 ModelClassType UIShifter UIShifter UIShifter Pointer )
            value.ShifterCells                              = GetObjectList<HomeBannerListViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.HomeBannerListViewCell.FromPointer); // 0245A5AF1BD8 0x90 ShifterCells                ( 000185B844D0 ModelClassListType HomeBannerListViewCell[] HomeBannerListViewCell[] List<HomeBannerListViewCell> Pointer )

            return value;
        }
    }
}
