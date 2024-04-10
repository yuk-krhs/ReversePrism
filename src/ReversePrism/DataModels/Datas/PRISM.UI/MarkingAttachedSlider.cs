using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PRESS_SCALE                              float IL2CPP_TYPE_R4
    // 000 PRESS_SCALE_DURATION                     float IL2CPP_TYPE_R4
    // 168 MarkingContainer                         000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 170 HeadMarkingPrefab                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 178 BetweenMarkingPrefab                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class MarkingAttachedSlider : DataModel
    {
        public RectTransform?                           MarkingContainer                        { get; set; }
        public GameObject?                              HeadMarkingPrefab                       { get; set; }
        public GameObject?                              BetweenMarkingPrefab                    { get; set; }

        public static MarkingAttachedSlider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarkingAttachedSlider() { Pointer= p0 };

            value.MarkingContainer                          = GetObject<RectTransform>(new IntPtr(p + 0x168), ReversePrism.DataModels.RectTransform.FromPointer); // 0246652E29B8 0x168 MarkingContainer            ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.HeadMarkingPrefab                         = GetObject<GameObject>(new IntPtr(p + 0x170), ReversePrism.DataModels.GameObject.FromPointer); // 0246652E29D8 0x170 HeadMarkingPrefab           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BetweenMarkingPrefab                      = GetObject<GameObject>(new IntPtr(p + 0x178), ReversePrism.DataModels.GameObject.FromPointer); // 0246652E29F8 0x178 BetweenMarkingPrefab        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
