using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconView                                 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 IdolSkillIcon                            0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 030 LiveSkillIcon                            000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 038 LiveSkillLvText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 LiveSkillExchangeButton                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 LiveSkillSelectFrameImage                0001866920B0 ModelClassType Graphic Graphic Graphic Pointer
    // 050 LiveSkillSelectFrameBlinkDuration        0001866656B0 ModelPrimitiveType float float float Single
    // 054 LiveSkillSelectFrameBlinkMinAlpha        0001866656B0 ModelPrimitiveType float float float Single
    // 058 LiveSkillExchangeFrame                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 VoDaViMeRankView                         000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 068 GetLiveSkillEffect                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 RouletteFPS                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 074 RouletteTime                             0001866656B0 ModelPrimitiveType float float float Single
    // 078 SoundIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 088 Tweener                                  0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer
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

            value.IconView                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 02466A321678 0x20 IconView                    ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.IdolSkillIcon                             = GetObject<IdolSkillIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 02466A321698 0x28 IdolSkillIcon               ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.LiveSkillIcon                             = GetObject<RawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.RawImage.FromPointer); // 02466A3216B8 0x30 LiveSkillIcon               ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.LiveSkillLvText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3216D8 0x38 LiveSkillLvText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LiveSkillExchangeButton                   = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3216F8 0x40 LiveSkillExchangeButton     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.LiveSkillSelectFrameImage                 = GetObject<Graphic>(new IntPtr(p + 0x048), ReversePrism.DataModels.Graphic.FromPointer); // 02466A321718 0x48 LiveSkillSelectFrameImage   ( 0001866920B0 ModelClassType Graphic Graphic Graphic Pointer )
            value.LiveSkillSelectFrameBlinkDuration         = GetSingle(new IntPtr(p + 0x050)); // 02466A321738 0x50 LiveSkillSelectFrameBlinkDuration ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LiveSkillSelectFrameBlinkMinAlpha         = GetSingle(new IntPtr(p + 0x054)); // 02466A321758 0x54 LiveSkillSelectFrameBlinkMinAlpha ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LiveSkillExchangeFrame                    = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 02466A321778 0x58 LiveSkillExchangeFrame      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.VoDaViMeRankView                          = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x060), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 02466A321798 0x60 VoDaViMeRankView            ( 000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.GetLiveSkillEffect                        = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3217B8 0x68 GetLiveSkillEffect          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RouletteFPS                               = GetInt32(new IntPtr(p + 0x070)); // 02466A3217D8 0x70 RouletteFPS                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RouletteTime                              = GetSingle(new IntPtr(p + 0x074)); // 02466A3217F8 0x74 RouletteTime                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SoundIndex                                = GetInt32(new IntPtr(p + 0x078)); // 02466A321818 0x78 SoundIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x080), ReversePrism.DataModels.IResourceLoader.FromPointer); // 02466A321838 0x80 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Tweener                                   = GetObject<Tweener>(new IntPtr(p + 0x088), ReversePrism.DataModels.Tweener.FromPointer); // 02466A321858 0x88 Tweener                     ( 0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer )

            return value;
        }
    }
}
