using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Volume                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Slider                                   00018651CF50 ModelClassType Slider Slider Slider Pointer
    // 030 Sliderhelper                             00018651E890 ModelClassType SliderHelper SliderHelper SliderHelper Pointer
    // 038 MuteButton                               0001867498F0 ModelClassType PlayAndStopToggleButton PlayAndStopToggleButton PlayAndStopToggleButton Pointer
    // 040 BarImage                                 0001866CCDB0 ModelClassType Image Image Image Pointer
    // 048 SliderButtonImage                        0001866CCDB0 ModelClassType Image Image Image Pointer
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

            value.Volume                                    = GetInt32(new IntPtr(p + 0x020)); // 024664C6C060 0x20 Volume                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Slider                                    = GetObject<Slider>(new IntPtr(p + 0x028), ReversePrism.DataModels.Slider.FromPointer); // 024664C6C080 0x28 Slider                      ( 00018651CF50 ModelClassType Slider Slider Slider Pointer )
            value.Sliderhelper                              = GetObject<SliderHelper>(new IntPtr(p + 0x030), ReversePrism.DataModels.SliderHelper.FromPointer); // 024664C6C0A0 0x30 Sliderhelper                ( 00018651E890 ModelClassType SliderHelper SliderHelper SliderHelper Pointer )
            value.MuteButton                                = GetObject<PlayAndStopToggleButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.PlayAndStopToggleButton.FromPointer); // 024664C6C0C0 0x38 MuteButton                  ( 0001867498F0 ModelClassType PlayAndStopToggleButton PlayAndStopToggleButton PlayAndStopToggleButton Pointer )
            value.BarImage                                  = GetObject<Image>(new IntPtr(p + 0x040), ReversePrism.DataModels.Image.FromPointer); // 024664C6C0E0 0x40 BarImage                    ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.SliderButtonImage                         = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 024664C6C100 0x48 SliderButtonImage           ( 0001866CCDB0 ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
