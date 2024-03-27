using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LoadingCharaImage                        0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 ViewModel                                00018659EDB0 ModelClassType LoadingMiniCharaViewModel LoadingMiniCharaViewModel LoadingMiniCharaViewModel Pointer
    // 030 LoadingCharaSprites                      000185CA4998 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 038 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 040 LoadingCharaIndex                        0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LoadingMiniCharaView
    {
        public UIImage?                                 LoadingCharaImage                       { get; set; }
        public LoadingMiniCharaViewModel?               ViewModel                               { get; set; }
        public List<Sprite>?                            LoadingCharaSprites                     { get; set; }
        public IDisposable?                             Disposable                              { get; set; }
        public int                                      LoadingCharaIndex                       { get; set; }

        public static LoadingMiniCharaView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingMiniCharaView();

            value.LoadingCharaImage                         = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 027001E9DA40 0x20 LoadingCharaImage           ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ViewModel                                 = GetObject<LoadingMiniCharaViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.LoadingMiniCharaViewModel.FromPointer); // 027001E9DA60 0x28 ViewModel                   ( 00018659EDB0 ModelClassType LoadingMiniCharaViewModel LoadingMiniCharaViewModel LoadingMiniCharaViewModel Pointer )
            value.LoadingCharaSprites                       = GetObjectList<Sprite>(new IntPtr(p + 0x030), ReversePrism.DataModels.Sprite.FromPointer); // 027001E9DA80 0x30 LoadingCharaSprites         ( 000185CA4998 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDisposable.FromPointer); // 027001E9DAA0 0x38 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.LoadingCharaIndex                         = GetInt32(new IntPtr(p + 0x040)); // 027001E9DAC0 0x40 LoadingCharaIndex           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
