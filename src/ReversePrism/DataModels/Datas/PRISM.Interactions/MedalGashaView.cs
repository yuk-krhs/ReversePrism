using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundImage                          0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 EventLogo                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 EventLogoEffect                          0001866CCDB0 ModelClassType Image Image Image Pointer
    // 038 BoxNumberText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 EndDateText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 RewardListView                           0001865EB590 ModelClassType MedalGashaRewardAllListView MedalGashaRewardAllListView MedalGashaRewardAllListView Pointer
    // 050 WarnText                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 OkText                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 GashaTokenArea                           0001866208B0 ModelClassType GashaTokenArea GashaTokenArea GashaTokenArea Pointer
    // 068 GashaButtonSingle                        0001865F2FB0 ModelClassType GashaButton GashaButton GashaButton Pointer
    // 070 GashaButtonMultiple                      0001865F2FB0 ModelClassType GashaButton GashaButton GashaButton Pointer
    // 078 GrayOutSingle                            0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 080 GrayOutMultiple                          0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 088 HelpButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 090 ProceedNextButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 098 FeaturedRewardButton                     0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0A0 HowToPlayPopupOpener                     0001866D8C30 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 0A8 ProceedNextObjects                       000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 0B0 ProceedNextAnimations                    000185B701C0 ModelClassListType Animator[] Animator[] List<Animator> Pointer
    // 0B8 LockCheckBox                             000186682710 ModelClassType Toggle Toggle Toggle Pointer
    // 0C0 LockCheckBoxObject                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 LockedButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0D0 UnlockWarningBalloonObject               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0D8 MaxGashaCount                            0001865F4260 ModelPrimitiveType int int int Int32
    // 0E0 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 0E8 onClickGasha                             Subject`1<ValueTuple`4<MedalGashaStatusModel, int, int, int>> IL2CPP_TYPE_GENERICINST
    // 0F0 GashaModel                               0001865EBA70 ModelClassType MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel Pointer
    // 0F8 StatusModel                              0001865EF260 ModelClassType MedalGashaStatusModel MedalGashaStatusModel MedalGashaStatusModel Pointer
    public partial class MedalGashaView
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
        public IResourceTag?                            ResourceTag                             { get; set; }
        public MedalGashaRewardAllListViewModel?        GashaModel                              { get; set; }
        public MedalGashaStatusModel?                   StatusModel                             { get; set; }

        public static MedalGashaView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaView();

            value.BackgroundImage                           = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270DB61AD80 0x20 BackgroundImage             ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.EventLogo                                 = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0270DB61ADA0 0x28 EventLogo                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.EventLogoEffect                           = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0270DB61ADC0 0x30 EventLogoEffect             ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.BoxNumberText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB61ADE0 0x38 BoxNumberText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EndDateText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB61AE00 0x40 EndDateText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardListView                            = GetObject<MedalGashaRewardAllListView>(new IntPtr(p + 0x048), ReversePrism.DataModels.MedalGashaRewardAllListView.FromPointer); // 0270DB61AE20 0x48 RewardListView              ( 0001865EB590 ModelClassType MedalGashaRewardAllListView MedalGashaRewardAllListView MedalGashaRewardAllListView Pointer )
            value.WarnText                                  = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB61AE40 0x50 WarnText                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OkText                                    = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB61AE60 0x58 OkText                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GashaTokenArea                            = GetObject<GashaTokenArea>(new IntPtr(p + 0x060), ReversePrism.DataModels.GashaTokenArea.FromPointer); // 0270DB61AE80 0x60 GashaTokenArea              ( 0001866208B0 ModelClassType GashaTokenArea GashaTokenArea GashaTokenArea Pointer )
            value.GashaButtonSingle                         = GetObject<GashaButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.GashaButton.FromPointer); // 0270DB61AEA0 0x68 GashaButtonSingle           ( 0001865F2FB0 ModelClassType GashaButton GashaButton GashaButton Pointer )
            value.GashaButtonMultiple                       = GetObject<GashaButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.GashaButton.FromPointer); // 0270DB61AEC0 0x70 GashaButtonMultiple         ( 0001865F2FB0 ModelClassType GashaButton GashaButton GashaButton Pointer )
            value.GrayOutSingle                             = GetObject<UIGrayOutController>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270DB61AEE0 0x78 GrayOutSingle               ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.GrayOutMultiple                           = GetObject<UIGrayOutController>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270DB61AF00 0x80 GrayOutMultiple             ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.HelpButton                                = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB61AF20 0x88 HelpButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ProceedNextButton                         = GetObject<UIButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB61AF40 0x90 ProceedNextButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.FeaturedRewardButton                      = GetObject<UIButton>(new IntPtr(p + 0x098), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB61AF60 0x98 FeaturedRewardButton        ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0270DB61AF80 0xA0 HowToPlayPopupOpener        ( 0001866D8C30 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.ProceedNextObjects                        = GetObjectList<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB61AFA0 0xA8 ProceedNextObjects          ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ProceedNextAnimations                     = GetObjectList<Animator>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Animator.FromPointer); // 0270DB61AFC0 0xB0 ProceedNextAnimations       ( 000185B701C0 ModelClassListType Animator[] Animator[] List<Animator> Pointer )
            value.LockCheckBox                              = GetObject<Toggle>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Toggle.FromPointer); // 0270DB61AFE0 0xB8 LockCheckBox                ( 000186682710 ModelClassType Toggle Toggle Toggle Pointer )
            value.LockCheckBoxObject                        = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB61B000 0xC0 LockCheckBoxObject          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LockedButton                              = GetObject<UIButton>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB61B020 0xC8 LockedButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UnlockWarningBalloonObject                = GetObject<GameObject>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB61B040 0xD0 UnlockWarningBalloonObject  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MaxGashaCount                             = GetInt32(new IntPtr(p + 0x0D8)); // 0270DB61B060 0xD8 MaxGashaCount               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB61B080 0xE0 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.GashaModel                                = GetObject<MedalGashaRewardAllListViewModel>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.MedalGashaRewardAllListViewModel.FromPointer); // 0270DB61B0C0 0xF0 GashaModel                  ( 0001865EBA70 ModelClassType MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel Pointer )
            value.StatusModel                               = GetObject<MedalGashaStatusModel>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.MedalGashaStatusModel.FromPointer); // 0270DB61B0E0 0xF8 StatusModel                 ( 0001865EF260 ModelClassType MedalGashaStatusModel MedalGashaStatusModel MedalGashaStatusModel Pointer )

            return value;
        }
    }
}
