using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MCanvas                                  ModelClassType GameObject GameObject GameObject Pointer
    // 018 MCanvasComponent                         ModelClassType Canvas Canvas Canvas Pointer
    // 020 MCanvasParent                            ModelClassType CinemachineBrain CinemachineBrain CinemachineBrain Pointer
    // 028 MViewport                                ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 MRawImage                                ModelClassType RawImage RawImage RawImage Pointer
    public partial class CanvasInfo : DataModel
    {
        public GameObject?                              MCanvas                                 { get; set; }
        public Canvas?                                  MCanvasComponent                        { get; set; }
        public CinemachineBrain?                        MCanvasParent                           { get; set; }
        public RectTransform?                           MViewport                               { get; set; }
        public RawImage?                                MRawImage                               { get; set; }

        public static CanvasInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CanvasInfo() { Pointer= p0 };

            value.MCanvas                                   = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 0x10 MCanvas                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MCanvasComponent                          = GetObject<Canvas>(new IntPtr(p + 0x018), ReversePrism.DataModels.Canvas.FromPointer); // 0x18 MCanvasComponent            ( ModelClassType Canvas Canvas Canvas Pointer )
            value.MCanvasParent                             = GetObject<CinemachineBrain>(new IntPtr(p + 0x020), ReversePrism.DataModels.CinemachineBrain.FromPointer); // 0x20 MCanvasParent               ( ModelClassType CinemachineBrain CinemachineBrain CinemachineBrain Pointer )
            value.MViewport                                 = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 0x28 MViewport                   ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.MRawImage                                 = GetObject<RawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.RawImage.FromPointer); // 0x30 MRawImage                   ( ModelClassType RawImage RawImage RawImage Pointer )

            return value;
        }
    }
}
