using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharacterIconImage                       ModelClassType RawImage RawImage RawImage Pointer
    // 028 SelectedButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 030 CharacterColorImage                      ModelClassType Image Image Image Pointer
    // 038 CharacterNameView                        ModelClassType PFIdolCharacterNameView PFIdolCharacterNameView PFIdolCharacterNameView Pointer
    // 040 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 BgObject                                 ModelClassType GameObject GameObject GameObject Pointer
    public partial class CharacterBaseIcon : DataModel
    {
        public RawImage?                                CharacterIconImage                      { get; set; }
        public UIButton?                                SelectedButton                          { get; set; }
        public Image?                                   CharacterColorImage                     { get; set; }
        public PFIdolCharacterNameView?                 CharacterNameView                       { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public GameObject?                              BgObject                                { get; set; }

        public static CharacterBaseIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseIcon() { Pointer= p0 };

            value.CharacterIconImage                        = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0x20 CharacterIconImage          ( ModelClassType RawImage RawImage RawImage Pointer )
            value.SelectedButton                            = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 SelectedButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CharacterColorImage                       = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0x30 CharacterColorImage         ( ModelClassType Image Image Image Pointer )
            value.CharacterNameView                         = GetObject<PFIdolCharacterNameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolCharacterNameView.FromPointer); // 0x38 CharacterNameView           ( ModelClassType PFIdolCharacterNameView PFIdolCharacterNameView PFIdolCharacterNameView Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x40 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.BgObject                                  = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 BgObject                    ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
