using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderImage                              0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 HeaderTextMesh                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class MobileScreenHeader : DataModel
    {
        public UIImage?                                 HeaderImage                             { get; set; }
        public UITextMeshProUGUI?                       HeaderTextMesh                          { get; set; }

        public static MobileScreenHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileScreenHeader() { Pointer= p0 };

            value.HeaderImage                               = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 02466B14A188 0x20 HeaderImage                 ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.HeaderTextMesh                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B14A1A8 0x28 HeaderTextMesh              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
