using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Content                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 ShadeArea                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 078 BackgroundImage                          0001866CCDB0 ModelClassType Image Image Image Pointer
    // 080 TextComponent                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 MarkSize                                 0001866656B0 ModelPrimitiveType float float float Single
    // 08C AdjustWindowHeightToContent              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 090 AdjustHeightMax                          0001866656B0 ModelPrimitiveType float float float Single
    // 094 AdjustHeightMin                          0001866656B0 ModelPrimitiveType float float float Single
    // 098 ScrollBar                                0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 0A0 ScrollBarPrevActiveState                 000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.Content                                   = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 024660D77448 0x60 Content                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ShadeArea                                 = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 024660D77468 0x68 ShadeArea                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x070), ReversePrism.DataModels.ScrollRect.FromPointer); // 024660D77488 0x70 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.BackgroundImage                           = GetObject<Image>(new IntPtr(p + 0x078), ReversePrism.DataModels.Image.FromPointer); // 024660D774A8 0x78 BackgroundImage             ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.TextComponent                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024660D774C8 0x80 TextComponent               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MarkSize                                  = GetSingle(new IntPtr(p + 0x088)); // 024660D774E8 0x88 MarkSize                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AdjustWindowHeightToContent               = GetBool(new IntPtr(p + 0x08C)); // 024660D77508 0x8C AdjustWindowHeightToContent ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AdjustHeightMax                           = GetSingle(new IntPtr(p + 0x090)); // 024660D77528 0x90 AdjustHeightMax             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AdjustHeightMin                           = GetSingle(new IntPtr(p + 0x094)); // 024660D77548 0x94 AdjustHeightMin             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScrollBar                                 = GetObject<Scrollbar>(new IntPtr(p + 0x098), ReversePrism.DataModels.Scrollbar.FromPointer); // 024660D77568 0x98 ScrollBar                   ( 0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.ScrollBarPrevActiveState                  = GetBool(new IntPtr(p + 0x0A0)); // 024660D77588 0xA0 ScrollBarPrevActiveState    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
