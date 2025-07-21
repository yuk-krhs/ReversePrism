using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CharID16Color                            Color IL2CPP_TYPE_VALUETYPE
    // 020 ProdeuceIdolImageTransform               ModelClassType Transform Transform Transform Pointer
    // 028 BackgroundImage                          ModelClassType RawImage RawImage RawImage Pointer
    // 030 ProduceIdolDetailButton                  ModelClassType UIButton UIButton UIButton Pointer
    // 038 ChangeProduceIdolButton                  ModelClassType UIButton UIButton UIButton Pointer
    // 040 ProducerNameText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ChangeNameButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 050 AchievementPanelView                     ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer
    // 058 BirthdayText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ChangeBirthdayButton                     ModelClassType UIButton UIButton UIButton Pointer
    // 068 ProfileCommentText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ChangeUserCommentButton                  ModelClassType UIButton UIButton UIButton Pointer
    // 078 BlankSupportIdolIconButton               ModelClassType UIButton UIButton UIButton Pointer
    // 080 SupportIdolIcon                          ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 088 PlayerIdText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 PlayerIdCopyButton                       ModelClassType UIButton UIButton UIButton Pointer
    // 098 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 0A0 onPIdolDetail                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A8 onClickSChara                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0B0 onSCharaDetail                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ProfileUserSelfPanelView : DataModel
    {
        public Transform?                               ProdeuceIdolImageTransform              { get; set; }
        public RawImage?                                BackgroundImage                         { get; set; }
        public UIButton?                                ProduceIdolDetailButton                 { get; set; }
        public UIButton?                                ChangeProduceIdolButton                 { get; set; }
        public UITextMeshProUGUI?                       ProducerNameText                        { get; set; }
        public UIButton?                                ChangeNameButton                        { get; set; }
        public AchievementPanelView?                    AchievementPanelView                    { get; set; }
        public UITextMeshProUGUI?                       BirthdayText                            { get; set; }
        public UIButton?                                ChangeBirthdayButton                    { get; set; }
        public UITextMeshProUGUI?                       ProfileCommentText                      { get; set; }
        public UIButton?                                ChangeUserCommentButton                 { get; set; }
        public UIButton?                                BlankSupportIdolIconButton              { get; set; }
        public SCharaIconView?                          SupportIdolIcon                         { get; set; }
        public UITextMeshProUGUI?                       PlayerIdText                            { get; set; }
        public UIButton?                                PlayerIdCopyButton                      { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ProfileUserSelfPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileUserSelfPanelView() { Pointer= p0 };

            value.ProdeuceIdolImageTransform                = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 ProdeuceIdolImageTransform  ( ModelClassType Transform Transform Transform Pointer )
            value.BackgroundImage                           = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 BackgroundImage             ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ProduceIdolDetailButton                   = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 ProduceIdolDetailButton     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ChangeProduceIdolButton                   = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 ChangeProduceIdolButton     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ProducerNameText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 ProducerNameText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ChangeNameButton                          = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 ChangeNameButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.AchievementPanelView                      = GetObject<AchievementPanelView>(new IntPtr(p + 0x050), ReversePrism.DataModels.AchievementPanelView.FromPointer); // 0x50 AchievementPanelView        ( ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer )
            value.BirthdayText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 BirthdayText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ChangeBirthdayButton                      = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 ChangeBirthdayButton        ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ProfileCommentText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 ProfileCommentText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ChangeUserCommentButton                   = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 ChangeUserCommentButton     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BlankSupportIdolIconButton                = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0x78 BlankSupportIdolIconButton  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SupportIdolIcon                           = GetObject<SCharaIconView>(new IntPtr(p + 0x080), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x80 SupportIdolIcon             ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.PlayerIdText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 PlayerIdText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PlayerIdCopyButton                        = GetObject<UIButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIButton.FromPointer); // 0x90 PlayerIdCopyButton          ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x098), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x98 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
