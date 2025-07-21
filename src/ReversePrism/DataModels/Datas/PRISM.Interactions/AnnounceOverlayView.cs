using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 CategoryTabTemplate                      ModelClassType UITabButton UITabButton UITabButton Pointer
    // 030 ListView                                 ModelClassType AnnounceListView AnnounceListView AnnounceListView Pointer
    // 038 TxtDataNothing                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BannerIcons                              ModelClassListType BannerPair[] BannerPair[] List<BannerPair> Pointer
    // 048 PictgramIcons                            ModelClassListType PictgramPair[] PictgramPair[] List<PictgramPair> Pointer
    // 050 BackButton                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 bannerImages                             Dictionary`2<AnnounceCategory, Texture2D> IL2CPP_TYPE_GENERICINST
    // 060 pictogramImages                          Dictionary`2<AnnounceCategory, Sprite> IL2CPP_TYPE_GENERICINST
    // 068 ViewModel                                ModelClassType AnnounceOverlayViewModel AnnounceOverlayViewModel AnnounceOverlayViewModel Pointer
    // 070 LastSelectCategory                       ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32
    public partial class AnnounceOverlayView : DataModel
    {
        public UITabGroup?                              TabGroup                                { get; set; }
        public UITabButton?                             CategoryTabTemplate                     { get; set; }
        public AnnounceListView?                        ListView                                { get; set; }
        public UITextMeshProUGUI?                       TxtDataNothing                          { get; set; }
        public List<BannerPair>?                        BannerIcons                             { get; set; }
        public List<PictgramPair>?                      PictgramIcons                           { get; set; }
        public ButtonBase?                              BackButton                              { get; set; }
        public AnnounceOverlayViewModel?                ViewModel                               { get; set; }
        public AnnounceCategory                         LastSelectCategory                      { get; set; }

        public static AnnounceOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceOverlayView() { Pointer= p0 };

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.CategoryTabTemplate                       = GetObject<UITabButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabButton.FromPointer); // 0x28 CategoryTabTemplate         ( ModelClassType UITabButton UITabButton UITabButton Pointer )
            value.ListView                                  = GetObject<AnnounceListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnnounceListView.FromPointer); // 0x30 ListView                    ( ModelClassType AnnounceListView AnnounceListView AnnounceListView Pointer )
            value.TxtDataNothing                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtDataNothing              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BannerIcons                               = GetObjectList<BannerPair>(new IntPtr(p + 0x040), ReversePrism.DataModels.BannerPair.FromPointer); // 0x40 BannerIcons                 ( ModelClassListType BannerPair[] BannerPair[] List<BannerPair> Pointer )
            value.PictgramIcons                             = GetObjectList<PictgramPair>(new IntPtr(p + 0x048), ReversePrism.DataModels.PictgramPair.FromPointer); // 0x48 PictgramIcons               ( ModelClassListType PictgramPair[] PictgramPair[] List<PictgramPair> Pointer )
            value.BackButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x50 BackButton                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ViewModel                                 = GetObject<AnnounceOverlayViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.AnnounceOverlayViewModel.FromPointer); // 0x68 ViewModel                   ( ModelClassType AnnounceOverlayViewModel AnnounceOverlayViewModel AnnounceOverlayViewModel Pointer )
            value.LastSelectCategory                        = (AnnounceCategory)GetInt32(new IntPtr(p + 0x070)); // 0x70 LastSelectCategory          ( ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32 )

            return value;
        }
    }
}
