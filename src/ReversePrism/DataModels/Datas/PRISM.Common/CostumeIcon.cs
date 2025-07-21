using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _CostumeIcon                             ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 EmptyObject                              ModelClassType GameObject GameObject GameObject Pointer
    // 030 EmptyIcon                                ModelClassType Image Image Image Pointer
    // 038 EmptyIconSprites                         ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    public partial class CostumeIcon : DataModel
    {
        public UIRawImage?                              _CostumeIcon                            { get; set; }
        public GameObject?                              EmptyObject                             { get; set; }
        public Image?                                   EmptyIcon                               { get; set; }
        public List<Sprite>?                            EmptyIconSprites                        { get; set; }

        public static CostumeIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeIcon() { Pointer= p0 };

            value._CostumeIcon                              = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x20 _CostumeIcon                ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.EmptyObject                               = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 EmptyObject                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyIcon                                 = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0x30 EmptyIcon                   ( ModelClassType Image Image Image Pointer )
            value.EmptyIconSprites                          = GetObjectList<Sprite>(new IntPtr(p + 0x038), ReversePrism.DataModels.Sprite.FromPointer); // 0x38 EmptyIconSprites            ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )

            return value;
        }
    }
}
