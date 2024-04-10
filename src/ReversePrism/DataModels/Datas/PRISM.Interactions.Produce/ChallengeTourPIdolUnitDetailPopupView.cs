using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 VoDaViMeRankView                         000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 030 ParameterDetailButton                    000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 PIdolUnitPanelViews                      000185B74050 ModelClassListType ChallengeTourPIdolUnitPanelView[] ChallengeTourPIdolUnitPanelView[] List<ChallengeTourPIdolUnitPanelView> Pointer
    // 040 GoPCardPrefab                            0001865353C0 ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer
    // 048 TrCardParent                             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 050 CardCountText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ShowObjects                              000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 pIdolDetailPopupFactory                  PopupViewFactory`1<IPIdolDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 068 parameterDetailPopupFactory              PopupViewFactory`1<IPFIdolParameterDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 070 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 078 onClickPIdol                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 080 ViewModel                                00018658D950 ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer
    // 088 UnitIndex                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 090 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 098 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ChallengeTourPIdolUnitDetailPopupView : DataModel
    {
        public UITabGroup?                              TabGroup                                { get; set; }
        public VoDaViMeRankView?                        VoDaViMeRankView                        { get; set; }
        public ButtonBase?                              ParameterDetailButton                   { get; set; }
        public List<ChallengeTourPIdolUnitPanelView>?   PIdolUnitPanelViews                     { get; set; }
        public ProduceCardContent?                      GoPCardPrefab                           { get; set; }
        public Transform?                               TrCardParent                            { get; set; }
        public UITextMeshProUGUI?                       CardCountText                           { get; set; }
        public List<GameObject>?                        ShowObjects                             { get; set; }
        public ChallengeTourUnitViewModel?              ViewModel                               { get; set; }
        public int                                      UnitIndex                               { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ChallengeTourPIdolUnitDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourPIdolUnitDetailPopupView() { Pointer= p0 };

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466A2220E8 0x20 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.VoDaViMeRankView                          = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x028), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 02466A222108 0x28 VoDaViMeRankView            ( 000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.ParameterDetailButton                     = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466A222128 0x30 ParameterDetailButton       ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.PIdolUnitPanelViews                       = GetObjectList<ChallengeTourPIdolUnitPanelView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourPIdolUnitPanelView.FromPointer); // 02466A222148 0x38 PIdolUnitPanelViews         ( 000185B74050 ModelClassListType ChallengeTourPIdolUnitPanelView[] ChallengeTourPIdolUnitPanelView[] List<ChallengeTourPIdolUnitPanelView> Pointer )
            value.GoPCardPrefab                             = GetObject<ProduceCardContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 02466A222168 0x40 GoPCardPrefab               ( 0001865353C0 ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer )
            value.TrCardParent                              = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 02466A222188 0x48 TrCardParent                ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.CardCountText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2221A8 0x50 CardCountText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ShowObjects                               = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 02466A2221C8 0x58 ShowObjects                 ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourUnitViewModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.ChallengeTourUnitViewModel.FromPointer); // 02466A222268 0x80 ViewModel                   ( 00018658D950 ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer )
            value.UnitIndex                                 = GetInt32(new IntPtr(p + 0x088)); // 02466A222288 0x88 UnitIndex                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x090), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A2222A8 0x90 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x098), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A2222C8 0x98 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
