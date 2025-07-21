using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Text                                     ModelClassType XMLAttributeText XMLAttributeText XMLAttributeText Pointer
    // 068 BackImage                                ModelClassType Image Image Image Pointer
    // 070 Atlas                                    ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer
    // 000 TEXT_MARGIN                              float IL2CPP_TYPE_R4
    // 078 WillSceneChange                          ModelClassType OnWillSceneChange OnWillSceneChange OnWillSceneChange Pointer
    // 080 MaxWidth                                 ModelPrimitiveType float float float Single
    public partial class XMLTextItem : DataModel
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
            var value   = new XMLTextItem() { Pointer= p0 };

            value.Text                                      = GetObject<XMLAttributeText>(new IntPtr(p + 0x060), ReversePrism.DataModels.XMLAttributeText.FromPointer); // 0x60 Text                        ( ModelClassType XMLAttributeText XMLAttributeText XMLAttributeText Pointer )
            value.BackImage                                 = GetObject<Image>(new IntPtr(p + 0x068), ReversePrism.DataModels.Image.FromPointer); // 0x68 BackImage                   ( ModelClassType Image Image Image Pointer )
            value.Atlas                                     = GetObject<SpriteAtlas>(new IntPtr(p + 0x070), ReversePrism.DataModels.SpriteAtlas.FromPointer); // 0x70 Atlas                       ( ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer )
            value.WillSceneChange                           = GetObject<OnWillSceneChange>(new IntPtr(p + 0x078), ReversePrism.DataModels.OnWillSceneChange.FromPointer); // 0x78 WillSceneChange             ( ModelClassType OnWillSceneChange OnWillSceneChange OnWillSceneChange Pointer )
            value.MaxWidth                                  = GetSingle(new IntPtr(p + 0x080)); // 0x80 MaxWidth                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
