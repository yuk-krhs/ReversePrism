using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 ImgUnitIcon                              0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 TxtCharaReadingLastName                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtCharaReadingFirstName                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtCharaLastName                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtCharaFirstName                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtCv                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtAge                                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 TxtBloodType                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TxtBirthday                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TxtZodiacSign                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 TxtDominantHand                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 TxtBirthPlace                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 TxtHeight                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 TxtWeight                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 TxtHobby                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 TxtSpecialAbility                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 TxtDescription                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 ImgLabels                                000185B8B1A0 ModelClassListType Image[] Image[] List<Image> Pointer
    // 0B8 ImgBg                                    0001866CCDB0 ModelClassType Image Image Image Pointer
    public partial class IdolBaseDetailProfileView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UIImage?                                 ImgUnitIcon                             { get; set; }
        public UITextMeshProUGUI?                       TxtCharaReadingLastName                 { get; set; }
        public UITextMeshProUGUI?                       TxtCharaReadingFirstName                { get; set; }
        public UITextMeshProUGUI?                       TxtCharaLastName                        { get; set; }
        public UITextMeshProUGUI?                       TxtCharaFirstName                       { get; set; }
        public UITextMeshProUGUI?                       TxtCv                                   { get; set; }
        public UITextMeshProUGUI?                       TxtAge                                  { get; set; }
        public UITextMeshProUGUI?                       TxtBloodType                            { get; set; }
        public UITextMeshProUGUI?                       TxtBirthday                             { get; set; }
        public UITextMeshProUGUI?                       TxtZodiacSign                           { get; set; }
        public UITextMeshProUGUI?                       TxtDominantHand                         { get; set; }
        public UITextMeshProUGUI?                       TxtBirthPlace                           { get; set; }
        public UITextMeshProUGUI?                       TxtHeight                               { get; set; }
        public UITextMeshProUGUI?                       TxtWeight                               { get; set; }
        public UITextMeshProUGUI?                       TxtHobby                                { get; set; }
        public UITextMeshProUGUI?                       TxtSpecialAbility                       { get; set; }
        public UITextMeshProUGUI?                       TxtDescription                          { get; set; }
        public List<Image>?                             ImgLabels                               { get; set; }
        public Image?                                   ImgBg                                   { get; set; }

        public static IdolBaseDetailProfileView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailProfileView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA26D190 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgUnitIcon                               = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA26D1B0 0x28 ImgUnitIcon                 ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.TxtCharaReadingLastName                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D1D0 0x30 TxtCharaReadingLastName     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCharaReadingFirstName                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D1F0 0x38 TxtCharaReadingFirstName    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCharaLastName                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D210 0x40 TxtCharaLastName            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCharaFirstName                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D230 0x48 TxtCharaFirstName           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCv                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D250 0x50 TxtCv                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAge                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D270 0x58 TxtAge                      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtBloodType                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D290 0x60 TxtBloodType                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtBirthday                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D2B0 0x68 TxtBirthday                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtZodiacSign                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D2D0 0x70 TxtZodiacSign               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtDominantHand                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D2F0 0x78 TxtDominantHand             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtBirthPlace                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D310 0x80 TxtBirthPlace               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtHeight                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D330 0x88 TxtHeight                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtWeight                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D350 0x90 TxtWeight                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtHobby                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D370 0x98 TxtHobby                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSpecialAbility                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D390 0xA0 TxtSpecialAbility           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtDescription                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA26D3B0 0xA8 TxtDescription              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgLabels                                 = GetObjectList<Image>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Image.FromPointer); // 0270DA26D3D0 0xB0 ImgLabels                   ( 000185B8B1A0 ModelClassListType Image[] Image[] List<Image> Pointer )
            value.ImgBg                                     = GetObject<Image>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Image.FromPointer); // 0270DA26D3F0 0xB8 ImgBg                       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
