using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 resourceTag                              string IL2CPP_TYPE_STRING
    // 020 AnimatorHashAppearTitle                  0001865F4260 ModelPrimitiveType int int int Int32
    // 028 ProduceTitle                             0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 030 OneLineTitle                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 OneLineTitleText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TwoLineTitle                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 ChapterTitle                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TitleObject                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 StoryTitle                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 StoryChapterTitle                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 StoryTitleObject                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 StoryTitleBack                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 Icon                                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 ScharaIcon                               0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 088 UnitIconImage                            0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 090 PfIcon                                   000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 098 BaseIcon                                 000186599240 ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer
    public partial class AdvTitle : DataModel
    {
        public int                                      AnimatorHashAppearTitle                 { get; set; }
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

        public static AdvTitle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvTitle() { Pointer= p0 };

            value.AnimatorHashAppearTitle                   = GetInt32(new IntPtr(p + 0x020)); // 024665E4E7C8 0x20 AnimatorHashAppearTitle     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ProduceTitle                              = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 024665E4E7E8 0x28 ProduceTitle                ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.OneLineTitle                              = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 024665E4E808 0x30 OneLineTitle                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OneLineTitleText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E4E828 0x38 OneLineTitleText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TwoLineTitle                              = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 024665E4E848 0x40 TwoLineTitle                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ChapterTitle                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E4E868 0x48 ChapterTitle                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TitleObject                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E4E888 0x50 TitleObject                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StoryTitle                                = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 024665E4E8A8 0x58 StoryTitle                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.StoryChapterTitle                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E4E8C8 0x60 StoryChapterTitle           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StoryTitleObject                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E4E8E8 0x68 StoryTitleObject            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StoryTitleBack                            = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 024665E4E908 0x70 StoryTitleBack              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Icon                                      = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 024665E4E928 0x78 Icon                        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScharaIcon                                = GetObject<SCharaIconView>(new IntPtr(p + 0x080), ReversePrism.DataModels.SCharaIconView.FromPointer); // 024665E4E948 0x80 ScharaIcon                  ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.UnitIconImage                             = GetObject<UIImage>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIImage.FromPointer); // 024665E4E968 0x88 UnitIconImage               ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.PfIcon                                    = GetObject<PFIdolIconView>(new IntPtr(p + 0x090), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 024665E4E988 0x90 PfIcon                      ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.BaseIcon                                  = GetObject<CharacterBaseIcon>(new IntPtr(p + 0x098), ReversePrism.DataModels.CharacterBaseIcon.FromPointer); // 024665E4E9A8 0x98 BaseIcon                    ( 000186599240 ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer )

            return value;
        }
    }
}
