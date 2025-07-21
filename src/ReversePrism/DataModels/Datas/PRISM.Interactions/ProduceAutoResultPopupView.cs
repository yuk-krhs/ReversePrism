using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitIcon                                 ModelClassType UIImage UIImage UIImage Pointer
    // 028 EpisodeTitleText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 DifficultyText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 DifficultyBg                             ModelClassType Graphic Graphic Graphic Pointer
    // 040 EpisodeGraphicController                 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 048 MiniCharaOffScreen                       ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 050 LeftButtonGrayOutController              ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 058 RightButtonGrayOutController             ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 060 AutoToggleButton                         ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 068 ProduceLogButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 070 ProduceOptionButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 078 LeftCanvasGroup                          ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 080 RightCanvasGroup                         ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 088 OneSeasonScheduleListView                ModelClassType ProduceAutoOneSeasonScheduleListView ProduceAutoOneSeasonScheduleListView ProduceAutoOneSeasonScheduleListView Pointer
    // 090 Model3dLoader                            ModelClassType SimpleModel3dLoader SimpleModel3dLoader SimpleModel3dLoader Pointer
    // 098 onClickNextButtonSubject                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A0 onClickAutoToggleSubject                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 0A8 onClickProduceLogButtonSubject           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0B0 onClickProduceOptionButtonSubject        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0B8 MiniCharaCameraController                ModelClassType CameraController CameraController CameraController Pointer
    // 0C0 MinNextScheduleWaitTime                  ModelPrimitiveType float float float Single
    // 0C4 LastScheduleExecTime                     ModelPrimitiveType float float float Single
    // 0C8 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceAutoResultPopupView : DataModel
    {
        public UIImage?                                 UnitIcon                                { get; set; }
        public UITextMeshProUGUI?                       EpisodeTitleText                        { get; set; }
        public UITextMeshProUGUI?                       DifficultyText                          { get; set; }
        public Graphic?                                 DifficultyBg                            { get; set; }
        public UIGrayOutController?                     EpisodeGraphicController                { get; set; }
        public UIRawImage?                              MiniCharaOffScreen                      { get; set; }
        public UIGrayOutController?                     LeftButtonGrayOutController             { get; set; }
        public UIGrayOutController?                     RightButtonGrayOutController            { get; set; }
        public ToggleButton?                            AutoToggleButton                        { get; set; }
        public UIButton?                                ProduceLogButton                        { get; set; }
        public UIButton?                                ProduceOptionButton                     { get; set; }
        public CanvasGroup?                             LeftCanvasGroup                         { get; set; }
        public CanvasGroup?                             RightCanvasGroup                        { get; set; }
        public ProduceAutoOneSeasonScheduleListView?    OneSeasonScheduleListView               { get; set; }
        public SimpleModel3dLoader?                     Model3dLoader                           { get; set; }
        public CameraController?                        MiniCharaCameraController               { get; set; }
        public float                                    MinNextScheduleWaitTime                 { get; set; }
        public float                                    LastScheduleExecTime                    { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceAutoResultPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoResultPopupView() { Pointer= p0 };

            value.UnitIcon                                  = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 UnitIcon                    ( ModelClassType UIImage UIImage UIImage Pointer )
            value.EpisodeTitleText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 EpisodeTitleText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DifficultyText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 DifficultyText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DifficultyBg                              = GetObject<Graphic>(new IntPtr(p + 0x038), ReversePrism.DataModels.Graphic.FromPointer); // 0x38 DifficultyBg                ( ModelClassType Graphic Graphic Graphic Pointer )
            value.EpisodeGraphicController                  = GetObject<UIGrayOutController>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x40 EpisodeGraphicController    ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.MiniCharaOffScreen                        = GetObject<UIRawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x48 MiniCharaOffScreen          ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.LeftButtonGrayOutController               = GetObject<UIGrayOutController>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x50 LeftButtonGrayOutController ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.RightButtonGrayOutController              = GetObject<UIGrayOutController>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x58 RightButtonGrayOutController ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.AutoToggleButton                          = GetObject<ToggleButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x60 AutoToggleButton            ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.ProduceLogButton                          = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 ProduceLogButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ProduceOptionButton                       = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 ProduceOptionButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.LeftCanvasGroup                           = GetObject<CanvasGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x78 LeftCanvasGroup             ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.RightCanvasGroup                          = GetObject<CanvasGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x80 RightCanvasGroup            ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.OneSeasonScheduleListView                 = GetObject<ProduceAutoOneSeasonScheduleListView>(new IntPtr(p + 0x088), ReversePrism.DataModels.ProduceAutoOneSeasonScheduleListView.FromPointer); // 0x88 OneSeasonScheduleListView   ( ModelClassType ProduceAutoOneSeasonScheduleListView ProduceAutoOneSeasonScheduleListView ProduceAutoOneSeasonScheduleListView Pointer )
            value.Model3dLoader                             = GetObject<SimpleModel3dLoader>(new IntPtr(p + 0x090), ReversePrism.DataModels.SimpleModel3dLoader.FromPointer); // 0x90 Model3dLoader               ( ModelClassType SimpleModel3dLoader SimpleModel3dLoader SimpleModel3dLoader Pointer )
            value.MiniCharaCameraController                 = GetObject<CameraController>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.CameraController.FromPointer); // 0xB8 MiniCharaCameraController   ( ModelClassType CameraController CameraController CameraController Pointer )
            value.MinNextScheduleWaitTime                   = GetSingle(new IntPtr(p + 0x0C0)); // 0xC0 MinNextScheduleWaitTime     ( ModelPrimitiveType float float float Single )
            value.LastScheduleExecTime                      = GetSingle(new IntPtr(p + 0x0C4)); // 0xC4 LastScheduleExecTime        ( ModelPrimitiveType float float float Single )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0xC8 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
