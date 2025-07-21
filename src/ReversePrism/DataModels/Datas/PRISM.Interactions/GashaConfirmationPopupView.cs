using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtMsgTop                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtCaution                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtPaidBefore                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtPaidAfter                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtFreeBefore                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtFreeAfter                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtTokenBefore                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtTokenAfter                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 TxtExChangePointBefore                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TxtExChangePointAfter                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 GoPaid                                   ModelClassType GameObject GameObject GameObject Pointer
    // 078 GoFree                                   ModelClassType GameObject GameObject GameObject Pointer
    // 080 GoExChangePoint                          ModelClassType GameObject GameObject GameObject Pointer
    // 088 GoToken                                  ModelClassType GameObject GameObject GameObject Pointer
    // 090 ImgToken                                 ModelClassType RawImage RawImage RawImage Pointer
    // 098 TxtTokutei                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 BtnTokutei                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0A8 GashaName                                ModelPrimitiveType string string string String
    // 0B0 Ps                                       ModelClassType ProductService ProductService ProductService Pointer
    // 0B8 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 0C0 closeTask                                UniTaskCompletionSource`1<CloseType> IL2CPP_TYPE_GENERICINST
    // 0C8 IsRetry                                  ModelPrimitiveType bool bool bool Bool
    // 0C9 IsShortageJewel                          ModelPrimitiveType bool bool bool Bool
    // 0D0 GashaPrice                               ModelClassType IGashaPriceStatus IGashaPriceStatus IGashaPriceStatus Pointer
    // 0D8 Gasha                                    ModelClassType Gasha Gasha Gasha Pointer
    // 0E0 onCloseShopProcessingEvent               Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    // 0E8 onClosed                                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 0F0 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaConfirmationPopupView : DataModel
    {
        public UITextMeshProUGUI?                       TxtMsgTop                               { get; set; }
        public UITextMeshProUGUI?                       TxtCaution                              { get; set; }
        public UITextMeshProUGUI?                       TxtPaidBefore                           { get; set; }
        public UITextMeshProUGUI?                       TxtPaidAfter                            { get; set; }
        public UITextMeshProUGUI?                       TxtFreeBefore                           { get; set; }
        public UITextMeshProUGUI?                       TxtFreeAfter                            { get; set; }
        public UITextMeshProUGUI?                       TxtTokenBefore                          { get; set; }
        public UITextMeshProUGUI?                       TxtTokenAfter                           { get; set; }
        public UITextMeshProUGUI?                       TxtExChangePointBefore                  { get; set; }
        public UITextMeshProUGUI?                       TxtExChangePointAfter                   { get; set; }
        public GameObject?                              GoPaid                                  { get; set; }
        public GameObject?                              GoFree                                  { get; set; }
        public GameObject?                              GoExChangePoint                         { get; set; }
        public GameObject?                              GoToken                                 { get; set; }
        public RawImage?                                ImgToken                                { get; set; }
        public UITextMeshProUGUI?                       TxtTokutei                              { get; set; }
        public ButtonBase?                              BtnTokutei                              { get; set; }
        public string                                   GashaName                               { get; set; }
        public ProductService?                          Ps                                      { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public bool                                     IsRetry                                 { get; set; }
        public bool                                     IsShortageJewel                         { get; set; }
        public IGashaPriceStatus?                       GashaPrice                              { get; set; }
        public Gasha?                                   Gasha                                   { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaConfirmationPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaConfirmationPopupView() { Pointer= p0 };

            value.TxtMsgTop                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtMsgTop                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCaution                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtCaution                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPaidBefore                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtPaidBefore               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPaidAfter                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtPaidAfter                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFreeBefore                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtFreeBefore               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFreeAfter                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtFreeAfter                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTokenBefore                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtTokenBefore              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTokenAfter                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtTokenAfter               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExChangePointBefore                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TxtExChangePointBefore      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExChangePointAfter                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 TxtExChangePointAfter       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoPaid                                    = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 GoPaid                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoFree                                    = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 GoFree                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoExChangePoint                           = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 GoExChangePoint             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoToken                                   = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 GoToken                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgToken                                  = GetObject<RawImage>(new IntPtr(p + 0x090), ReversePrism.DataModels.RawImage.FromPointer); // 0x90 ImgToken                    ( ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtTokutei                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 TxtTokutei                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnTokutei                                = GetObject<ButtonBase>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xA0 BtnTokutei                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GashaName                                 = GetString(new IntPtr(p + 0x0A8)); // 0xA8 GashaName                   ( ModelPrimitiveType string string string String )
            value.Ps                                        = GetObject<ProductService>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ProductService.FromPointer); // 0xB0 Ps                          ( ModelClassType ProductService ProductService ProductService Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0xB8 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.IsRetry                                   = GetBool(new IntPtr(p + 0x0C8)); // 0xC8 IsRetry                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsShortageJewel                           = GetBool(new IntPtr(p + 0x0C9)); // 0xC9 IsShortageJewel             ( ModelPrimitiveType bool bool bool Bool )
            value.GashaPrice                                = GetObject<IGashaPriceStatus>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IGashaPriceStatus.FromPointer); // 0xD0 GashaPrice                  ( ModelClassType IGashaPriceStatus IGashaPriceStatus IGashaPriceStatus Pointer )
            value.Gasha                                     = GetObject<Gasha>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Gasha.FromPointer); // 0xD8 Gasha                       ( ModelClassType Gasha Gasha Gasha Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0xF0 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
