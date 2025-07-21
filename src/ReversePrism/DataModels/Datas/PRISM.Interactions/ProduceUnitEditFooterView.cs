using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgBg                                    ModelClassType Image Image Image Pointer
    // 028 TxtPartyName                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 BtnEditPartyName                         ModelClassType UIButton UIButton UIButton Pointer
    // 038 TxtCost                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BtnSCharaEdit                            ModelClassType UIButton UIButton UIButton Pointer
    // 048 BtnSCahra                                ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer
    // 050 UnitVoDaViMeRankView                     ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 058 SCharaIconViews                          ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer
    // 060 IndicatorOriginal                        ModelClassType Toggle Toggle Toggle Pointer
    // 068 onPartyEdit                              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 onSCharaIcon                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 078 onLongPressSChara                        Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 080 IndicatorList                            ModelClassListType List`1<Toggle> List`1<Toggle> List<Toggle> Pointer
    // 088 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 090 SetSCharaId                              ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class ProduceUnitEditFooterView : DataModel
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
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public List<int>?                               SetSCharaId                             { get; set; }

        public static ProduceUnitEditFooterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitEditFooterView() { Pointer= p0 };

            value.ImgBg                                     = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 ImgBg                       ( ModelClassType Image Image Image Pointer )
            value.TxtPartyName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtPartyName                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnEditPartyName                          = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 BtnEditPartyName            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtCost                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtCost                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnSCharaEdit                             = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 BtnSCharaEdit               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnSCahra                                 = GetObjectList<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 BtnSCahra                   ( ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer )
            value.UnitVoDaViMeRankView                      = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x050), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0x50 UnitVoDaViMeRankView        ( ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.SCharaIconViews                           = GetObjectList<SCharaIconView>(new IntPtr(p + 0x058), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x58 SCharaIconViews             ( ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer )
            value.IndicatorOriginal                         = GetObject<Toggle>(new IntPtr(p + 0x060), ReversePrism.DataModels.Toggle.FromPointer); // 0x60 IndicatorOriginal           ( ModelClassType Toggle Toggle Toggle Pointer )
            value.IndicatorList                             = GetObjectList<Toggle>(new IntPtr(p + 0x080), ReversePrism.DataModels.Toggle.FromPointer); // 0x80 IndicatorList               ( ModelClassListType List`1<Toggle> List`1<Toggle> List<Toggle> Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x088), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x88 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.SetSCharaId                               = GetInt32List(new IntPtr(p + 0x090)); // 0x90 SetSCharaId                 ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
