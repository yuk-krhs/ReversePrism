using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolAlias                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 IdolName                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 IconRectView                             ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 038 ImgFavoriteMark                          ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 040 BtnFavorite                              ModelClassType UIButton UIButton UIButton Pointer
    // 048 VoDaViMeView                             ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer
    // 050 IdolSkillIconView                        ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 058 TxtSkillName                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 VoDaViMeMultiView                        ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 068 BtnIdolSkill                             ModelClassType UIButton UIButton UIButton Pointer
    // 070 BtnChangeIdolSkill                       ModelClassType UIButton UIButton UIButton Pointer
    // 078 GoIdolSkillContent                       ModelClassType GameObject GameObject GameObject Pointer
    // 080 TxtMaxStatus                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 GoCost                                   ModelClassType GameObject GameObject GameObject Pointer
    // 090 onFavorite                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 098 onSkillDetail                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 0A0 onChangeIdolSkill                        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class PIdolDetailStatusView : DataModel
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
        public UITextMeshProUGUI?                       TxtMaxStatus                            { get; set; }
        public GameObject?                              GoCost                                  { get; set; }

        public static PIdolDetailStatusView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolDetailStatusView() { Pointer= p0 };

            value.IdolAlias                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 IdolAlias                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 IdolName                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IconRectView                              = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x030), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0x30 IconRectView                ( ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.ImgFavoriteMark                           = GetObject<UIRawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x38 ImgFavoriteMark             ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.BtnFavorite                               = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 BtnFavorite                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.VoDaViMeView                              = GetObject<VoDaViMeView>(new IntPtr(p + 0x048), ReversePrism.DataModels.VoDaViMeView.FromPointer); // 0x48 VoDaViMeView                ( ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer )
            value.IdolSkillIconView                         = GetObject<IdolSkillIconView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0x50 IdolSkillIconView           ( ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.TxtSkillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtSkillName                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x060), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0x60 VoDaViMeMultiView           ( ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.BtnIdolSkill                              = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 BtnIdolSkill                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnChangeIdolSkill                        = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 BtnChangeIdolSkill          ( ModelClassType UIButton UIButton UIButton Pointer )
            value.GoIdolSkillContent                        = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 GoIdolSkillContent          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtMaxStatus                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 TxtMaxStatus                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoCost                                    = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 GoCost                      ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
