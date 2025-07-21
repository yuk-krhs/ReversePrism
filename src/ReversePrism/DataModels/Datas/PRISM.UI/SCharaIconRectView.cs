using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 CgBase                                   ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 068 ImgChara                                 ModelClassType RawImage RawImage RawImage Pointer
    // 070 ImgFrame                                 ModelClassType RawImage RawImage RawImage Pointer
    // 078 BtnChara                                 ModelClassType UIButton UIButton UIButton Pointer
    // 080 Friend                                   ModelClassType GameObject GameObject GameObject Pointer
    // 088 LevelText                                ModelClassType GameObject GameObject GameObject Pointer
    // 090 CgSetCharacter                           ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 098 BtnSetCharacter                          ModelClassType UIButton UIButton UIButton Pointer
    // 0A0 CgFriendWasToBeSelected                  ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A8 GoFriendSettings                         ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 GoGoodSchedule                           ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 TxtGoodSchedule                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 GoSelectedCursor                         ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 CgBadgeUpperLabelSetting                 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0D0 CgBadgeUpperLabelBuiltInto               ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0D8 CgBadgeUpperLabelFavorite                ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0E0 CgBadge                                  ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0E8 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 0F0 onClickSubject                           Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0F8 onLongPressSubject                       Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 100 Index                                    ModelPrimitiveType int int int Int32
    // 108 FavoriteDisposable                       ModelClassType IDisposable IDisposable IDisposable Pointer
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

            value.CgBase                                    = GetObject<CanvasGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x60 CgBase                      ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgChara                                  = GetObject<RawImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.RawImage.FromPointer); // 0x68 ImgChara                    ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgFrame                                  = GetObject<RawImage>(new IntPtr(p + 0x070), ReversePrism.DataModels.RawImage.FromPointer); // 0x70 ImgFrame                    ( ModelClassType RawImage RawImage RawImage Pointer )
            value.BtnChara                                  = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0x78 BtnChara                    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Friend                                    = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 Friend                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LevelText                                 = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 LevelText                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CgSetCharacter                            = GetObject<CanvasGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x90 CgSetCharacter              ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.BtnSetCharacter                           = GetObject<UIButton>(new IntPtr(p + 0x098), ReversePrism.DataModels.UIButton.FromPointer); // 0x98 BtnSetCharacter             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CgFriendWasToBeSelected                   = GetObject<CanvasGroup>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xA0 CgFriendWasToBeSelected     ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoFriendSettings                          = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0xA8 GoFriendSettings            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoGoodSchedule                            = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 0xB0 GoGoodSchedule              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtGoodSchedule                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB8 TxtGoodSchedule             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoSelectedCursor                          = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0xC0 GoSelectedCursor            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CgBadgeUpperLabelSetting                  = GetObject<CanvasGroup>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xC8 CgBadgeUpperLabelSetting    ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgBadgeUpperLabelBuiltInto                = GetObject<CanvasGroup>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xD0 CgBadgeUpperLabelBuiltInto  ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgBadgeUpperLabelFavorite                 = GetObject<CanvasGroup>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xD8 CgBadgeUpperLabelFavorite   ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgBadge                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xE0 CgBadge                     ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0xE8 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x100)); // 0x100 Index                       ( ModelPrimitiveType int int int Int32 )
            value.FavoriteDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x108), ReversePrism.DataModels.IDisposable.FromPointer); // 0x108 FavoriteDisposable          ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
