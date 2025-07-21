using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Cells                                    ModelClassListType LiveEventAlbumCell[] LiveEventAlbumCell[] List<LiveEventAlbumCell> Pointer
    // 028 ExpandImage                              ModelClassType Image Image Image Pointer
    // 030 ExpandFinishButton                       ModelClassType Button Button Button Pointer
    // 038 BackButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 040 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 048 HowToPlayPopupOpener                     ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 050 EventId                                  ModelPrimitiveType int int int Int32
    // 058 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class LiveEventAlbumOverlayView : DataModel
    {
        public List<LiveEventAlbumCell>?                Cells                                   { get; set; }
        public Image?                                   ExpandImage                             { get; set; }
        public Button?                                  ExpandFinishButton                      { get; set; }
        public UIButton?                                BackButton                              { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }
        public int                                      EventId                                 { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static LiveEventAlbumOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventAlbumOverlayView() { Pointer= p0 };

            value.Cells                                     = GetObjectList<LiveEventAlbumCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveEventAlbumCell.FromPointer); // 0x20 Cells                       ( ModelClassListType LiveEventAlbumCell[] LiveEventAlbumCell[] List<LiveEventAlbumCell> Pointer )
            value.ExpandImage                               = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 ExpandImage                 ( ModelClassType Image Image Image Pointer )
            value.ExpandFinishButton                        = GetObject<Button>(new IntPtr(p + 0x030), ReversePrism.DataModels.Button.FromPointer); // 0x30 ExpandFinishButton          ( ModelClassType Button Button Button Pointer )
            value.BackButton                                = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 BackButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x040), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x40 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x048), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0x48 HowToPlayPopupOpener        ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x050)); // 0x50 EventId                     ( ModelPrimitiveType int int int Int32 )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0x58 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
