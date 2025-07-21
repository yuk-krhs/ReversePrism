using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      ModelClassType UIButton UIButton UIButton Pointer
    // 028 ImgIcon                                  ModelClassType RawImage RawImage RawImage Pointer
    // 030 CgText                                   ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 CgSelected                               ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 onClickSubject                           Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 048 Index                                    ModelPrimitiveType int int int Int32
    // 050 <OnLongPress>k__BackingField             IObservable`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    public partial class FavoriteIconView : DataModel
    {
        public UIButton?                                Btn                                     { get; set; }
        public RawImage?                                ImgIcon                                 { get; set; }
        public CanvasGroup?                             CgText                                  { get; set; }
        public CanvasGroup?                             CgSelected                              { get; set; }
        public int                                      Index                                   { get; set; }

        public static FavoriteIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FavoriteIconView() { Pointer= p0 };

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Btn                         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgIcon                                   = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 ImgIcon                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.CgText                                    = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x30 CgText                      ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgSelected                                = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 CgSelected                  ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x048)); // 0x48 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
