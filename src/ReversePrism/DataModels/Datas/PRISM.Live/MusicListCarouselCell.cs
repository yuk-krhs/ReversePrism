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
    // 038 CommonView                               ModelClassType MusicListCellCommonView MusicListCellCommonView MusicListCellCommonView Pointer
    // 040 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 MusicData                                ModelClassType MusicData MusicData MusicData Pointer
    // 050 CellRectTransform                        ModelClassType RectTransform RectTransform RectTransform Pointer
    // 058 HalfCellHeight                           ModelPrimitiveType float float float Single
    // 05C HalfContentHeight                        ModelPrimitiveType float float float Single
    // 060 AwayFromCenterYOffset                    ModelPrimitiveType float float float Single
    public partial class MusicListCarouselCell : DataModel
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
            var value   = new MusicListCarouselCell() { Pointer= p0 };

            value.CommonView                                = GetObject<MusicListCellCommonView>(new IntPtr(p + 0x038), ReversePrism.DataModels.MusicListCellCommonView.FromPointer); // 0x38 CommonView                  ( ModelClassType MusicListCellCommonView MusicListCellCommonView MusicListCellCommonView Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x40 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.MusicData                                 = GetObject<MusicData>(new IntPtr(p + 0x048), ReversePrism.DataModels.MusicData.FromPointer); // 0x48 MusicData                   ( ModelClassType MusicData MusicData MusicData Pointer )
            value.CellRectTransform                         = GetObject<RectTransform>(new IntPtr(p + 0x050), ReversePrism.DataModels.RectTransform.FromPointer); // 0x50 CellRectTransform           ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.HalfCellHeight                            = GetSingle(new IntPtr(p + 0x058)); // 0x58 HalfCellHeight              ( ModelPrimitiveType float float float Single )
            value.HalfContentHeight                         = GetSingle(new IntPtr(p + 0x05C)); // 0x5C HalfContentHeight           ( ModelPrimitiveType float float float Single )
            value.AwayFromCenterYOffset                     = GetSingle(new IntPtr(p + 0x060)); // 0x60 AwayFromCenterYOffset       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
