using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundImage                          ModelClassType Image Image Image Pointer
    // 028 EventLogo                                ModelClassType Image Image Image Pointer
    // 030 EventLogoEffect                          ModelClassType Image Image Image Pointer
    // 038 BoxNumberText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 EndDateText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 RewardListView                           ModelClassType MedalGashaRewardAllListView MedalGashaRewardAllListView MedalGashaRewardAllListView Pointer
    // 050 WarnText                                 ModelClassType GameObject GameObject GameObject Pointer
    // 058 OkText                                   ModelClassType GameObject GameObject GameObject Pointer
    // 060 GashaTokenArea                           ModelClassType GashaTokenArea GashaTokenArea GashaTokenArea Pointer
    // 068 GashaButtonSingle                        ModelClassType GashaButton GashaButton GashaButton Pointer
    // 070 GashaButtonMultiple                      ModelClassType GashaButton GashaButton GashaButton Pointer
    // 078 GrayOutSingle                            ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 080 GrayOutMultiple                          ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 088 HelpButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 090 ProceedNextButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 098 FeaturedRewardButton                     ModelClassType UIButton UIButton UIButton Pointer
    // 0A0 HowToPlayPopupOpener                     ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 0A8 ProceedNextObjects                       ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 0B0 ProceedNextAnimations                    ModelClassListType Animator[] Animator[] List<Animator> Pointer
    // 0B8 LockCheckBox                             ModelClassType Toggle Toggle Toggle Pointer
    // 0C0 LockCheckBoxObject                       ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 LockedButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 0D0 UnlockWarningBalloonObject               ModelClassType GameObject GameObject GameObject Pointer
    // 0D8 MaxGashaCount                            ModelPrimitiveType int int int Int32
    // 0E0 onClickGasha                             Subject`1<ValueTuple`4<MedalGashaStatusModel, int, int, int>> IL2CPP_TYPE_GENERICINST
    // 0E8 GashaModel                               ModelClassType MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel Pointer
    // 0F0 StatusModel                              ModelClassType MedalGashaStatusModel MedalGashaStatusModel MedalGashaStatusModel Pointer
    public partial class MedalGashaView : DataModel
    {
        public Image?                                   BackgroundImage                         { get; set; }
        public Image?                                   EventLogo                               { get; set; }
        public Image?                                   EventLogoEffect                         { get; set; }
        public UITextMeshProUGUI?                       BoxNumberText                           { get; set; }
        public UITextMeshProUGUI?                       EndDateText                             { get; set; }
        public MedalGashaRewardAllListView?             RewardListView                          { get; set; }
        public GameObject?                              WarnText                                { get; set; }
        public GameObject?                              OkText                                  { get; set; }
        public GashaTokenArea?                          GashaTokenArea                          { get; set; }
        public GashaButton?                             GashaButtonSingle                       { get; set; }
        public GashaButton?                             GashaButtonMultiple                     { get; set; }
        public UIGrayOutController?                     GrayOutSingle                           { get; set; }
        public UIGrayOutController?                     GrayOutMultiple                         { get; set; }
        public UIButton?                                HelpButton                              { get; set; }
        public UIButton?                                ProceedNextButton                       { get; set; }
        public UIButton?                                FeaturedRewardButton                    { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }
        public List<GameObject>?                        ProceedNextObjects                      { get; set; }
        public List<Animator>?                          ProceedNextAnimations                   { get; set; }
        public Toggle?                                  LockCheckBox                            { get; set; }
        public GameObject?                              LockCheckBoxObject                      { get; set; }
        public UIButton?                                LockedButton                            { get; set; }
        public GameObject?                              UnlockWarningBalloonObject              { get; set; }
        public int                                      MaxGashaCount                           { get; set; }
        public MedalGashaRewardAllListViewModel?        GashaModel                              { get; set; }
        public MedalGashaStatusModel?                   StatusModel                             { get; set; }

        public static MedalGashaView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaView() { Pointer= p0 };

            value.BackgroundImage                           = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 BackgroundImage             ( ModelClassType Image Image Image Pointer )
            value.EventLogo                                 = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 EventLogo                   ( ModelClassType Image Image Image Pointer )
            value.EventLogoEffect                           = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0x30 EventLogoEffect             ( ModelClassType Image Image Image Pointer )
            value.BoxNumberText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 BoxNumberText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EndDateText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 EndDateText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardListView                            = GetObject<MedalGashaRewardAllListView>(new IntPtr(p + 0x048), ReversePrism.DataModels.MedalGashaRewardAllListView.FromPointer); // 0x48 RewardListView              ( ModelClassType MedalGashaRewardAllListView MedalGashaRewardAllListView MedalGashaRewardAllListView Pointer )
            value.WarnText                                  = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 WarnText                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OkText                                    = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 OkText                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GashaTokenArea                            = GetObject<GashaTokenArea>(new IntPtr(p + 0x060), ReversePrism.DataModels.GashaTokenArea.FromPointer); // 0x60 GashaTokenArea              ( ModelClassType GashaTokenArea GashaTokenArea GashaTokenArea Pointer )
            value.GashaButtonSingle                         = GetObject<GashaButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.GashaButton.FromPointer); // 0x68 GashaButtonSingle           ( ModelClassType GashaButton GashaButton GashaButton Pointer )
            value.GashaButtonMultiple                       = GetObject<GashaButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.GashaButton.FromPointer); // 0x70 GashaButtonMultiple         ( ModelClassType GashaButton GashaButton GashaButton Pointer )
            value.GrayOutSingle                             = GetObject<UIGrayOutController>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x78 GrayOutSingle               ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.GrayOutMultiple                           = GetObject<UIGrayOutController>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x80 GrayOutMultiple             ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.HelpButton                                = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0x88 HelpButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ProceedNextButton                         = GetObject<UIButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIButton.FromPointer); // 0x90 ProceedNextButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.FeaturedRewardButton                      = GetObject<UIButton>(new IntPtr(p + 0x098), ReversePrism.DataModels.UIButton.FromPointer); // 0x98 FeaturedRewardButton        ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0xA0 HowToPlayPopupOpener        ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.ProceedNextObjects                        = GetObjectList<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0xA8 ProceedNextObjects          ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ProceedNextAnimations                     = GetObjectList<Animator>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Animator.FromPointer); // 0xB0 ProceedNextAnimations       ( ModelClassListType Animator[] Animator[] List<Animator> Pointer )
            value.LockCheckBox                              = GetObject<Toggle>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Toggle.FromPointer); // 0xB8 LockCheckBox                ( ModelClassType Toggle Toggle Toggle Pointer )
            value.LockCheckBoxObject                        = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0xC0 LockCheckBoxObject          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LockedButton                              = GetObject<UIButton>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UIButton.FromPointer); // 0xC8 LockedButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UnlockWarningBalloonObject                = GetObject<GameObject>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.GameObject.FromPointer); // 0xD0 UnlockWarningBalloonObject  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MaxGashaCount                             = GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 MaxGashaCount               ( ModelPrimitiveType int int int Int32 )
            value.GashaModel                                = GetObject<MedalGashaRewardAllListViewModel>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.MedalGashaRewardAllListViewModel.FromPointer); // 0xE8 GashaModel                  ( ModelClassType MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel Pointer )
            value.StatusModel                               = GetObject<MedalGashaStatusModel>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.MedalGashaStatusModel.FromPointer); // 0xF0 StatusModel                 ( ModelClassType MedalGashaStatusModel MedalGashaStatusModel MedalGashaStatusModel Pointer )

            return value;
        }
    }
}
