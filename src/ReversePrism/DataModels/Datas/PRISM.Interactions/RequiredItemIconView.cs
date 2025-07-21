using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      ModelClassType UIButton UIButton UIButton Pointer
    // 028 ImgItem                                  ModelClassType RawImage RawImage RawImage Pointer
    // 030 TxtRequired                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtHave                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 048 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 050 HavingProduct                            ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    public partial class RequiredItemIconView : DataModel
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
            var value   = new RequiredItemIconView() { Pointer= p0 };

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Btn                         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgItem                                   = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 ImgItem                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtRequired                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtRequired                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtHave                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtHave                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x40 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x48 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.HavingProduct                             = GetObject<IHavingProductStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0x50 HavingProduct               ( ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )

            return value;
        }
    }
}
