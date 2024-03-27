using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 ImgItem                                  000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 TxtRequired                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtHave                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 GrayOutController                        0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 048 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 050 HavingProduct                            000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    public partial class RequiredItemIconView
    {
        public UIButton?                                Btn                                     { get; set; }
        public RawImage?                                ImgItem                                 { get; set; }
        public UITextMeshProUGUI?                       TxtRequired                             { get; set; }
        public UITextMeshProUGUI?                       TxtHave                                 { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public IHavingProductStatus?                    HavingProduct                           { get; set; }

        public static RequiredItemIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequiredItemIconView();

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA269B00 0x20 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgItem                                   = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0270DA269B20 0x28 ImgItem                     ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtRequired                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA269B40 0x30 TxtRequired                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtHave                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA269B60 0x38 TxtHave                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270DA269B80 0x40 GrayOutController           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270DA269BA0 0x48 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.HavingProduct                             = GetObject<IHavingProductStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0270DA269BC0 0x50 HavingProduct               ( 000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )

            return value;
        }
    }
}
