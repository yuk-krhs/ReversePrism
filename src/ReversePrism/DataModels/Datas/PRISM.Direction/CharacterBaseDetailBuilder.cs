using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 UiCharacterView                          ModelClassType IdolBaseDetailUICharacterView IdolBaseDetailUICharacterView IdolBaseDetailUICharacterView Pointer
    // 030 View                                     ModelClassType IdolBaseDetailView IdolBaseDetailView IdolBaseDetailView Pointer
    // 038 ProfileView                              ModelClassType IdolBaseDetailProfileView IdolBaseDetailProfileView IdolBaseDetailProfileView Pointer
    // 040 GalleryView                              ModelClassType IdolBaseDetailGalleryView IdolBaseDetailGalleryView IdolBaseDetailGalleryView Pointer
    public partial class CharacterBaseDetailBuilder : DataModel
    {
        public CommonTitleView?                         TitleView                               { get; set; }
        public IdolBaseDetailUICharacterView?           UiCharacterView                         { get; set; }
        public IdolBaseDetailView?                      View                                    { get; set; }
        public IdolBaseDetailProfileView?               ProfileView                             { get; set; }
        public IdolBaseDetailGalleryView?               GalleryView                             { get; set; }

        public static CharacterBaseDetailBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseDetailBuilder() { Pointer= p0 };

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x20 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UiCharacterView                           = GetObject<IdolBaseDetailUICharacterView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolBaseDetailUICharacterView.FromPointer); // 0x28 UiCharacterView             ( ModelClassType IdolBaseDetailUICharacterView IdolBaseDetailUICharacterView IdolBaseDetailUICharacterView Pointer )
            value.View                                      = GetObject<IdolBaseDetailView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolBaseDetailView.FromPointer); // 0x30 View                        ( ModelClassType IdolBaseDetailView IdolBaseDetailView IdolBaseDetailView Pointer )
            value.ProfileView                               = GetObject<IdolBaseDetailProfileView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolBaseDetailProfileView.FromPointer); // 0x38 ProfileView                 ( ModelClassType IdolBaseDetailProfileView IdolBaseDetailProfileView IdolBaseDetailProfileView Pointer )
            value.GalleryView                               = GetObject<IdolBaseDetailGalleryView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolBaseDetailGalleryView.FromPointer); // 0x40 GalleryView                 ( ModelClassType IdolBaseDetailGalleryView IdolBaseDetailGalleryView IdolBaseDetailGalleryView Pointer )

            return value;
        }
    }
}
