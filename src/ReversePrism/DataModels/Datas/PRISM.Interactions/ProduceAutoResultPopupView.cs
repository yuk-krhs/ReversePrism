using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitIcon                                 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 EpisodeTitleText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 DifficultyText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 DifficultyBg                             0001866920B0 ModelClassType Graphic Graphic Graphic Pointer
    // 040 EpisodeGraphicController                 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 048 MiniCharaOffScreen                       0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 050 ButtonGrayOutController                  0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 058 AutoToggleButton                         000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 060 ProduceLogButton                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 070 OneSeasonScheduleListView                00018652C490 ModelClassType ProduceAutoOneSeasonScheduleListView ProduceAutoOneSeasonScheduleListView ProduceAutoOneSeasonScheduleListView Pointer
    // 078 ProduceLogPopupViewFactory               00018655E460 ModelClassType ProduceLogPopupViewFactory ProduceLogPopupViewFactory ProduceLogPopupViewFactory Pointer
    // 080 onClickNextButtonSubject                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 onClickAutoToggleSubject                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 090 onClickProduceLogButtonSubject           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 098 MiniCharaCameraController                000186536460 ModelClassType CameraController CameraController CameraController Pointer
    // 0A0 MinNextScheduleWaitTime                  0001866656B0 ModelPrimitiveType float float float Single
    // 0A4 LastScheduleExecTime                     0001866656B0 ModelPrimitiveType float float float Single
    // 0A8 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 0B0 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceAutoResultPopupView : DataModel
    {
        public UIImage?                                 UnitIcon                                { get; set; }
        public UITextMeshProUGUI?                       EpisodeTitleText                        { get; set; }
        public UITextMeshProUGUI?                       DifficultyText                          { get; set; }
        public Graphic?                                 DifficultyBg                            { get; set; }
        public UIGrayOutController?                     EpisodeGraphicController                { get; set; }
        public UIRawImage?                              MiniCharaOffScreen                      { get; set; }
        public UIGrayOutController?                     ButtonGrayOutController                 { get; set; }
        public ToggleButton?                            AutoToggleButton                        { get; set; }
        public UIButton?                                ProduceLogButton                        { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public ProduceAutoOneSeasonScheduleListView?    OneSeasonScheduleListView               { get; set; }
        public ProduceLogPopupViewFactory?              ProduceLogPopupViewFactory              { get; set; }
        public CameraController?                        MiniCharaCameraController               { get; set; }
        public float                                    MinNextScheduleWaitTime                 { get; set; }
        public float                                    LastScheduleExecTime                    { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceAutoResultPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoResultPopupView() { Pointer= p0 };

            value.UnitIcon                                  = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 02466A123378 0x20 UnitIcon                    ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.EpisodeTitleText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A123398 0x28 EpisodeTitleText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DifficultyText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A1233B8 0x30 DifficultyText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DifficultyBg                              = GetObject<Graphic>(new IntPtr(p + 0x038), ReversePrism.DataModels.Graphic.FromPointer); // 02466A1233D8 0x38 DifficultyBg                ( 0001866920B0 ModelClassType Graphic Graphic Graphic Pointer )
            value.EpisodeGraphicController                  = GetObject<UIGrayOutController>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 02466A1233F8 0x40 EpisodeGraphicController    ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.MiniCharaOffScreen                        = GetObject<UIRawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A123418 0x48 MiniCharaOffScreen          ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.ButtonGrayOutController                   = GetObject<UIGrayOutController>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 02466A123438 0x50 ButtonGrayOutController     ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.AutoToggleButton                          = GetObject<ToggleButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.ToggleButton.FromPointer); // 02466A123458 0x58 AutoToggleButton            ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.ProduceLogButton                          = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 02466A123478 0x60 ProduceLogButton            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x068), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A123498 0x68 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.OneSeasonScheduleListView                 = GetObject<ProduceAutoOneSeasonScheduleListView>(new IntPtr(p + 0x070), ReversePrism.DataModels.ProduceAutoOneSeasonScheduleListView.FromPointer); // 02466A1234B8 0x70 OneSeasonScheduleListView   ( 00018652C490 ModelClassType ProduceAutoOneSeasonScheduleListView ProduceAutoOneSeasonScheduleListView ProduceAutoOneSeasonScheduleListView Pointer )
            value.ProduceLogPopupViewFactory                = GetObject<ProduceLogPopupViewFactory>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProduceLogPopupViewFactory.FromPointer); // 02466A1234D8 0x78 ProduceLogPopupViewFactory  ( 00018655E460 ModelClassType ProduceLogPopupViewFactory ProduceLogPopupViewFactory ProduceLogPopupViewFactory Pointer )
            value.MiniCharaCameraController                 = GetObject<CameraController>(new IntPtr(p + 0x098), ReversePrism.DataModels.CameraController.FromPointer); // 02466A123558 0x98 MiniCharaCameraController   ( 000186536460 ModelClassType CameraController CameraController CameraController Pointer )
            value.MinNextScheduleWaitTime                   = GetSingle(new IntPtr(p + 0x0A0)); // 02466A123578 0xA0 MinNextScheduleWaitTime     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LastScheduleExecTime                      = GetSingle(new IntPtr(p + 0x0A4)); // 02466A123598 0xA4 LastScheduleExecTime        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A1235B8 0xA8 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A1235D8 0xB0 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
