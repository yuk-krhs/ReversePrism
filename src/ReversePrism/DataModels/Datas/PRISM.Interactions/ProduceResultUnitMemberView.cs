using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconView                                 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 IdolSkillIcon                            ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 030 LiveSkillIcon                            ModelClassType RawImage RawImage RawImage Pointer
    // 038 LiveSkillLvText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 LiveSkillExchangeButton                  ModelClassType UIButton UIButton UIButton Pointer
    // 048 LiveSkillSelectFrameImage                ModelClassType Graphic Graphic Graphic Pointer
    // 050 LiveSkillSelectFrameBlinkDuration        ModelPrimitiveType float float float Single
    // 054 LiveSkillSelectFrameBlinkMinAlpha        ModelPrimitiveType float float float Single
    // 058 LiveSkillExchangeFrame                   ModelClassType GameObject GameObject GameObject Pointer
    // 060 VoDaViMeRankView                         ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 068 GetLiveSkillEffect                       ModelClassType GameObject GameObject GameObject Pointer
    // 070 RouletteFPS                              ModelPrimitiveType int int int Int32
    // 074 RouletteTime                             ModelPrimitiveType float float float Single
    // 078 SoundIndex                               ModelPrimitiveType int int int Int32
    // 080 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 088 Tweener                                  ModelClassType Tweener Tweener Tweener Pointer
    // 090 onFIdolDetail                            Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 098 onClickLiveSkillIcon                     Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 0A0 onLongPressLiveSkillIcon                 Subject`1<LiveSkillViewModel> IL2CPP_TYPE_GENERICINST
    public partial class ProduceResultUnitMemberView : DataModel
    {
        public PFIdolIconView?                          IconView                                { get; set; }
        public IdolSkillIconView?                       IdolSkillIcon                           { get; set; }
        public RawImage?                                LiveSkillIcon                           { get; set; }
        public UITextMeshProUGUI?                       LiveSkillLvText                         { get; set; }
        public UIButton?                                LiveSkillExchangeButton                 { get; set; }
        public Graphic?                                 LiveSkillSelectFrameImage               { get; set; }
        public float                                    LiveSkillSelectFrameBlinkDuration       { get; set; }
        public float                                    LiveSkillSelectFrameBlinkMinAlpha       { get; set; }
        public GameObject?                              LiveSkillExchangeFrame                  { get; set; }
        public VoDaViMeRankView?                        VoDaViMeRankView                        { get; set; }
        public GameObject?                              GetLiveSkillEffect                      { get; set; }
        public int                                      RouletteFPS                             { get; set; }
        public float                                    RouletteTime                            { get; set; }
        public int                                      SoundIndex                              { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public Tweener?                                 Tweener                                 { get; set; }

        public static ProduceResultUnitMemberView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultUnitMemberView() { Pointer= p0 };

            value.IconView                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x20 IconView                    ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.IdolSkillIcon                             = GetObject<IdolSkillIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0x28 IdolSkillIcon               ( ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.LiveSkillIcon                             = GetObject<RawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.RawImage.FromPointer); // 0x30 LiveSkillIcon               ( ModelClassType RawImage RawImage RawImage Pointer )
            value.LiveSkillLvText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 LiveSkillLvText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LiveSkillExchangeButton                   = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 LiveSkillExchangeButton     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.LiveSkillSelectFrameImage                 = GetObject<Graphic>(new IntPtr(p + 0x048), ReversePrism.DataModels.Graphic.FromPointer); // 0x48 LiveSkillSelectFrameImage   ( ModelClassType Graphic Graphic Graphic Pointer )
            value.LiveSkillSelectFrameBlinkDuration         = GetSingle(new IntPtr(p + 0x050)); // 0x50 LiveSkillSelectFrameBlinkDuration ( ModelPrimitiveType float float float Single )
            value.LiveSkillSelectFrameBlinkMinAlpha         = GetSingle(new IntPtr(p + 0x054)); // 0x54 LiveSkillSelectFrameBlinkMinAlpha ( ModelPrimitiveType float float float Single )
            value.LiveSkillExchangeFrame                    = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 LiveSkillExchangeFrame      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.VoDaViMeRankView                          = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x060), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0x60 VoDaViMeRankView            ( ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.GetLiveSkillEffect                        = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 GetLiveSkillEffect          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.RouletteFPS                               = GetInt32(new IntPtr(p + 0x070)); // 0x70 RouletteFPS                 ( ModelPrimitiveType int int int Int32 )
            value.RouletteTime                              = GetSingle(new IntPtr(p + 0x074)); // 0x74 RouletteTime                ( ModelPrimitiveType float float float Single )
            value.SoundIndex                                = GetInt32(new IntPtr(p + 0x078)); // 0x78 SoundIndex                  ( ModelPrimitiveType int int int Int32 )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x080), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x80 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Tweener                                   = GetObject<Tweener>(new IntPtr(p + 0x088), ReversePrism.DataModels.Tweener.FromPointer); // 0x88 Tweener                     ( ModelClassType Tweener Tweener Tweener Pointer )

            return value;
        }
    }
}
