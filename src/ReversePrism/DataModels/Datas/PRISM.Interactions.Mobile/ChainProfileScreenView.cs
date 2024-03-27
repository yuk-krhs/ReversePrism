using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Background                               0001866331A0 ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer
    // 028 ProfileIconImage                         0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 UserNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 UnitNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 CommentText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 050 ResourceLoader                           00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 058 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class ChainProfileScreenView
    {
        public MobileScreenBackground?                  Background                              { get; set; }
        public UIImage?                                 ProfileIconImage                        { get; set; }
        public UITextMeshProUGUI?                       UserNameText                            { get; set; }
        public UITextMeshProUGUI?                       UnitNameText                            { get; set; }
        public UITextMeshProUGUI?                       CommentText                             { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public ResourceLoader?                          ResourceLoader                          { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ChainProfileScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainProfileScreenView();

            value.Background                                = GetObject<MobileScreenBackground>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenBackground.FromPointer); // 0270DB0E4D48 0x20 Background                  ( 0001866331A0 ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer )
            value.ProfileIconImage                          = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB0E4D68 0x28 ProfileIconImage            ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.UserNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB0E4D88 0x30 UserNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UnitNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB0E4DA8 0x38 UnitNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CommentText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB0E4DC8 0x40 CommentText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x048), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0270DB0E4DE8 0x48 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.ResourceLoader.FromPointer); // 0270DB0E4E08 0x50 ResourceLoader              ( 00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x058), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB0E4E28 0x58 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
