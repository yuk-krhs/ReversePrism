using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OutFrameImage                            0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 NameText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 000 frameColorDic                            Dictionary`2<int, string> IL2CPP_TYPE_GENERICINST
    public partial class PFIdolCharacterNameView
    {
        public Image?                                   OutFrameImage                           { get; set; }
        public UITextMeshProUGUI?                       NameText                                { get; set; }

        public static PFIdolCharacterNameView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PFIdolCharacterNameView();

            value.OutFrameImage                             = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 027005B219C0 0x20 OutFrameImage               ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.NameText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027005B219E0 0x28 NameText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
