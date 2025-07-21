using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType ViewProducePreparationIdolSelectView ViewProducePreparationIdolSelectView ViewProducePreparationIdolSelectView Pointer
    // 028 FesDataPossessionLimitCheckerCaller      ModelClassType IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller Pointer
    // 030 IndicatorOriginal                        ModelClassType Toggle Toggle Toggle Pointer
    // 038 StatusOpenTarget                         ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 StatusToggle                             ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 048 StatusOpenIcon                           ModelClassType UIImage UIImage UIImage Pointer
    // 050 StatusCloseIcon                          ModelClassType UIImage UIImage UIImage Pointer
    // 058 SwipeToggle                              ModelClassType SwipeToggle SwipeToggle SwipeToggle Pointer
    // 060 ProducePreparationEpisodeDetailPopupContent ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 068 ProducePreparationIdolSelectPopupContent ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 070 SubSeasonDetailPopupContent              ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 078 IngameTutorialPopupContent               ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 080 onClickStatusToggleSubject               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 IsStatusOpen                             ModelPrimitiveType bool bool bool Bool
    // 090 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class ProduceIdolSelectView : DataModel
    {
        public ViewProducePreparationIdolSelectView?    View                                    { get; set; }
        public IFesDataPossessionLimitCheckerCaller?    FesDataPossessionLimitCheckerCaller     { get; set; }
        public Toggle?                                  IndicatorOriginal                       { get; set; }
        public RectTransform?                           StatusOpenTarget                        { get; set; }
        public ToggleButton?                            StatusToggle                            { get; set; }
        public UIImage?                                 StatusOpenIcon                          { get; set; }
        public UIImage?                                 StatusCloseIcon                         { get; set; }
        public SwipeToggle?                             SwipeToggle                             { get; set; }
        public PopupContentBase?                        ProducePreparationEpisodeDetailPopupContent { get; set; }
        public PopupContentBase?                        ProducePreparationIdolSelectPopupContent { get; set; }
        public PopupContentBase?                        SubSeasonDetailPopupContent             { get; set; }
        public PopupContentBase?                        IngameTutorialPopupContent              { get; set; }
        public bool                                     IsStatusOpen                            { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ProduceIdolSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolSelectView() { Pointer= p0 };

            value.View                                      = GetObject<ViewProducePreparationIdolSelectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ViewProducePreparationIdolSelectView.FromPointer); // 0x20 View                        ( ModelClassType ViewProducePreparationIdolSelectView ViewProducePreparationIdolSelectView ViewProducePreparationIdolSelectView Pointer )
            value.FesDataPossessionLimitCheckerCaller       = GetObject<IFesDataPossessionLimitCheckerCaller>(new IntPtr(p + 0x028), ReversePrism.DataModels.IFesDataPossessionLimitCheckerCaller.FromPointer); // 0x28 FesDataPossessionLimitCheckerCaller ( ModelClassType IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller Pointer )
            value.IndicatorOriginal                         = GetObject<Toggle>(new IntPtr(p + 0x030), ReversePrism.DataModels.Toggle.FromPointer); // 0x30 IndicatorOriginal           ( ModelClassType Toggle Toggle Toggle Pointer )
            value.StatusOpenTarget                          = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 StatusOpenTarget            ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.StatusToggle                              = GetObject<ToggleButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x40 StatusToggle                ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.StatusOpenIcon                            = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 0x48 StatusOpenIcon              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.StatusCloseIcon                           = GetObject<UIImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIImage.FromPointer); // 0x50 StatusCloseIcon             ( ModelClassType UIImage UIImage UIImage Pointer )
            value.SwipeToggle                               = GetObject<SwipeToggle>(new IntPtr(p + 0x058), ReversePrism.DataModels.SwipeToggle.FromPointer); // 0x58 SwipeToggle                 ( ModelClassType SwipeToggle SwipeToggle SwipeToggle Pointer )
            value.ProducePreparationEpisodeDetailPopupContent = GetObject<PopupContentBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0x60 ProducePreparationEpisodeDetailPopupContent ( ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.ProducePreparationIdolSelectPopupContent  = GetObject<PopupContentBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0x68 ProducePreparationIdolSelectPopupContent ( ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.SubSeasonDetailPopupContent               = GetObject<PopupContentBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0x70 SubSeasonDetailPopupContent ( ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.IngameTutorialPopupContent                = GetObject<PopupContentBase>(new IntPtr(p + 0x078), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0x78 IngameTutorialPopupContent  ( ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.IsStatusOpen                              = GetBool(new IntPtr(p + 0x088)); // 0x88 IsStatusOpen                ( ModelPrimitiveType bool bool bool Bool )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x090), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x90 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
