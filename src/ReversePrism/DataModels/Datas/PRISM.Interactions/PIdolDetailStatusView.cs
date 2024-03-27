using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolAlias                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 IdolName                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 IconRectView                             000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 038 ImgFavoriteMark                          0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 040 BtnFavorite                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 VoDaViMeView                             000186531810 ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer
    // 050 IdolSkillIconView                        0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 058 TxtSkillName                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 VoDaViMeMultiView                        000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 068 BtnIdolSkill                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 BtnChangeIdolSkill                       0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 GoIdolSkillContent                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 GoMaxStatusText                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 onFavorite                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 onSkillDetail                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 098 onChangeIdolSkill                        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class PIdolDetailStatusView
    {
        public UITextMeshProUGUI?                       IdolAlias                               { get; set; }
        public UITextMeshProUGUI?                       IdolName                                { get; set; }
        public PFIdolIconRectView?                      IconRectView                            { get; set; }
        public UIRawImage?                              ImgFavoriteMark                         { get; set; }
        public UIButton?                                BtnFavorite                             { get; set; }
        public VoDaViMeView?                            VoDaViMeView                            { get; set; }
        public IdolSkillIconView?                       IdolSkillIconView                       { get; set; }
        public UITextMeshProUGUI?                       TxtSkillName                            { get; set; }
        public VoDaViMeMultiView?                       VoDaViMeMultiView                       { get; set; }
        public UIButton?                                BtnIdolSkill                            { get; set; }
        public UIButton?                                BtnChangeIdolSkill                      { get; set; }
        public GameObject?                              GoIdolSkillContent                      { get; set; }
        public GameObject?                              GoMaxStatusText                         { get; set; }

        public static PIdolDetailStatusView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolDetailStatusView();

            value.IdolAlias                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA306720 0x20 IdolAlias                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA306740 0x28 IdolName                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IconRectView                              = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x030), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0270DA306760 0x30 IconRectView                ( 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.ImgFavoriteMark                           = GetObject<UIRawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA306780 0x38 ImgFavoriteMark             ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.BtnFavorite                               = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA3067A0 0x40 BtnFavorite                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.VoDaViMeView                              = GetObject<VoDaViMeView>(new IntPtr(p + 0x048), ReversePrism.DataModels.VoDaViMeView.FromPointer); // 0270DA3067C0 0x48 VoDaViMeView                ( 000186531810 ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer )
            value.IdolSkillIconView                         = GetObject<IdolSkillIconView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0270DA3067E0 0x50 IdolSkillIconView           ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.TxtSkillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA306800 0x58 TxtSkillName                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x060), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0270DA306820 0x60 VoDaViMeMultiView           ( 000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.BtnIdolSkill                              = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA306840 0x68 BtnIdolSkill                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnChangeIdolSkill                        = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA306860 0x70 BtnChangeIdolSkill          ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.GoIdolSkillContent                        = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA306880 0x78 GoIdolSkillContent          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoMaxStatusText                           = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA3068A0 0x80 GoMaxStatusText             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
