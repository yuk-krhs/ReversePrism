using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CgTotalCount                             000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 CgSelectedFavorites                      000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 CgSelectedTransfers                      000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 ImgFavoriteIcon                          0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 040 TxtTotalCount                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtSelectedFavorites                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtTransferLimits                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtSelectedTransfers                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 BtnRight                                 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 BtnLeftBlue                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 BtnLeftCancel                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 TxtBtnRight                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 onChangeType                             Subject`1<IdolListFooterType> IL2CPP_TYPE_GENERICINST
    // 088 setAsFavorite                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 transferSelected                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 098 CurrentType                              0001866B2B20 ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32
    // 09C Limit                                    0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.CgTotalCount                              = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A2C2B68 0x20 CgTotalCount                ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgSelectedFavorites                       = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A2C2B88 0x28 CgSelectedFavorites         ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgSelectedTransfers                       = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A2C2BA8 0x30 CgSelectedTransfers         ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgFavoriteIcon                           = GetObject<UIRawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A2C2BC8 0x38 ImgFavoriteIcon             ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TxtTotalCount                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2C2BE8 0x40 TxtTotalCount               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSelectedFavorites                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2C2C08 0x48 TxtSelectedFavorites        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTransferLimits                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2C2C28 0x50 TxtTransferLimits           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSelectedTransfers                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2C2C48 0x58 TxtSelectedTransfers        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnRight                                  = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 02466A2C2C68 0x60 BtnRight                    ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnLeftBlue                               = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 02466A2C2C88 0x68 BtnLeftBlue                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnLeftCancel                             = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 02466A2C2CA8 0x70 BtnLeftCancel               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtBtnRight                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2C2CC8 0x78 TxtBtnRight                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CurrentType                               = (IdolListFooterType)GetInt32(new IntPtr(p + 0x098)); // 02466A2C2D48 0x98 CurrentType                 ( 0001866B2B20 ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32 )
            value.Limit                                     = GetInt32(new IntPtr(p + 0x09C)); // 02466A2C2D68 0x9C Limit                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
