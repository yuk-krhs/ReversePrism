using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProduceTitle                             ModelClassType Animator Animator Animator Pointer
    // 028 OneLineTitle                             ModelClassType GameObject GameObject GameObject Pointer
    // 030 OneLineTitleText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TwoLineTitle                             ModelClassType GameObject GameObject GameObject Pointer
    // 040 ChapterTitle                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TitleObject                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 StoryTitle                               ModelClassType GameObject GameObject GameObject Pointer
    // 058 StoryChapterTitle                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 StoryTitleObject                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 StoryTitleBack                           ModelClassType GameObject GameObject GameObject Pointer
    // 070 Icon                                     ModelClassType GameObject GameObject GameObject Pointer
    // 078 ScharaIcon                               ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 080 UnitIconImage                            ModelClassType UIImage UIImage UIImage Pointer
    // 088 PfIcon                                   ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 090 BaseIcon                                 ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer
    // 098 AnimatorHashAppearTitle                  ModelPrimitiveType int int int Int32
    public partial class AdvTitleView : DataModel
    {
        public Animator?                                ProduceTitle                            { get; set; }
        public GameObject?                              OneLineTitle                            { get; set; }
        public UITextMeshProUGUI?                       OneLineTitleText                        { get; set; }
        public GameObject?                              TwoLineTitle                            { get; set; }
        public UITextMeshProUGUI?                       ChapterTitle                            { get; set; }
        public UITextMeshProUGUI?                       TitleObject                             { get; set; }
        public GameObject?                              StoryTitle                              { get; set; }
        public UITextMeshProUGUI?                       StoryChapterTitle                       { get; set; }
        public UITextMeshProUGUI?                       StoryTitleObject                        { get; set; }
        public GameObject?                              StoryTitleBack                          { get; set; }
        public GameObject?                              Icon                                    { get; set; }
        public SCharaIconView?                          ScharaIcon                              { get; set; }
        public UIImage?                                 UnitIconImage                           { get; set; }
        public PFIdolIconView?                          PfIcon                                  { get; set; }
        public CharacterBaseIcon?                       BaseIcon                                { get; set; }
        public int                                      AnimatorHashAppearTitle                 { get; set; }

        public static AdvTitleView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvTitleView() { Pointer= p0 };

            value.ProduceTitle                              = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0x20 ProduceTitle                ( ModelClassType Animator Animator Animator Pointer )
            value.OneLineTitle                              = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 OneLineTitle                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OneLineTitleText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 OneLineTitleText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TwoLineTitle                              = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 TwoLineTitle                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ChapterTitle                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 ChapterTitle                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TitleObject                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TitleObject                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StoryTitle                                = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 StoryTitle                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.StoryChapterTitle                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 StoryChapterTitle           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StoryTitleObject                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 StoryTitleObject            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StoryTitleBack                            = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 StoryTitleBack              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Icon                                      = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 Icon                        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScharaIcon                                = GetObject<SCharaIconView>(new IntPtr(p + 0x078), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x78 ScharaIcon                  ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.UnitIconImage                             = GetObject<UIImage>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIImage.FromPointer); // 0x80 UnitIconImage               ( ModelClassType UIImage UIImage UIImage Pointer )
            value.PfIcon                                    = GetObject<PFIdolIconView>(new IntPtr(p + 0x088), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x88 PfIcon                      ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.BaseIcon                                  = GetObject<CharacterBaseIcon>(new IntPtr(p + 0x090), ReversePrism.DataModels.CharacterBaseIcon.FromPointer); // 0x90 BaseIcon                    ( ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer )
            value.AnimatorHashAppearTitle                   = GetInt32(new IntPtr(p + 0x098)); // 0x98 AnimatorHashAppearTitle     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
