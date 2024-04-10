using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 CgBase                                   000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 068 ImgChara                                 000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 070 ImgFrame                                 000186613440 ModelClassType RawImage RawImage RawImage Pointer
    // 078 BtnChara                                 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 080 Friend                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 LevelText                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 CgSetCharacter                           000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 098 BtnSetCharacter                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0A0 CgFriendWasToBeSelected                  000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A8 GoFriendSettings                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 GoGoodSchedule                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 TxtGoodSchedule                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 GoSelectedCursor                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 CgBadgeUpperLabelSetting                 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0D0 CgBadgeUpperLabelBuiltInto               000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0D8 CgBadgeUpperLabelFavorite                000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0E0 CgBadge                                  000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0E8 GrayOutController                        0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 0F0 onClickSubject                           Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0F8 onLongPressSubject                       Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 100 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 108 FavoriteDisposable                       0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class SCharaIconRectView : DataModel
    {
        public CanvasGroup?                             CgBase                                  { get; set; }
        public RawImage?                                ImgChara                                { get; set; }
        public RawImage?                                ImgFrame                                { get; set; }
        public UIButton?                                BtnChara                                { get; set; }
        public GameObject?                              Friend                                  { get; set; }
        public GameObject?                              LevelText                               { get; set; }
        public CanvasGroup?                             CgSetCharacter                          { get; set; }
        public UIButton?                                BtnSetCharacter                         { get; set; }
        public CanvasGroup?                             CgFriendWasToBeSelected                 { get; set; }
        public GameObject?                              GoFriendSettings                        { get; set; }
        public GameObject?                              GoGoodSchedule                          { get; set; }
        public UITextMeshProUGUI?                       TxtGoodSchedule                         { get; set; }
        public GameObject?                              GoSelectedCursor                        { get; set; }
        public CanvasGroup?                             CgBadgeUpperLabelSetting                { get; set; }
        public CanvasGroup?                             CgBadgeUpperLabelBuiltInto              { get; set; }
        public CanvasGroup?                             CgBadgeUpperLabelFavorite               { get; set; }
        public CanvasGroup?                             CgBadge                                 { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public int                                      Index                                   { get; set; }
        public IDisposable?                             FavoriteDisposable                      { get; set; }

        public static SCharaIconRectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaIconRectView() { Pointer= p0 };

            value.CgBase                                    = GetObject<CanvasGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665499CE8 0x60 CgBase                      ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgChara                                  = GetObject<RawImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.RawImage.FromPointer); // 024665499D08 0x68 ImgChara                    ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgFrame                                  = GetObject<RawImage>(new IntPtr(p + 0x070), ReversePrism.DataModels.RawImage.FromPointer); // 024665499D28 0x70 ImgFrame                    ( 000186613440 ModelClassType RawImage RawImage RawImage Pointer )
            value.BtnChara                                  = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 024665499D48 0x78 BtnChara                    ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Friend                                    = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 024665499D68 0x80 Friend                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LevelText                                 = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 024665499D88 0x88 LevelText                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CgSetCharacter                            = GetObject<CanvasGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665499DA8 0x90 CgSetCharacter              ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.BtnSetCharacter                           = GetObject<UIButton>(new IntPtr(p + 0x098), ReversePrism.DataModels.UIButton.FromPointer); // 024665499DC8 0x98 BtnSetCharacter             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CgFriendWasToBeSelected                   = GetObject<CanvasGroup>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665499DE8 0xA0 CgFriendWasToBeSelected     ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoFriendSettings                          = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 024665499E08 0xA8 GoFriendSettings            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoGoodSchedule                            = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 024665499E28 0xB0 GoGoodSchedule              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtGoodSchedule                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665499E48 0xB8 TxtGoodSchedule             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoSelectedCursor                          = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 024665499E68 0xC0 GoSelectedCursor            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CgBadgeUpperLabelSetting                  = GetObject<CanvasGroup>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665499E88 0xC8 CgBadgeUpperLabelSetting    ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgBadgeUpperLabelBuiltInto                = GetObject<CanvasGroup>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665499EA8 0xD0 CgBadgeUpperLabelBuiltInto  ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgBadgeUpperLabelFavorite                 = GetObject<CanvasGroup>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665499EC8 0xD8 CgBadgeUpperLabelFavorite   ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgBadge                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665499EE8 0xE0 CgBadge                     ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 024665499F08 0xE8 GrayOutController           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x100)); // 024665499F68 0x100 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FavoriteDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x108), ReversePrism.DataModels.IDisposable.FromPointer); // 024665499F88 0x108 FavoriteDisposable          ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
