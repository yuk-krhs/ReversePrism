using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Text                                     000186576D10 ModelClassType XMLAttributeText XMLAttributeText XMLAttributeText Pointer
    // 068 BackImage                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 070 Atlas                                    00018654FA50 ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer
    // 000 TEXT_MARGIN                              float IL2CPP_TYPE_R4
    // 078 WillSceneChange                          000186720A10 ModelClassType OnWillSceneChange OnWillSceneChange OnWillSceneChange Pointer
    // 080 MaxWidth                                 0001866656B0 ModelPrimitiveType float float float Single
    public partial class XMLTextItem
    {
        public XMLAttributeText?                        Text                                    { get; set; }
        public Image?                                   BackImage                               { get; set; }
        public SpriteAtlas?                             Atlas                                   { get; set; }
        public OnWillSceneChange?                       WillSceneChange                         { get; set; }
        public float                                    MaxWidth                                { get; set; }

        public static XMLTextItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XMLTextItem();

            value.Text                                      = GetObject<XMLAttributeText>(new IntPtr(p + 0x060), ReversePrism.DataModels.XMLAttributeText.FromPointer); // 0270D4B57368 0x60 Text                        ( 000186576D10 ModelClassType XMLAttributeText XMLAttributeText XMLAttributeText Pointer )
            value.BackImage                                 = GetObject<Image>(new IntPtr(p + 0x068), ReversePrism.DataModels.Image.FromPointer); // 0270D4B57388 0x68 BackImage                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.Atlas                                     = GetObject<SpriteAtlas>(new IntPtr(p + 0x070), ReversePrism.DataModels.SpriteAtlas.FromPointer); // 0270D4B573A8 0x70 Atlas                       ( 00018654FA50 ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer )
            value.WillSceneChange                           = GetObject<OnWillSceneChange>(new IntPtr(p + 0x078), ReversePrism.DataModels.OnWillSceneChange.FromPointer); // 0270D4B573E8 0x78 WillSceneChange             ( 000186720A10 ModelClassType OnWillSceneChange OnWillSceneChange OnWillSceneChange Pointer )
            value.MaxWidth                                  = GetSingle(new IntPtr(p + 0x080)); // 0270D4B57408 0x80 MaxWidth                    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
