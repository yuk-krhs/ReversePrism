using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 EventTitleText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 EventSpriteImage                         0001866CCDB0 ModelClassType Image Image Image Pointer
    // 050 ExpiryDate                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ProfileEventArchiveListViewCell : DataModel
    {
        public UITextMeshProUGUI?                       EventTitleText                          { get; set; }
        public Image?                                   EventSpriteImage                        { get; set; }
        public UITextMeshProUGUI?                       ExpiryDate                              { get; set; }

        public static ProfileEventArchiveListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEventArchiveListViewCell() { Pointer= p0 };

            value.EventTitleText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E3B0 0x40 EventTitleText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventSpriteImage                          = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 02466B76E3D0 0x48 EventSpriteImage            ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ExpiryDate                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E3F0 0x50 ExpiryDate                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
