using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IndicatorDotPrefab                       000186682710 ModelClassType Toggle Toggle Toggle Pointer
    // 028 ToggleGroup                              000186685730 ModelClassType ToggleGroup ToggleGroup ToggleGroup Pointer
    // 030 IndicatorDots                            000185D15058 ModelClassListType List`1<Toggle> List`1<Toggle> List<Toggle> Pointer
    // 038 ToggleClickDisposables                   0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 <OnIndicatorChanged>k__BackingField      Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CarouselIndicator
    {
        public Toggle?                                  IndicatorDotPrefab                      { get; set; }
        public ToggleGroup?                             ToggleGroup                             { get; set; }
        public List<Toggle>?                            IndicatorDots                           { get; set; }
        public CompositeDisposable?                     ToggleClickDisposables                  { get; set; }

        public static CarouselIndicator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CarouselIndicator();

            value.IndicatorDotPrefab                        = GetObject<Toggle>(new IntPtr(p + 0x020), ReversePrism.DataModels.Toggle.FromPointer); // 027004F48450 0x20 IndicatorDotPrefab          ( 000186682710 ModelClassType Toggle Toggle Toggle Pointer )
            value.ToggleGroup                               = GetObject<ToggleGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleGroup.FromPointer); // 027004F48470 0x28 ToggleGroup                 ( 000186685730 ModelClassType ToggleGroup ToggleGroup ToggleGroup Pointer )
            value.IndicatorDots                             = GetObjectList<Toggle>(new IntPtr(p + 0x030), ReversePrism.DataModels.Toggle.FromPointer); // 027004F48490 0x30 IndicatorDots               ( 000185D15058 ModelClassListType List`1<Toggle> List`1<Toggle> List<Toggle> Pointer )
            value.ToggleClickDisposables                    = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 027004F484B0 0x38 ToggleClickDisposables      ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
