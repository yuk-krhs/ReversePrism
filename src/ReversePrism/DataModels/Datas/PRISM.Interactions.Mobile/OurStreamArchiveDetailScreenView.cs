using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FavoriteButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 028 CellView                                 ModelClassType OurStreamArchiveDetailCellView OurStreamArchiveDetailCellView OurStreamArchiveDetailCellView Pointer
    // 030 ScreenFader                              ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    public partial class OurStreamArchiveDetailScreenView : DataModel
    {
        public UIButton?                                FavoriteButton                          { get; set; }
        public OurStreamArchiveDetailCellView?          CellView                                { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }

        public static OurStreamArchiveDetailScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamArchiveDetailScreenView() { Pointer= p0 };

            value.FavoriteButton                            = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 FavoriteButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CellView                                  = GetObject<OurStreamArchiveDetailCellView>(new IntPtr(p + 0x028), ReversePrism.DataModels.OurStreamArchiveDetailCellView.FromPointer); // 0x28 CellView                    ( ModelClassType OurStreamArchiveDetailCellView OurStreamArchiveDetailCellView OurStreamArchiveDetailCellView Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x030), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0x30 ScreenFader                 ( ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )

            return value;
        }
    }
}
