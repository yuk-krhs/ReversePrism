using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Content                                  ModelClassType GameObject GameObject GameObject Pointer
    // 068 ShadeArea                                ModelClassType GameObject GameObject GameObject Pointer
    // 070 ScrollRect                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 078 BackgroundImage                          ModelClassType Image Image Image Pointer
    // 080 TextComponent                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 MarkSize                                 ModelPrimitiveType float float float Single
    // 08C AdjustWindowHeightToContent              ModelPrimitiveType bool bool bool Bool
    // 090 AdjustHeightMax                          ModelPrimitiveType float float float Single
    // 094 AdjustHeightMin                          ModelPrimitiveType float float float Single
    // 098 ScrollBar                                ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 0A0 ScrollBarPrevActiveState                 ModelPrimitiveType bool bool bool Bool
    public partial class MessageTMPPopupContent : DataModel
    {
        public GameObject?                              Content                                 { get; set; }
        public GameObject?                              ShadeArea                               { get; set; }
        public ScrollRect?                              ScrollRect                              { get; set; }
        public Image?                                   BackgroundImage                         { get; set; }
        public UITextMeshProUGUI?                       TextComponent                           { get; set; }
        public float                                    MarkSize                                { get; set; }
        public bool                                     AdjustWindowHeightToContent             { get; set; }
        public float                                    AdjustHeightMax                         { get; set; }
        public float                                    AdjustHeightMin                         { get; set; }
        public Scrollbar?                               ScrollBar                               { get; set; }
        public bool                                     ScrollBarPrevActiveState                { get; set; }

        public static MessageTMPPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessageTMPPopupContent() { Pointer= p0 };

            value.Content                                   = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 Content                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ShadeArea                                 = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 ShadeArea                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x070), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x70 ScrollRect                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.BackgroundImage                           = GetObject<Image>(new IntPtr(p + 0x078), ReversePrism.DataModels.Image.FromPointer); // 0x78 BackgroundImage             ( ModelClassType Image Image Image Pointer )
            value.TextComponent                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 TextComponent               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MarkSize                                  = GetSingle(new IntPtr(p + 0x088)); // 0x88 MarkSize                    ( ModelPrimitiveType float float float Single )
            value.AdjustWindowHeightToContent               = GetBool(new IntPtr(p + 0x08C)); // 0x8C AdjustWindowHeightToContent ( ModelPrimitiveType bool bool bool Bool )
            value.AdjustHeightMax                           = GetSingle(new IntPtr(p + 0x090)); // 0x90 AdjustHeightMax             ( ModelPrimitiveType float float float Single )
            value.AdjustHeightMin                           = GetSingle(new IntPtr(p + 0x094)); // 0x94 AdjustHeightMin             ( ModelPrimitiveType float float float Single )
            value.ScrollBar                                 = GetObject<Scrollbar>(new IntPtr(p + 0x098), ReversePrism.DataModels.Scrollbar.FromPointer); // 0x98 ScrollBar                   ( ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.ScrollBarPrevActiveState                  = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 ScrollBarPrevActiveState    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
