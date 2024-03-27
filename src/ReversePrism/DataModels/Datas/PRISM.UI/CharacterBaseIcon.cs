using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharacterIconImage                       000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 SelectedButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 CharacterColorImage                      0001866CCDB0 ModelClassType Image Image Image Pointer
    // 038 CharacterNameView                        000186703040 ModelClassType PFIdolCharacterNameView PFIdolCharacterNameView PFIdolCharacterNameView Pointer
    // 040 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 BgObject                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class CharacterBaseIcon
    {
        public RawImage?                                CharacterIconImage                      { get; set; }
        public UIButton?                                SelectedButton                          { get; set; }
        public Image?                                   CharacterColorImage                     { get; set; }
        public PFIdolCharacterNameView?                 CharacterNameView                       { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public GameObject?                              BgObject                                { get; set; }
        public CancellationToken                        Ct                                      { get; set; }

        public static CharacterBaseIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseIcon();

            value.CharacterIconImage                        = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0270D5404110 0x20 CharacterIconImage          ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.SelectedButton                            = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5404130 0x28 SelectedButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CharacterColorImage                       = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0270D5404150 0x30 CharacterColorImage         ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.CharacterNameView                         = GetObject<PFIdolCharacterNameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolCharacterNameView.FromPointer); // 0270D5404170 0x38 CharacterNameView           ( 000186703040 ModelClassType PFIdolCharacterNameView PFIdolCharacterNameView PFIdolCharacterNameView Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D5404190 0x40 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.BgObject                                  = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D54041B0 0x48 BgObject                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x050)); // 0270D54041D0 0x50 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
