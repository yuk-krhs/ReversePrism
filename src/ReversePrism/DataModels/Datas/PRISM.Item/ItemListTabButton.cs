using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NormalTab                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 SelectedTab                              0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 ExpireBadge                              0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    public partial class ItemListTabButton
    {
        public Image?                                   NormalTab                               { get; set; }
        public Image?                                   SelectedTab                             { get; set; }
        public UIImage?                                 ExpireBadge                             { get; set; }

        public static ItemListTabButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListTabButton();

            value.NormalTab                                 = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270D52DF4E0 0x20 NormalTab                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.SelectedTab                               = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0270D52DF500 0x28 SelectedTab                 ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ExpireBadge                               = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0270D52DF520 0x30 ExpireBadge                 ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
