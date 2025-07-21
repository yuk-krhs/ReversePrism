using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 090 ToggleGroup                              ModelClassType ToggleGroup ToggleGroup ToggleGroup Pointer
    // 098 ThroughTime                              ModelPrimitiveType float float float Single
    // 09C CurrentPosition                          ModelPrimitiveType float float float Single
    // 0A0 LastPosition                             ModelPrimitiveType float float float Single
    // 0A4 IsCarouselEvent                          ModelPrimitiveType bool bool bool Bool
    // 0A8 Gashas                                   ModelClassListType List`1<Gasha> List`1<Gasha> List<Gasha> Pointer
    // 0B0 <IsFixedTagert>k__BackingField           ReactiveProperty`1<bool> IL2CPP_TYPE_GENERICINST
    // 0B8 <OnMoveEnd>k__BackingField               Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class GashaBannerCarousel : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public ToggleGroup?                             ToggleGroup                             { get; set; }
        public float                                    ThroughTime                             { get; set; }
        public float                                    CurrentPosition                         { get; set; }
        public float                                    LastPosition                            { get; set; }
        public bool                                     IsCarouselEvent                         { get; set; }
        public List<Gasha>?                             Gashas                                  { get; set; }

        public static GashaBannerCarousel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaBannerCarousel() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x88 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ToggleGroup                               = GetObject<ToggleGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.ToggleGroup.FromPointer); // 0x90 ToggleGroup                 ( ModelClassType ToggleGroup ToggleGroup ToggleGroup Pointer )
            value.ThroughTime                               = GetSingle(new IntPtr(p + 0x098)); // 0x98 ThroughTime                 ( ModelPrimitiveType float float float Single )
            value.CurrentPosition                           = GetSingle(new IntPtr(p + 0x09C)); // 0x9C CurrentPosition             ( ModelPrimitiveType float float float Single )
            value.LastPosition                              = GetSingle(new IntPtr(p + 0x0A0)); // 0xA0 LastPosition                ( ModelPrimitiveType float float float Single )
            value.IsCarouselEvent                           = GetBool(new IntPtr(p + 0x0A4)); // 0xA4 IsCarouselEvent             ( ModelPrimitiveType bool bool bool Bool )
            value.Gashas                                    = GetObjectList<Gasha>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Gasha.FromPointer); // 0xA8 Gashas                      ( ModelClassListType List`1<Gasha> List`1<Gasha> List<Gasha> Pointer )

            return value;
        }
    }
}
