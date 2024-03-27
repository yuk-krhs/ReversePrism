using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgBg                                    0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 TxtPartyName                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 BtnEditPartyName                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 TxtCost                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BtnSCharaEdit                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 BtnSCahra                                000185CADC58 ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer
    // 050 UnitVoDaViMeRankView                     000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 058 SCharaIconViews                          000185CA2A68 ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer
    // 060 IndicatorOriginal                        000186682710 ModelClassType Toggle Toggle Toggle Pointer
    // 068 onPartyEdit                              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 onSCharaIcon                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 078 onLongPressSChara                        Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 080 IndicatorList                            000185D15058 ModelClassListType List`1<Toggle> List`1<Toggle> List<Toggle> Pointer
    // 088 SetSCharaId                              000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class ProduceUnitEditFooterView
    {
        public Image?                                   ImgBg                                   { get; set; }
        public UITextMeshProUGUI?                       TxtPartyName                            { get; set; }
        public UIButton?                                BtnEditPartyName                        { get; set; }
        public UITextMeshProUGUI?                       TxtCost                                 { get; set; }
        public UIButton?                                BtnSCharaEdit                           { get; set; }
        public List<UIButton>?                          BtnSCahra                               { get; set; }
        public VoDaViMeRankView?                        UnitVoDaViMeRankView                    { get; set; }
        public List<SCharaIconView>?                    SCharaIconViews                         { get; set; }
        public Toggle?                                  IndicatorOriginal                       { get; set; }
        public List<Toggle>?                            IndicatorList                           { get; set; }
        public List<int>?                               SetSCharaId                             { get; set; }

        public static ProduceUnitEditFooterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitEditFooterView();

            value.ImgBg                                     = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270DA3501B0 0x20 ImgBg                       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.TxtPartyName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA3501D0 0x28 TxtPartyName                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnEditPartyName                          = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA3501F0 0x30 BtnEditPartyName            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtCost                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA350210 0x38 TxtCost                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnSCharaEdit                             = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA350230 0x40 BtnSCharaEdit               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnSCahra                                 = GetObjectList<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA350250 0x48 BtnSCahra                   ( 000185CADC58 ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer )
            value.UnitVoDaViMeRankView                      = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x050), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0270DA350270 0x50 UnitVoDaViMeRankView        ( 000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.SCharaIconViews                           = GetObjectList<SCharaIconView>(new IntPtr(p + 0x058), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270DA350290 0x58 SCharaIconViews             ( 000185CA2A68 ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer )
            value.IndicatorOriginal                         = GetObject<Toggle>(new IntPtr(p + 0x060), ReversePrism.DataModels.Toggle.FromPointer); // 0270DA3502B0 0x60 IndicatorOriginal           ( 000186682710 ModelClassType Toggle Toggle Toggle Pointer )
            value.IndicatorList                             = GetObjectList<Toggle>(new IntPtr(p + 0x080), ReversePrism.DataModels.Toggle.FromPointer); // 0270DA350330 0x80 IndicatorList               ( 000185D15058 ModelClassListType List`1<Toggle> List`1<Toggle> List<Toggle> Pointer )
            value.SetSCharaId                               = GetInt32List(new IntPtr(p + 0x088)); // 0270DA350350 0x88 SetSCharaId                 ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
