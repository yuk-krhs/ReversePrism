using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Volume                                   ModelPrimitiveType int int int Int32
    // 028 Slider                                   ModelClassType Slider Slider Slider Pointer
    // 030 Sliderhelper                             ModelClassType SliderHelper SliderHelper SliderHelper Pointer
    // 038 MuteButton                               ModelClassType PlayAndStopToggleButton PlayAndStopToggleButton PlayAndStopToggleButton Pointer
    // 040 BarImage                                 ModelClassType Image Image Image Pointer
    // 048 SliderButtonImage                        ModelClassType Image Image Image Pointer
    // 000 maxVolume                                float IL2CPP_TYPE_R4
    // 050 <OnChangeVolumeObservable>k__BackingField Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    public partial class SoundListNode : DataModel
    {
        public int                                      Volume                                  { get; set; }
        public Slider?                                  Slider                                  { get; set; }
        public SliderHelper?                            Sliderhelper                            { get; set; }
        public PlayAndStopToggleButton?                 MuteButton                              { get; set; }
        public Image?                                   BarImage                                { get; set; }
        public Image?                                   SliderButtonImage                       { get; set; }

        public static SoundListNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoundListNode() { Pointer= p0 };

            value.Volume                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 Volume                      ( ModelPrimitiveType int int int Int32 )
            value.Slider                                    = GetObject<Slider>(new IntPtr(p + 0x028), ReversePrism.DataModels.Slider.FromPointer); // 0x28 Slider                      ( ModelClassType Slider Slider Slider Pointer )
            value.Sliderhelper                              = GetObject<SliderHelper>(new IntPtr(p + 0x030), ReversePrism.DataModels.SliderHelper.FromPointer); // 0x30 Sliderhelper                ( ModelClassType SliderHelper SliderHelper SliderHelper Pointer )
            value.MuteButton                                = GetObject<PlayAndStopToggleButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.PlayAndStopToggleButton.FromPointer); // 0x38 MuteButton                  ( ModelClassType PlayAndStopToggleButton PlayAndStopToggleButton PlayAndStopToggleButton Pointer )
            value.BarImage                                  = GetObject<Image>(new IntPtr(p + 0x040), ReversePrism.DataModels.Image.FromPointer); // 0x40 BarImage                    ( ModelClassType Image Image Image Pointer )
            value.SliderButtonImage                         = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 0x48 SliderButtonImage           ( ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
