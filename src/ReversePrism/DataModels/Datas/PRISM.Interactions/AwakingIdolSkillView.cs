using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 GoBg                                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 GoHighlightBg                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 AwakingLv                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 GoAcquired                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 GoUnacquired                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 ImgSkillIcon                             000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 058 TxtSkillName                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ImgSkillNameBg                           0001866CCDB0 ModelClassType Image Image Image Pointer
    // 068 ColorSkillNameBgBase                     0001865AA8E0 ModelEnumType Color Color Color Int32
    // 078 ColorSkillNameBgHighLight                0001865AA8E0 ModelEnumType Color Color Color Int32
    // 088 onSelectedSkillId                        Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class AwakingIdolSkillView
    {
        public UIButton?                                Btn                                     { get; set; }
        public GameObject?                              GoBg                                    { get; set; }
        public GameObject?                              GoHighlightBg                           { get; set; }
        public UITextMeshProUGUI?                       AwakingLv                               { get; set; }
        public GameObject?                              GoAcquired                              { get; set; }
        public GameObject?                              GoUnacquired                            { get; set; }
        public RawImage?                                ImgSkillIcon                            { get; set; }
        public UITextMeshProUGUI?                       TxtSkillName                            { get; set; }
        public Image?                                   ImgSkillNameBg                          { get; set; }
        public Color                                    ColorSkillNameBgBase                    { get; set; }
        public Color                                    ColorSkillNameBgHighLight               { get; set; }

        public static AwakingIdolSkillView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AwakingIdolSkillView();

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA345330 0x20 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.GoBg                                      = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA345350 0x28 GoBg                        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoHighlightBg                             = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA345370 0x30 GoHighlightBg               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AwakingLv                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA345390 0x38 AwakingLv                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoAcquired                                = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA3453B0 0x40 GoAcquired                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoUnacquired                              = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA3453D0 0x48 GoUnacquired                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgSkillIcon                              = GetObject<RawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.RawImage.FromPointer); // 0270DA3453F0 0x50 ImgSkillIcon                ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtSkillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA345410 0x58 TxtSkillName                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgSkillNameBg                            = GetObject<Image>(new IntPtr(p + 0x060), ReversePrism.DataModels.Image.FromPointer); // 0270DA345430 0x60 ImgSkillNameBg              ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ColorSkillNameBgBase                      = (Color)GetInt32(new IntPtr(p + 0x068)); // 0270DA345450 0x68 ColorSkillNameBgBase        ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.ColorSkillNameBgHighLight                 = (Color)GetInt32(new IntPtr(p + 0x078)); // 0270DA345470 0x78 ColorSkillNameBgHighLight   ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
