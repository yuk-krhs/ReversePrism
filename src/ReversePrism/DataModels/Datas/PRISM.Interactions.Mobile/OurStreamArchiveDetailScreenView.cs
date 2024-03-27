using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FavoriteButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 CellView                                 0001866EF8F0 ModelClassType OurStreamArchiveDetailCellView OurStreamArchiveDetailCellView OurStreamArchiveDetailCellView Pointer
    // 030 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 038 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class OurStreamArchiveDetailScreenView
    {
        public UIButton?                                FavoriteButton                          { get; set; }
        public OurStreamArchiveDetailCellView?          CellView                                { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static OurStreamArchiveDetailScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamArchiveDetailScreenView();

            value.FavoriteButton                            = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB147320 0x20 FavoriteButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CellView                                  = GetObject<OurStreamArchiveDetailCellView>(new IntPtr(p + 0x028), ReversePrism.DataModels.OurStreamArchiveDetailCellView.FromPointer); // 0270DB147340 0x28 CellView                    ( 0001866EF8F0 ModelClassType OurStreamArchiveDetailCellView OurStreamArchiveDetailCellView OurStreamArchiveDetailCellView Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x030), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0270DB147360 0x30 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x038), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB147380 0x38 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
