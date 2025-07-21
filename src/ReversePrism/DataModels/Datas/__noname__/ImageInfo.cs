using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   ModelClassType Image Image Image Pointer
    // 018 Normal                                   ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer
    // 020 Pressed                                  ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer
    // 028 Selected                                 ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer
    // 030 Disabled                                 ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer
    public partial class ImageInfo : DataModel
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
            var value   = new ImageInfo() { Pointer= p0 };

            value.Target                                    = GetObject<Image>(new IntPtr(p + 0x010), ReversePrism.DataModels.Image.FromPointer); // 0x10 Target                      ( ModelClassType Image Image Image Pointer )
            value.Normal                                    = GetObject<ImageStateInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.ImageStateInfo.FromPointer); // 0x18 Normal                      ( ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer )
            value.Pressed                                   = GetObject<ImageStateInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.ImageStateInfo.FromPointer); // 0x20 Pressed                     ( ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer )
            value.Selected                                  = GetObject<ImageStateInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.ImageStateInfo.FromPointer); // 0x28 Selected                    ( ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer )
            value.Disabled                                  = GetObject<ImageStateInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.ImageStateInfo.FromPointer); // 0x30 Disabled                    ( ModelClassType ImageStateInfo ImageStateInfo ImageStateInfo Pointer )

            return value;
        }
    }
}
