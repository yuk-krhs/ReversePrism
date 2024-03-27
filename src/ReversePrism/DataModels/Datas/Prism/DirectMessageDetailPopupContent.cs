using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Content                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 070 ScrollBar                                0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 078 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 DateText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 TextComponent                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 ScrollBarPrevActiveState                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DirectMessageDetailPopupContent
    {
        public GameObject?                              Content                                 { get; set; }
        public ScrollRect?                              ScrollRect                              { get; set; }
        public Scrollbar?                               ScrollBar                               { get; set; }
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public UITextMeshProUGUI?                       DateText                                { get; set; }
        public UITextMeshProUGUI?                       TextComponent                           { get; set; }
        public bool                                     ScrollBarPrevActiveState                { get; set; }

        public static DirectMessageDetailPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectMessageDetailPopupContent();

            value.Content                                   = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4CA2BD8 0x60 Content                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x068), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270D4CA2BF8 0x68 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.ScrollBar                                 = GetObject<Scrollbar>(new IntPtr(p + 0x070), ReversePrism.DataModels.Scrollbar.FromPointer); // 0270D4CA2C18 0x70 ScrollBar                   ( 0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4CA2C38 0x78 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DateText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4CA2C58 0x80 DateText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TextComponent                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4CA2C78 0x88 TextComponent               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScrollBarPrevActiveState                  = GetBool(new IntPtr(p + 0x090)); // 0270D4CA2C98 0x90 ScrollBarPrevActiveState    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
