using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CgTotalCount                             ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 CgSelectedFavorites                      ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 CgSelectedTransfers                      ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 ImgFavoriteIcon                          ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 040 TxtTotalCount                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtSelectedFavorites                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtTransferLimits                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtSelectedTransfers                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 BtnRight                                 ModelClassType UIButton UIButton UIButton Pointer
    // 068 BtnLeftBlue                              ModelClassType UIButton UIButton UIButton Pointer
    // 070 BtnLeftCancel                            ModelClassType UIButton UIButton UIButton Pointer
    // 078 TxtBtnRight                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 onChangeType                             Subject`1<IdolListFooterType> IL2CPP_TYPE_GENERICINST
    // 088 setAsFavorite                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 transferSelected                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 098 CurrentType                              ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32
    // 09C Limit                                    ModelPrimitiveType int int int Int32
    public partial class FavoriteTransferFooterView : DataModel
    {
        public CanvasGroup?                             CgTotalCount                            { get; set; }
        public CanvasGroup?                             CgSelectedFavorites                     { get; set; }
        public CanvasGroup?                             CgSelectedTransfers                     { get; set; }
        public UIRawImage?                              ImgFavoriteIcon                         { get; set; }
        public UITextMeshProUGUI?                       TxtTotalCount                           { get; set; }
        public UITextMeshProUGUI?                       TxtSelectedFavorites                    { get; set; }
        public UITextMeshProUGUI?                       TxtTransferLimits                       { get; set; }
        public UITextMeshProUGUI?                       TxtSelectedTransfers                    { get; set; }
        public UIButton?                                BtnRight                                { get; set; }
        public UIButton?                                BtnLeftBlue                             { get; set; }
        public UIButton?                                BtnLeftCancel                           { get; set; }
        public UITextMeshProUGUI?                       TxtBtnRight                             { get; set; }
        public IdolListFooterType                       CurrentType                             { get; set; }
        public int                                      Limit                                   { get; set; }

        public static FavoriteTransferFooterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FavoriteTransferFooterView() { Pointer= p0 };

            value.CgTotalCount                              = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CgTotalCount                ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgSelectedFavorites                       = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CgSelectedFavorites         ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgSelectedTransfers                       = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x30 CgSelectedTransfers         ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgFavoriteIcon                           = GetObject<UIRawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x38 ImgFavoriteIcon             ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TxtTotalCount                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtTotalCount               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSelectedFavorites                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtSelectedFavorites        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTransferLimits                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtTransferLimits           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSelectedTransfers                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtSelectedTransfers        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnRight                                  = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 BtnRight                    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnLeftBlue                               = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 BtnLeftBlue                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnLeftCancel                             = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 BtnLeftCancel               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtBtnRight                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 TxtBtnRight                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CurrentType                               = (IdolListFooterType)GetInt32(new IntPtr(p + 0x098)); // 0x98 CurrentType                 ( ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32 )
            value.Limit                                     = GetInt32(new IntPtr(p + 0x09C)); // 0x9C Limit                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
