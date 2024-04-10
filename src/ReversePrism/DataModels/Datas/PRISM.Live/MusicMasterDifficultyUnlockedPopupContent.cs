using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 MusicJacketImage                         0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 068 Message                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class MusicMasterDifficultyUnlockedPopupContent : DataModel
    {
        public UIRawImage?                              MusicJacketImage                        { get; set; }
        public UITextMeshProUGUI?                       Message                                 { get; set; }

        public static MusicMasterDifficultyUnlockedPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicMasterDifficultyUnlockedPopupContent() { Pointer= p0 };

            value.MusicJacketImage                          = GetObject<UIRawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466523EB60 0x60 MusicJacketImage            ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.Message                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466523EB80 0x68 Message                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
