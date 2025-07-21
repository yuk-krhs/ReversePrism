using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Cell                                     ModelClassType StoryLastCategoryCell StoryLastCategoryCell StoryLastCategoryCell Pointer
    // 028 MainText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 DownloadRecommendationText               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 onCloseRequested                         Subject`1<StoryContinuousPlayConfirmationPopupResult> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    // 048 ViewModel                                ModelClassType StoryContinuousPlayConfirmationPopupViewModel StoryContinuousPlayConfirmationPopupViewModel StoryContinuousPlayConfirmationPopupViewModel Pointer
    // 050 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class StoryContinuousPlayConfirmationPopupView : DataModel
    {
        public StoryLastCategoryCell?                   Cell                                    { get; set; }
        public UITextMeshProUGUI?                       MainText                                { get; set; }
        public UITextMeshProUGUI?                       DownloadRecommendationText              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }
        public StoryContinuousPlayConfirmationPopupViewModel? ViewModel                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static StoryContinuousPlayConfirmationPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryContinuousPlayConfirmationPopupView() { Pointer= p0 };

            value.Cell                                      = GetObject<StoryLastCategoryCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryLastCategoryCell.FromPointer); // 0x20 Cell                        ( ModelClassType StoryLastCategoryCell StoryLastCategoryCell StoryLastCategoryCell Pointer )
            value.MainText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 MainText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DownloadRecommendationText                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 DownloadRecommendationText  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x40 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )
            value.ViewModel                                 = GetObject<StoryContinuousPlayConfirmationPopupViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.StoryContinuousPlayConfirmationPopupViewModel.FromPointer); // 0x48 ViewModel                   ( ModelClassType StoryContinuousPlayConfirmationPopupViewModel StoryContinuousPlayConfirmationPopupViewModel StoryContinuousPlayConfirmationPopupViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x50 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
