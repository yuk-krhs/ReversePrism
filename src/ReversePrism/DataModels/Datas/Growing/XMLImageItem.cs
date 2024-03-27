using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Image                                    000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 068 MaxWidth                                 0001866656B0 ModelPrimitiveType float float float Single
    // 070 Tex2d                                    000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 078 Param                                    000186577940 ModelClassType XMLImageItemParam XMLImageItemParam XMLImageItemParam Pointer
    public partial class XMLImageItem
    {
        public RawImage?                                Image                                   { get; set; }
        public float                                    MaxWidth                                { get; set; }
        public Texture2D?                               Tex2d                                   { get; set; }
        public XMLImageItemParam?                       Param                                   { get; set; }

        public static XMLImageItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XMLImageItem();

            value.Image                                     = GetObject<RawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.RawImage.FromPointer); // 0270D4B3DB20 0x60 Image                       ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.MaxWidth                                  = GetSingle(new IntPtr(p + 0x068)); // 0270D4B3DB40 0x68 MaxWidth                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Tex2d                                     = GetObject<Texture2D>(new IntPtr(p + 0x070), ReversePrism.DataModels.Texture2D.FromPointer); // 0270D4B3DB60 0x70 Tex2d                       ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Param                                     = GetObject<XMLImageItemParam>(new IntPtr(p + 0x078), ReversePrism.DataModels.XMLImageItemParam.FromPointer); // 0270D4B3DB80 0x78 Param                       ( 000186577940 ModelClassType XMLImageItemParam XMLImageItemParam XMLImageItemParam Pointer )

            return value;
        }
    }
}
