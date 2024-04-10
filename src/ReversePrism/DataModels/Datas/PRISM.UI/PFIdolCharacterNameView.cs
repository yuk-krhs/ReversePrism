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
    public partial class PFIdolCharacterNameView : DataModel
    {
        public Image?                                   OutFrameImage                           { get; set; }
        public UITextMeshProUGUI?                       NameText                                { get; set; }

        public static PFIdolCharacterNameView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PFIdolCharacterNameView() { Pointer= p0 };

            value.OutFrameImage                             = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0245A5B23530 0x20 OutFrameImage               ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.NameText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A5B23550 0x28 NameText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
