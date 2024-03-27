using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   0001866CD270 ModelClassType Image Image Image Pointer
    // 018 Normal                                   0001866698F0 ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer
    // 020 Pressed                                  0001866698F0 ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer
    // 028 Selected                                 0001866698F0 ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer
    // 030 Disabled                                 0001866698F0 ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer
    public partial class ImageInfo
    {
        public Image?                                   Target                                  { get; set; }
        public ImageStateInfo?                          Normal                                  { get; set; }
        public ImageStateInfo?                          Pressed                                 { get; set; }
        public ImageStateInfo?                          Selected                                { get; set; }
        public ImageStateInfo?                          Disabled                                { get; set; }

        public static ImageInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ImageInfo();

            value.Target                                    = GetObject<Image>(new IntPtr(p + 0x010), ReversePrism.DataModels.Image.FromPointer); // 0270DB047560 0x10 Target                      ( 0001866CD270 ModelClassType Image Image Image Pointer )
            value.Normal                                    = GetObject<ImageStateInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.ImageStateInfo.FromPointer); // 0270DB047580 0x18 Normal                      ( 0001866698F0 ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer )
            value.Pressed                                   = GetObject<ImageStateInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.ImageStateInfo.FromPointer); // 0270DB0475A0 0x20 Pressed                     ( 0001866698F0 ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer )
            value.Selected                                  = GetObject<ImageStateInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.ImageStateInfo.FromPointer); // 0270DB0475C0 0x28 Selected                    ( 0001866698F0 ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer )
            value.Disabled                                  = GetObject<ImageStateInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.ImageStateInfo.FromPointer); // 0270DB0475E0 0x30 Disabled                    ( 0001866698F0 ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer )

            return value;
        }
    }
}
