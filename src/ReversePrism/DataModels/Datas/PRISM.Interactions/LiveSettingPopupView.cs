using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LiveSettingTabGroup                      ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 028 TabViews                                 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 Preview                                  ModelClassType LiveSettingPreviewPresenter LiveSettingPreviewPresenter LiveSettingPreviewPresenter Pointer
    // 038 LiveTab                                  ModelClassType LiveSettingLiveTabView LiveSettingLiveTabView LiveSettingLiveTabView Pointer
    // 040 DetailTab                                ModelClassType LiveSettingDetailTabView LiveSettingDetailTabView LiveSettingDetailTabView Pointer
    // 048 SoundTab                                 ModelClassType LiveSettingSoundTabView LiveSettingSoundTabView LiveSettingSoundTabView Pointer
    // 050 NoteOffsetSettingButton                  ModelClassType UIButton UIButton UIButton Pointer
    // 058 DisableOnRhythmGameObjects               ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 ShinyLockedButtons                       ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer
    // 068 Option                                   ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 070 Loader                                   ModelClassType RhythmGameLoader RhythmGameLoader RhythmGameLoader Pointer
    // 078 BgmCueSheet                              ModelPrimitiveType string string string String
    // 080 BgmCueName                               ModelPrimitiveType string string string String
    // 088 InitialBgmStatus                         ModelEnumType Status Status Status Int32
    // 000 PreviewCueSheet                          string IL2CPP_TYPE_STRING
    // 000 PreviewCueName                           string IL2CPP_TYPE_STRING
    // 08C IsCallFromRhythmGame                     ModelPrimitiveType bool bool bool Bool
    // 090 RhythmGameCueSheetName                   ModelPrimitiveType string string string String
    // 098 SizeType                                 ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32
    // 09C IsShinyEnabled                           ModelPrimitiveType bool bool bool Bool
    // 0A0 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A8 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class LiveSettingPopupView : DataModel
    {
        public UITabGroupEx?                            LiveSettingTabGroup                     { get; set; }
        public List<GameObject>?                        TabViews                                { get; set; }
        public LiveSettingPreviewPresenter?             Preview                                 { get; set; }
        public LiveSettingLiveTabView?                  LiveTab                                 { get; set; }
        public LiveSettingDetailTabView?                DetailTab                               { get; set; }
        public LiveSettingSoundTabView?                 SoundTab                                { get; set; }
        public UIButton?                                NoteOffsetSettingButton                 { get; set; }
        public List<GameObject>?                        DisableOnRhythmGameObjects              { get; set; }
        public List<UIButton>?                          ShinyLockedButtons                      { get; set; }
        public RhythmGameOption?                        Option                                  { get; set; }
        public RhythmGameLoader?                        Loader                                  { get; set; }
        public string                                   BgmCueSheet                             { get; set; }
        public string                                   BgmCueName                              { get; set; }
        public Status                                   InitialBgmStatus                        { get; set; }
        public bool                                     IsCallFromRhythmGame                    { get; set; }
        public string                                   RhythmGameCueSheetName                  { get; set; }
        public PopupSizeType                            SizeType                                { get; set; }
        public bool                                     IsShinyEnabled                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static LiveSettingPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSettingPopupView() { Pointer= p0 };

            value.LiveSettingTabGroup                       = GetObject<UITabGroupEx>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x20 LiveSettingTabGroup         ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.TabViews                                  = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 TabViews                    ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Preview                                   = GetObject<LiveSettingPreviewPresenter>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveSettingPreviewPresenter.FromPointer); // 0x30 Preview                     ( ModelClassType LiveSettingPreviewPresenter LiveSettingPreviewPresenter LiveSettingPreviewPresenter Pointer )
            value.LiveTab                                   = GetObject<LiveSettingLiveTabView>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveSettingLiveTabView.FromPointer); // 0x38 LiveTab                     ( ModelClassType LiveSettingLiveTabView LiveSettingLiveTabView LiveSettingLiveTabView Pointer )
            value.DetailTab                                 = GetObject<LiveSettingDetailTabView>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveSettingDetailTabView.FromPointer); // 0x40 DetailTab                   ( ModelClassType LiveSettingDetailTabView LiveSettingDetailTabView LiveSettingDetailTabView Pointer )
            value.SoundTab                                  = GetObject<LiveSettingSoundTabView>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveSettingSoundTabView.FromPointer); // 0x48 SoundTab                    ( ModelClassType LiveSettingSoundTabView LiveSettingSoundTabView LiveSettingSoundTabView Pointer )
            value.NoteOffsetSettingButton                   = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 NoteOffsetSettingButton     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.DisableOnRhythmGameObjects                = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 DisableOnRhythmGameObjects  ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ShinyLockedButtons                        = GetObjectList<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 ShinyLockedButtons          ( ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer )
            value.Option                                    = GetObject<RhythmGameOption>(new IntPtr(p + 0x068), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 0x68 Option                      ( ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )
            value.Loader                                    = GetObject<RhythmGameLoader>(new IntPtr(p + 0x070), ReversePrism.DataModels.RhythmGameLoader.FromPointer); // 0x70 Loader                      ( ModelClassType RhythmGameLoader RhythmGameLoader RhythmGameLoader Pointer )
            value.BgmCueSheet                               = GetString(new IntPtr(p + 0x078)); // 0x78 BgmCueSheet                 ( ModelPrimitiveType string string string String )
            value.BgmCueName                                = GetString(new IntPtr(p + 0x080)); // 0x80 BgmCueName                  ( ModelPrimitiveType string string string String )
            value.InitialBgmStatus                          = (Status)GetInt32(new IntPtr(p + 0x088)); // 0x88 InitialBgmStatus            ( ModelEnumType Status Status Status Int32 )
            value.IsCallFromRhythmGame                      = GetBool(new IntPtr(p + 0x08C)); // 0x8C IsCallFromRhythmGame        ( ModelPrimitiveType bool bool bool Bool )
            value.RhythmGameCueSheetName                    = GetString(new IntPtr(p + 0x090)); // 0x90 RhythmGameCueSheetName      ( ModelPrimitiveType string string string String )
            value.SizeType                                  = (PopupSizeType)GetInt32(new IntPtr(p + 0x098)); // 0x98 SizeType                    ( ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32 )
            value.IsShinyEnabled                            = GetBool(new IntPtr(p + 0x09C)); // 0x9C IsShinyEnabled              ( ModelPrimitiveType bool bool bool Bool )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0xA8 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
