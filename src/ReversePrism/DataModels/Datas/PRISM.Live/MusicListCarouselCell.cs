using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BeforeCenter                             float IL2CPP_TYPE_R4
    // 000 AfterCenter                              float IL2CPP_TYPE_R4
    // 038 CommonView                               000186667770 ModelClassType MusicListCellCommonView MusicListCellCommonView MusicListCellCommonView Pointer
    // 040 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 MusicData                                000186664B50 ModelClassType MusicData MusicData MusicData Pointer
    // 050 CellRectTransform                        000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 058 HalfCellHeight                           0001866656B0 ModelPrimitiveType float float float Single
    // 05C HalfContentHeight                        0001866656B0 ModelPrimitiveType float float float Single
    // 060 AwayFromCenterYOffset                    0001866656B0 ModelPrimitiveType float float float Single
    public partial class MusicListCarouselCell
    {
        public MusicListCellCommonView?                 CommonView                              { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public MusicData?                               MusicData                               { get; set; }
        public RectTransform?                           CellRectTransform                       { get; set; }
        public float                                    HalfCellHeight                          { get; set; }
        public float                                    HalfContentHeight                       { get; set; }
        public float                                    AwayFromCenterYOffset                   { get; set; }

        public static MusicListCarouselCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicListCarouselCell();

            value.CommonView                                = GetObject<MusicListCellCommonView>(new IntPtr(p + 0x038), ReversePrism.DataModels.MusicListCellCommonView.FromPointer); // 0270D517EEB8 0x38 CommonView                  ( 000186667770 ModelClassType MusicListCellCommonView MusicListCellCommonView MusicListCellCommonView Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D517EED8 0x40 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.MusicData                                 = GetObject<MusicData>(new IntPtr(p + 0x048), ReversePrism.DataModels.MusicData.FromPointer); // 0270D517EEF8 0x48 MusicData                   ( 000186664B50 ModelClassType MusicData MusicData MusicData Pointer )
            value.CellRectTransform                         = GetObject<RectTransform>(new IntPtr(p + 0x050), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D517EF18 0x50 CellRectTransform           ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.HalfCellHeight                            = GetSingle(new IntPtr(p + 0x058)); // 0270D517EF38 0x58 HalfCellHeight              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.HalfContentHeight                         = GetSingle(new IntPtr(p + 0x05C)); // 0270D517EF58 0x5C HalfContentHeight           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AwayFromCenterYOffset                     = GetSingle(new IntPtr(p + 0x060)); // 0270D517EF78 0x60 AwayFromCenterYOffset       ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
