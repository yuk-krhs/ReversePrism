using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabListView                              ModelClassType ProfileCategoryTabListView ProfileCategoryTabListView ProfileCategoryTabListView Pointer
    // 028 CloseButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 PanelViewObjects                         ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 UserSelfPanelView                        ModelClassType ProfileUserSelfPanelView ProfileUserSelfPanelView ProfileUserSelfPanelView Pointer
    // 040 ProgressPanelView                        ModelClassType ProfileProgressPanelView ProfileProgressPanelView ProfileProgressPanelView Pointer
    // 048 HistoryPanelView                         ModelClassType ProfileHistoryPanelView ProfileHistoryPanelView ProfileHistoryPanelView Pointer
    // 050 ViewModel                                ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer
    // 058 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 060 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class ProfileUserSelfOverlayView : DataModel
    {
        public ProfileCategoryTabListView?              TabListView                             { get; set; }
        public ButtonBase?                              CloseButton                             { get; set; }
        public List<GameObject>?                        PanelViewObjects                        { get; set; }
        public ProfileUserSelfPanelView?                UserSelfPanelView                       { get; set; }
        public ProfileProgressPanelView?                ProgressPanelView                       { get; set; }
        public ProfileHistoryPanelView?                 HistoryPanelView                        { get; set; }
        public ProfileUserSalfViewModel?                ViewModel                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ProfileUserSelfOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileUserSelfOverlayView() { Pointer= p0 };

            value.TabListView                               = GetObject<ProfileCategoryTabListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileCategoryTabListView.FromPointer); // 0x20 TabListView                 ( ModelClassType ProfileCategoryTabListView ProfileCategoryTabListView ProfileCategoryTabListView Pointer )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x28 CloseButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.PanelViewObjects                          = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 PanelViewObjects            ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.UserSelfPanelView                         = GetObject<ProfileUserSelfPanelView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfileUserSelfPanelView.FromPointer); // 0x38 UserSelfPanelView           ( ModelClassType ProfileUserSelfPanelView ProfileUserSelfPanelView ProfileUserSelfPanelView Pointer )
            value.ProgressPanelView                         = GetObject<ProfileProgressPanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileProgressPanelView.FromPointer); // 0x40 ProgressPanelView           ( ModelClassType ProfileProgressPanelView ProfileProgressPanelView ProfileProgressPanelView Pointer )
            value.HistoryPanelView                          = GetObject<ProfileHistoryPanelView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProfileHistoryPanelView.FromPointer); // 0x48 HistoryPanelView            ( ModelClassType ProfileHistoryPanelView ProfileHistoryPanelView ProfileHistoryPanelView Pointer )
            value.ViewModel                                 = GetObject<ProfileUserSalfViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProfileUserSalfViewModel.FromPointer); // 0x50 ViewModel                   ( ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0x58 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x060), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x60 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
