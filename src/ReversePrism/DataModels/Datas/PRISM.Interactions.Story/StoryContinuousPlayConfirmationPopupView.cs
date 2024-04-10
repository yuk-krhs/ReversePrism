using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Cell                                     000186598130 ModelClassType StoryLastCategoryCell StoryLastCategoryCell StoryLastCategoryCell Pointer
    // 028 MainText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 DownloadRecommendationText               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 onCloseRequested                         Subject`1<StoryContinuousPlayConfirmationPopupResult> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    // 048 ViewModel                                000186595E80 ModelClassType StoryContinuousPlayConfirmationPopupViewModel StoryContinuousPlayConfirmationPopupViewModel StoryContinuousPlayConfirmationPopupViewModel Pointer
    // 050 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
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

            value.Cell                                      = GetObject<StoryLastCategoryCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryLastCategoryCell.FromPointer); // 02466B9E9B98 0x20 Cell                        ( 000186598130 ModelClassType StoryLastCategoryCell StoryLastCategoryCell StoryLastCategoryCell Pointer )
            value.MainText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9E9BB8 0x28 MainText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DownloadRecommendationText                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9E9BD8 0x30 DownloadRecommendationText  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B9E9C18 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )
            value.ViewModel                                 = GetObject<StoryContinuousPlayConfirmationPopupViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.StoryContinuousPlayConfirmationPopupViewModel.FromPointer); // 02466B9E9C38 0x48 ViewModel                   ( 000186595E80 ModelClassType StoryContinuousPlayConfirmationPopupViewModel StoryContinuousPlayConfirmationPopupViewModel StoryContinuousPlayConfirmationPopupViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceLoader.FromPointer); // 02466B9E9C58 0x50 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
