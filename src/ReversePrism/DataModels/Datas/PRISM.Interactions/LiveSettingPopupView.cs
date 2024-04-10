using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LiveSettingTabGroup                      0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 028 TabViews                                 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 Preview                                  00018657A690 ModelClassType LiveSettingPreviewPresenter LiveSettingPreviewPresenter LiveSettingPreviewPresenter Pointer
    // 038 LiveTab                                  000186579050 ModelClassType LiveSettingLiveTabView LiveSettingLiveTabView LiveSettingLiveTabView Pointer
    // 040 DetailTab                                000186578B30 ModelClassType LiveSettingDetailTabView LiveSettingDetailTabView LiveSettingDetailTabView Pointer
    // 048 SoundTab                                 00018657AE20 ModelClassType LiveSettingSoundTabView LiveSettingSoundTabView LiveSettingSoundTabView Pointer
    // 050 NoteOffsetSettingButton                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 DisableOnRhythmGameObjects               000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 audioOffsetSettingPopupViewFactory       PopupViewFactory`1<ILiveAudioOffsetSettingPopupView> IL2CPP_TYPE_GENERICINST
    // 068 Option                                   000186685720 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 070 BgmCueSheet                              000186671910 ModelPrimitiveType string string string String
    // 078 BgmCueName                               000186671910 ModelPrimitiveType string string string String
    // 080 InitialBgmStatus                         000186556760 ModelEnumType Status Status Status Int32
    // 088 BaseOnDestroyCt                          00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 000 PreviewCueSheet                          string IL2CPP_TYPE_STRING
    // 000 PreviewCueName                           string IL2CPP_TYPE_STRING
    // 090 IsCallFromRhythmGame                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 098 RhythmGameCueSheetName                   000186671910 ModelPrimitiveType string string string String
    // 0A0 SizeType                                 00018658C440 ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32
    // 0A8 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0B0 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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
        public RhythmGameOption?                        Option                                  { get; set; }
        public string                                   BgmCueSheet                             { get; set; }
        public string                                   BgmCueName                              { get; set; }
        public Status                                   InitialBgmStatus                        { get; set; }
        public CancellationToken                        BaseOnDestroyCt                         { get; set; }
        public bool                                     IsCallFromRhythmGame                    { get; set; }
        public string                                   RhythmGameCueSheetName                  { get; set; }
        public PopupSizeType                            SizeType                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static LiveSettingPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSettingPopupView() { Pointer= p0 };

            value.LiveSettingTabGroup                       = GetObject<UITabGroupEx>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 02466B48B928 0x20 LiveSettingTabGroup         ( 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.TabViews                                  = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466B48B948 0x28 TabViews                    ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Preview                                   = GetObject<LiveSettingPreviewPresenter>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveSettingPreviewPresenter.FromPointer); // 02466B48B968 0x30 Preview                     ( 00018657A690 ModelClassType LiveSettingPreviewPresenter LiveSettingPreviewPresenter LiveSettingPreviewPresenter Pointer )
            value.LiveTab                                   = GetObject<LiveSettingLiveTabView>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveSettingLiveTabView.FromPointer); // 02466B48B988 0x38 LiveTab                     ( 000186579050 ModelClassType LiveSettingLiveTabView LiveSettingLiveTabView LiveSettingLiveTabView Pointer )
            value.DetailTab                                 = GetObject<LiveSettingDetailTabView>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveSettingDetailTabView.FromPointer); // 02466B48B9A8 0x40 DetailTab                   ( 000186578B30 ModelClassType LiveSettingDetailTabView LiveSettingDetailTabView LiveSettingDetailTabView Pointer )
            value.SoundTab                                  = GetObject<LiveSettingSoundTabView>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveSettingSoundTabView.FromPointer); // 02466B48B9C8 0x48 SoundTab                    ( 00018657AE20 ModelClassType LiveSettingSoundTabView LiveSettingSoundTabView LiveSettingSoundTabView Pointer )
            value.NoteOffsetSettingButton                   = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 02466B48B9E8 0x50 NoteOffsetSettingButton     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.DisableOnRhythmGameObjects                = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 02466B48BA08 0x58 DisableOnRhythmGameObjects  ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Option                                    = GetObject<RhythmGameOption>(new IntPtr(p + 0x068), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 02466B48BA48 0x68 Option                      ( 000186685720 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )
            value.BgmCueSheet                               = GetString(new IntPtr(p + 0x070)); // 02466B48BA68 0x70 BgmCueSheet                 ( 000186671910 ModelPrimitiveType string string string String )
            value.BgmCueName                                = GetString(new IntPtr(p + 0x078)); // 02466B48BA88 0x78 BgmCueName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.InitialBgmStatus                          = (Status)GetInt32(new IntPtr(p + 0x080)); // 02466B48BAA8 0x80 InitialBgmStatus            ( 000186556760 ModelEnumType Status Status Status Int32 )
            value.BaseOnDestroyCt                           = (CancellationToken)GetInt32(new IntPtr(p + 0x088)); // 02466B48BAC8 0x88 BaseOnDestroyCt             ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.IsCallFromRhythmGame                      = GetBool(new IntPtr(p + 0x090)); // 02466B48BB28 0x90 IsCallFromRhythmGame        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RhythmGameCueSheetName                    = GetString(new IntPtr(p + 0x098)); // 02466B48BB48 0x98 RhythmGameCueSheetName      ( 000186671910 ModelPrimitiveType string string string String )
            value.SizeType                                  = (PopupSizeType)GetInt32(new IntPtr(p + 0x0A0)); // 02466B48BB68 0xA0 SizeType                    ( 00018658C440 ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32 )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B48BBA8 0xB0 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
