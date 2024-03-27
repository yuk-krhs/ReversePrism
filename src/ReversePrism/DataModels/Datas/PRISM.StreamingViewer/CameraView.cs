using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrefabPath                               string IL2CPP_TYPE_STRING
    // 020 LiveCamera                               0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 028 PostProcessVolume                        00018676E4B0 ModelClassType PostProcessVolume PostProcessVolume PostProcessVolume Pointer
    // 030 DepthOfField                             0001866C21C0 ModelClassType DepthOfField DepthOfField DepthOfField Pointer
    // 038 receivedData                             Queue`1<ReceivedData> IL2CPP_TYPE_GENERICINST
    // 040 ProducerModeWatching                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 IsViewPaused                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CameraView
    {
        public Camera?                                  LiveCamera                              { get; set; }
        public PostProcessVolume?                       PostProcessVolume                       { get; set; }
        public DepthOfField?                            DepthOfField                            { get; set; }
        public bool                                     ProducerModeWatching                    { get; set; }
        public bool                                     IsViewPaused                            { get; set; }

        public static CameraView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraView();

            value.LiveCamera                                = GetObject<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0270D4F43CF8 0x20 LiveCamera                  ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.PostProcessVolume                         = GetObject<PostProcessVolume>(new IntPtr(p + 0x028), ReversePrism.DataModels.PostProcessVolume.FromPointer); // 0270D4F43D18 0x28 PostProcessVolume           ( 00018676E4B0 ModelClassType PostProcessVolume PostProcessVolume PostProcessVolume Pointer )
            value.DepthOfField                              = GetObject<DepthOfField>(new IntPtr(p + 0x030), ReversePrism.DataModels.DepthOfField.FromPointer); // 0270D4F43D38 0x30 DepthOfField                ( 0001866C21C0 ModelClassType DepthOfField DepthOfField DepthOfField Pointer )
            value.ProducerModeWatching                      = GetBool(new IntPtr(p + 0x040)); // 0270D4F43D78 0x40 ProducerModeWatching        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsViewPaused                              = GetBool(new IntPtr(p + 0x041)); // 0270D4F43D98 0x41 IsViewPaused                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
