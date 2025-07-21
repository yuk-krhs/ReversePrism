using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IndicatorDotPrefab                       ModelClassType Toggle Toggle Toggle Pointer
    // 028 ToggleGroup                              ModelClassType ToggleGroup ToggleGroup ToggleGroup Pointer
    // 030 IndicatorDots                            ModelClassListType List`1<Toggle> List`1<Toggle> List<Toggle> Pointer
    // 038 ToggleClickDisposables                   ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 <OnIndicatorChanged>k__BackingField      Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 IsActive                                 ModelPrimitiveType bool bool bool Bool
    public partial class CarouselIndicator : DataModel
    {
        public Toggle?                                  IndicatorDotPrefab                      { get; set; }
        public ToggleGroup?                             ToggleGroup                             { get; set; }
        public List<Toggle>?                            IndicatorDots                           { get; set; }
        public CompositeDisposable?                     ToggleClickDisposables                  { get; set; }
        public bool                                     IsActive                                { get; set; }

        public static CarouselIndicator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CarouselIndicator() { Pointer= p0 };

            value.IndicatorDotPrefab                        = GetObject<Toggle>(new IntPtr(p + 0x020), ReversePrism.DataModels.Toggle.FromPointer); // 0x20 IndicatorDotPrefab          ( ModelClassType Toggle Toggle Toggle Pointer )
            value.ToggleGroup                               = GetObject<ToggleGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleGroup.FromPointer); // 0x28 ToggleGroup                 ( ModelClassType ToggleGroup ToggleGroup ToggleGroup Pointer )
            value.IndicatorDots                             = GetObjectList<Toggle>(new IntPtr(p + 0x030), ReversePrism.DataModels.Toggle.FromPointer); // 0x30 IndicatorDots               ( ModelClassListType List`1<Toggle> List`1<Toggle> List<Toggle> Pointer )
            value.ToggleClickDisposables                    = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 ToggleClickDisposables      ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x048)); // 0x48 IsActive                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
