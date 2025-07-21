using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharaAnimationLength                     ModelPrimitiveType int int int Int32
    // 028 LoadingCharaImage                        ModelClassType UIImage UIImage UIImage Pointer
    // 030 ViewModel                                ModelClassType LoadingMiniCharaViewModel LoadingMiniCharaViewModel LoadingMiniCharaViewModel Pointer
    // 038 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 040 LoadingCharaIndex                        ModelPrimitiveType int int int Int32
    // 048 LoadingCharaSprites                      ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    public partial class LoadingMiniCharaView : DataModel
    {
        public int                                      CharaAnimationLength                    { get; set; }
        public UIImage?                                 LoadingCharaImage                       { get; set; }
        public LoadingMiniCharaViewModel?               ViewModel                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public int                                      LoadingCharaIndex                       { get; set; }
        public List<Sprite>?                            LoadingCharaSprites                     { get; set; }

        public static LoadingMiniCharaView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingMiniCharaView() { Pointer= p0 };

            value.CharaAnimationLength                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 CharaAnimationLength        ( ModelPrimitiveType int int int Int32 )
            value.LoadingCharaImage                         = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 LoadingCharaImage           ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ViewModel                                 = GetObject<LoadingMiniCharaViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.LoadingMiniCharaViewModel.FromPointer); // 0x30 ViewModel                   ( ModelClassType LoadingMiniCharaViewModel LoadingMiniCharaViewModel LoadingMiniCharaViewModel Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x38 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.LoadingCharaIndex                         = GetInt32(new IntPtr(p + 0x040)); // 0x40 LoadingCharaIndex           ( ModelPrimitiveType int int int Int32 )
            value.LoadingCharaSprites                       = GetObjectList<Sprite>(new IntPtr(p + 0x048), ReversePrism.DataModels.Sprite.FromPointer); // 0x48 LoadingCharaSprites         ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )

            return value;
        }
    }
}
