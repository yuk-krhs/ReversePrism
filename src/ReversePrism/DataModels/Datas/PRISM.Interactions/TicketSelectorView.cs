using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtName                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ImgTicket                                000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 TxtTicketAmount                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtCount                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BtnMin                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 BtnDown                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 BtnUp                                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 BtnMax                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 Nothing                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 OnButton                                 Subject`1<ValueTuple`2<int, TicketButtonType>> IL2CPP_TYPE_GENERICINST
    public partial class TicketSelectorView
    {
        public UITextMeshProUGUI?                       TxtName                                 { get; set; }
        public RawImage?                                ImgTicket                               { get; set; }
        public UITextMeshProUGUI?                       TxtTicketAmount                         { get; set; }
        public UITextMeshProUGUI?                       TxtCount                                { get; set; }
        public UIButton?                                BtnMin                                  { get; set; }
        public UIButton?                                BtnDown                                 { get; set; }
        public UIButton?                                BtnUp                                   { get; set; }
        public UIButton?                                BtnMax                                  { get; set; }
        public int                                      Index                                   { get; set; }
        public bool                                     Nothing                                 { get; set; }

        public static TicketSelectorView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TicketSelectorView();

            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA381AE8 0x20 TxtName                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgTicket                                 = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0270DA381B08 0x28 ImgTicket                   ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtTicketAmount                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA381B28 0x30 TxtTicketAmount             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCount                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA381B48 0x38 TxtCount                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnMin                                    = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA381B68 0x40 BtnMin                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnDown                                   = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA381B88 0x48 BtnDown                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnUp                                     = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA381BA8 0x50 BtnUp                       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnMax                                    = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA381BC8 0x58 BtnMax                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x060)); // 0270DA381BE8 0x60 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Nothing                                   = GetBool(new IntPtr(p + 0x064)); // 0270DA381C08 0x64 Nothing                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
