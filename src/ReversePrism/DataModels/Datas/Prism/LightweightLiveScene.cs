using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Path                                     string IL2CPP_TYPE_STRING
    // 000 ResourceTag                              string IL2CPP_TYPE_STRING
    // 028 BackgroundImage                          000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 Live2DMVPlayer                           00018653E3D0 ModelClassType Live2DMVPlayer Live2DMVPlayer Live2DMVPlayer Pointer
    // 038 ResourceLoader                           00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    public partial class LightweightLiveScene : DataModel
    {
        public RawImage?                                BackgroundImage                         { get; set; }
        public Live2DMVPlayer?                          Live2DMVPlayer                          { get; set; }
        public ResourceLoader?                          ResourceLoader                          { get; set; }

        public static LightweightLiveScene? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightweightLiveScene() { Pointer= p0 };

            value.BackgroundImage                           = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 024664E8DCF0 0x28 BackgroundImage             ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.Live2DMVPlayer                            = GetObject<Live2DMVPlayer>(new IntPtr(p + 0x030), ReversePrism.DataModels.Live2DMVPlayer.FromPointer); // 024664E8DD10 0x30 Live2DMVPlayer              ( 00018653E3D0 ModelClassType Live2DMVPlayer Live2DMVPlayer Live2DMVPlayer Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.ResourceLoader.FromPointer); // 024664E8DD30 0x38 ResourceLoader              ( 00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )

            return value;
        }
    }
}
