using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 CategoryTabTemplate                      0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer
    // 030 ListView                                 0001866C0950 ModelClassType AnnounceListView AnnounceListView AnnounceListView Pointer
    // 038 TxtDataNothing                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BannerIcons                              000185CB6108 ModelClassListType BannerPair[] BannerPair[] List<BannerPair> Pointer
    // 048 PictgramIcons                            000185CB61D8 ModelClassListType PictgramPair[] PictgramPair[] List<PictgramPair> Pointer
    // 050 BackButton                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 bannerImages                             Dictionary`2<AnnounceCategory, Texture2D> IL2CPP_TYPE_GENERICINST
    // 060 pictogramImages                          Dictionary`2<AnnounceCategory, Sprite> IL2CPP_TYPE_GENERICINST
    // 068 ViewModel                                0001866C21B0 ModelClassType AnnounceOverlayViewModel AnnounceOverlayViewModel AnnounceOverlayViewModel Pointer
    // 070 LastSelectCategory                       0001865EA390 ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32
    public partial class AnnounceOverlayView
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
            var value   = new AnnounceOverlayView();

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DBDDAFC8 0x20 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.CategoryTabTemplate                       = GetObject<UITabButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabButton.FromPointer); // 0270DBDDAFE8 0x28 CategoryTabTemplate         ( 0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer )
            value.ListView                                  = GetObject<AnnounceListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnnounceListView.FromPointer); // 0270DBDDB008 0x30 ListView                    ( 0001866C0950 ModelClassType AnnounceListView AnnounceListView AnnounceListView Pointer )
            value.TxtDataNothing                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDDB028 0x38 TxtDataNothing              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BannerIcons                               = GetObjectList<BannerPair>(new IntPtr(p + 0x040), ReversePrism.DataModels.BannerPair.FromPointer); // 0270DBDDB048 0x40 BannerIcons                 ( 000185CB6108 ModelClassListType BannerPair[] BannerPair[] List<BannerPair> Pointer )
            value.PictgramIcons                             = GetObjectList<PictgramPair>(new IntPtr(p + 0x048), ReversePrism.DataModels.PictgramPair.FromPointer); // 0270DBDDB068 0x48 PictgramIcons               ( 000185CB61D8 ModelClassListType PictgramPair[] PictgramPair[] List<PictgramPair> Pointer )
            value.BackButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270DBDDB088 0x50 BackButton                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ViewModel                                 = GetObject<AnnounceOverlayViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.AnnounceOverlayViewModel.FromPointer); // 0270DBDDB0E8 0x68 ViewModel                   ( 0001866C21B0 ModelClassType AnnounceOverlayViewModel AnnounceOverlayViewModel AnnounceOverlayViewModel Pointer )
            value.LastSelectCategory                        = (AnnounceCategory)GetInt32(new IntPtr(p + 0x070)); // 0270DBDDB108 0x70 LastSelectCategory          ( 0001865EA390 ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32 )

            return value;
        }
    }
}
