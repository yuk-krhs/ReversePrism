using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001865224E0 ModelClassType ViewProducePreparationIdolSelectView ViewProducePreparationIdolSelectView ViewProducePreparationIdolSelectView Pointer
    // 028 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 030 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 038 supportCharaUnitSetupFactory             PopupViewFactory`1<ISupportCharaUnitSetupPopupView> IL2CPP_TYPE_GENERICINST
    // 040 editPopupFactory                         PopupViewFactory`1<IEditUnitNamePopupView> IL2CPP_TYPE_GENERICINST
    // 048 ProduceSupportCharaSelectPopupViewFactory 000186588320 ModelClassType ProduceSupportCharaSelectPopupViewFactory ProduceSupportCharaSelectPopupViewFactory ProduceSupportCharaSelectPopupViewFactory Pointer
    // 050 AutoReleasedConfigRef                    000186671E00 ModelPrimitiveType string string string String
    // 058 InheritanceReleasedConfigRef             000186671E00 ModelPrimitiveType string string string String
    // 060 FesDataPossessionLimitCheckerCaller      000186777310 ModelClassType IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller Pointer
    // 068 IndicatorOriginal                        000186682710 ModelClassType Toggle Toggle Toggle Pointer
    // 070 StatusOpenTarget                         000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 078 StatusToggle                             000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 080 StatusOpenIcon                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 088 StatusCloseIcon                          0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 090 SwipeToggle                              0001865FCA50 ModelClassType SwipeToggle SwipeToggle SwipeToggle Pointer
    // 098 ProducePreparationConfirmPopupContent    000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 0A0 ProducePreparationEpisodeDetailPopupContent 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 0A8 ProducePreparationIdolSelectPopupContent 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 0B0 ProducePreparationSupportSelectPopupContent 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 0B8 ProducePreparationFriendSelectPopupContent 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 0C0 SubSeasonDetailPopupContent              000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 0C8 IngameTutorialPopupContent               000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 0D0 onClickStatusToggleSubject               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0D8 IsStatusOpen                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E0 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class ProduceIdolSelectView
    {
        public ViewProducePreparationIdolSelectView?    View                                    { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }
        public ProduceSupportCharaSelectPopupViewFactory? ProduceSupportCharaSelectPopupViewFactory { get; set; }
        public string                                   AutoReleasedConfigRef                   { get; set; }
        public string                                   InheritanceReleasedConfigRef            { get; set; }
        public IFesDataPossessionLimitCheckerCaller?    FesDataPossessionLimitCheckerCaller     { get; set; }
        public Toggle?                                  IndicatorOriginal                       { get; set; }
        public RectTransform?                           StatusOpenTarget                        { get; set; }
        public ToggleButton?                            StatusToggle                            { get; set; }
        public UIImage?                                 StatusOpenIcon                          { get; set; }
        public UIImage?                                 StatusCloseIcon                         { get; set; }
        public SwipeToggle?                             SwipeToggle                             { get; set; }
        public PopupContentBase?                        ProducePreparationConfirmPopupContent   { get; set; }
        public PopupContentBase?                        ProducePreparationEpisodeDetailPopupContent { get; set; }
        public PopupContentBase?                        ProducePreparationIdolSelectPopupContent { get; set; }
        public PopupContentBase?                        ProducePreparationSupportSelectPopupContent { get; set; }
        public PopupContentBase?                        ProducePreparationFriendSelectPopupContent { get; set; }
        public PopupContentBase?                        SubSeasonDetailPopupContent             { get; set; }
        public PopupContentBase?                        IngameTutorialPopupContent              { get; set; }
        public bool                                     IsStatusOpen                            { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ProduceIdolSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolSelectView();

            value.View                                      = GetObject<ViewProducePreparationIdolSelectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ViewProducePreparationIdolSelectView.FromPointer); // 0270DA135AF0 0x20 View                        ( 0001865224E0 ModelClassType ViewProducePreparationIdolSelectView ViewProducePreparationIdolSelectView ViewProducePreparationIdolSelectView Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x028), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270DA135B10 0x28 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0270DA135B30 0x30 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.ProduceSupportCharaSelectPopupViewFactory = GetObject<ProduceSupportCharaSelectPopupViewFactory>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceSupportCharaSelectPopupViewFactory.FromPointer); // 0270DA135B90 0x48 ProduceSupportCharaSelectPopupViewFactory ( 000186588320 ModelClassType ProduceSupportCharaSelectPopupViewFactory ProduceSupportCharaSelectPopupViewFactory ProduceSupportCharaSelectPopupViewFactory Pointer )
            value.AutoReleasedConfigRef                     = GetString(new IntPtr(p + 0x050)); // 0270DA135BB0 0x50 AutoReleasedConfigRef       ( 000186671E00 ModelPrimitiveType string string string String )
            value.InheritanceReleasedConfigRef              = GetString(new IntPtr(p + 0x058)); // 0270DA135BD0 0x58 InheritanceReleasedConfigRef ( 000186671E00 ModelPrimitiveType string string string String )
            value.FesDataPossessionLimitCheckerCaller       = GetObject<IFesDataPossessionLimitCheckerCaller>(new IntPtr(p + 0x060), ReversePrism.DataModels.IFesDataPossessionLimitCheckerCaller.FromPointer); // 0270DA135BF0 0x60 FesDataPossessionLimitCheckerCaller ( 000186777310 ModelClassType IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller Pointer )
            value.IndicatorOriginal                         = GetObject<Toggle>(new IntPtr(p + 0x068), ReversePrism.DataModels.Toggle.FromPointer); // 0270DA135C10 0x68 IndicatorOriginal           ( 000186682710 ModelClassType Toggle Toggle Toggle Pointer )
            value.StatusOpenTarget                          = GetObject<RectTransform>(new IntPtr(p + 0x070), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA135C30 0x70 StatusOpenTarget            ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.StatusToggle                              = GetObject<ToggleButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DA135C50 0x78 StatusToggle                ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.StatusOpenIcon                            = GetObject<UIImage>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA135C70 0x80 StatusOpenIcon              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.StatusCloseIcon                           = GetObject<UIImage>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA135C90 0x88 StatusCloseIcon             ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.SwipeToggle                               = GetObject<SwipeToggle>(new IntPtr(p + 0x090), ReversePrism.DataModels.SwipeToggle.FromPointer); // 0270DA135CB0 0x90 SwipeToggle                 ( 0001865FCA50 ModelClassType SwipeToggle SwipeToggle SwipeToggle Pointer )
            value.ProducePreparationConfirmPopupContent     = GetObject<PopupContentBase>(new IntPtr(p + 0x098), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270DA135CD0 0x98 ProducePreparationConfirmPopupContent ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.ProducePreparationEpisodeDetailPopupContent = GetObject<PopupContentBase>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270DA135CF0 0xA0 ProducePreparationEpisodeDetailPopupContent ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.ProducePreparationIdolSelectPopupContent  = GetObject<PopupContentBase>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270DA135D10 0xA8 ProducePreparationIdolSelectPopupContent ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.ProducePreparationSupportSelectPopupContent = GetObject<PopupContentBase>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270DA135D30 0xB0 ProducePreparationSupportSelectPopupContent ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.ProducePreparationFriendSelectPopupContent = GetObject<PopupContentBase>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270DA135D50 0xB8 ProducePreparationFriendSelectPopupContent ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.SubSeasonDetailPopupContent               = GetObject<PopupContentBase>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270DA135D70 0xC0 SubSeasonDetailPopupContent ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.IngameTutorialPopupContent                = GetObject<PopupContentBase>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270DA135D90 0xC8 IngameTutorialPopupContent  ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.IsStatusOpen                              = GetBool(new IntPtr(p + 0x0D8)); // 0270DA135DD0 0xD8 IsStatusOpen                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0270DA135DF0 0xE0 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
