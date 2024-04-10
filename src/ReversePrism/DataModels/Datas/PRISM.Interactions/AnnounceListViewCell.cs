using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ImgCategory                              0001866CCDB0 ModelClassType Image Image Image Pointer
    // 068 TxtCategory                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TxtTime                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 GoIsNew                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 TxtUpdateTime                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 TxtUpdateName                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 ImgBanner                                000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 098 TxtTitle                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 BtnMain                                  000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0A8 BtnMore                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0B0 NormalCellObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 0C0 Data                                     0001866C0470 ModelClassType AnnounceListItemViewModel AnnounceListItemViewModel AnnounceListItemViewModel Pointer
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

            value.ImgCategory                               = GetObject<Image>(new IntPtr(p + 0x060), ReversePrism.DataModels.Image.FromPointer); // 02466BE61C60 0x60 ImgCategory                 ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.TxtCategory                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BE61C80 0x68 TxtCategory                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTime                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BE61CA0 0x70 TxtTime                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoIsNew                                   = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 02466BE61CC0 0x78 GoIsNew                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtUpdateTime                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BE61CE0 0x80 TxtUpdateTime               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtUpdateName                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BE61D00 0x88 TxtUpdateName               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgBanner                                 = GetObject<RawImage>(new IntPtr(p + 0x090), ReversePrism.DataModels.RawImage.FromPointer); // 02466BE61D20 0x90 ImgBanner                   ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtTitle                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BE61D40 0x98 TxtTitle                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnMain                                   = GetObject<ButtonBase>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466BE61D60 0xA0 BtnMain                     ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnMore                                   = GetObject<UIButton>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UIButton.FromPointer); // 02466BE61D80 0xA8 BtnMore                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.NormalCellObject                          = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 02466BE61DA0 0xB0 NormalCellObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 02466BE61DC0 0xB8 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Data                                      = GetObject<AnnounceListItemViewModel>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.AnnounceListItemViewModel.FromPointer); // 02466BE61DE0 0xC0 Data                        ( 0001866C0470 ModelClassType AnnounceListItemViewModel AnnounceListItemViewModel AnnounceListItemViewModel Pointer )

            return value;
        }
    }
}
