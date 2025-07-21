using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ImgCategory                              ModelClassType Image Image Image Pointer
    // 068 TxtCategory                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TxtTime                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 GoIsNew                                  ModelClassType GameObject GameObject GameObject Pointer
    // 080 TxtUpdateTime                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 TxtUpdateName                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 ImgBanner                                ModelClassType RawImage RawImage RawImage Pointer
    // 098 TxtTitle                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 BtnMain                                  ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0A8 BtnMore                                  ModelClassType UIButton UIButton UIButton Pointer
    // 0B0 NormalCellObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 0C0 Data                                     ModelClassType AnnounceListItemViewModel AnnounceListItemViewModel AnnounceListItemViewModel Pointer
    // 000 bannerKeyList                            IReadOnlyDictionary`2<AnnounceCategory, string> IL2CPP_TYPE_GENERICINST
    public partial class AnnounceListViewCell : DataModel
    {
        public Image?                                   ImgCategory                             { get; set; }
        public UITextMeshProUGUI?                       TxtCategory                             { get; set; }
        public UITextMeshProUGUI?                       TxtTime                                 { get; set; }
        public GameObject?                              GoIsNew                                 { get; set; }
        public UITextMeshProUGUI?                       TxtUpdateTime                           { get; set; }
        public UITextMeshProUGUI?                       TxtUpdateName                           { get; set; }
        public RawImage?                                ImgBanner                               { get; set; }
        public UITextMeshProUGUI?                       TxtTitle                                { get; set; }
        public ButtonBase?                              BtnMain                                 { get; set; }
        public UIButton?                                BtnMore                                 { get; set; }
        public GameObject?                              NormalCellObject                        { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public AnnounceListItemViewModel?               Data                                    { get; set; }

        public static AnnounceListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceListViewCell() { Pointer= p0 };

            value.ImgCategory                               = GetObject<Image>(new IntPtr(p + 0x060), ReversePrism.DataModels.Image.FromPointer); // 0x60 ImgCategory                 ( ModelClassType Image Image Image Pointer )
            value.TxtCategory                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 TxtCategory                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTime                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 TxtTime                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoIsNew                                   = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 GoIsNew                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtUpdateTime                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 TxtUpdateTime               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtUpdateName                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 TxtUpdateName               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgBanner                                 = GetObject<RawImage>(new IntPtr(p + 0x090), ReversePrism.DataModels.RawImage.FromPointer); // 0x90 ImgBanner                   ( ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtTitle                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 TxtTitle                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnMain                                   = GetObject<ButtonBase>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xA0 BtnMain                     ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnMore                                   = GetObject<UIButton>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UIButton.FromPointer); // 0xA8 BtnMore                     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.NormalCellObject                          = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 0xB0 NormalCellObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0xB8 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Data                                      = GetObject<AnnounceListItemViewModel>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.AnnounceListItemViewModel.FromPointer); // 0xC0 Data                        ( ModelClassType AnnounceListItemViewModel AnnounceListItemViewModel AnnounceListItemViewModel Pointer )

            return value;
        }
    }
}
