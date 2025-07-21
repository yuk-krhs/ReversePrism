using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Background                               ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer
    // 028 ProfileIconImage                         ModelClassType UIImage UIImage UIImage Pointer
    // 030 UserNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 UnitNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 CommentText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ScreenFader                              ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 050 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class ChainProfileScreenView : DataModel
    {
        public MobileScreenBackground?                  Background                              { get; set; }
        public UIImage?                                 ProfileIconImage                        { get; set; }
        public UITextMeshProUGUI?                       UserNameText                            { get; set; }
        public UITextMeshProUGUI?                       UnitNameText                            { get; set; }
        public UITextMeshProUGUI?                       CommentText                             { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ChainProfileScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainProfileScreenView() { Pointer= p0 };

            value.Background                                = GetObject<MobileScreenBackground>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenBackground.FromPointer); // 0x20 Background                  ( ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer )
            value.ProfileIconImage                          = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 ProfileIconImage            ( ModelClassType UIImage UIImage UIImage Pointer )
            value.UserNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 UserNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UnitNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 UnitNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CommentText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 CommentText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x048), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0x48 ScreenFader                 ( ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x50 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
