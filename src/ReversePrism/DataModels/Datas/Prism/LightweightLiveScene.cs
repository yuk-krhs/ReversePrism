using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Path                                     string IL2CPP_TYPE_STRING
    // 028 BackgroundImage                          ModelClassType RawImage RawImage RawImage Pointer
    // 030 Live2DMVPlayer                           ModelClassType Live2DMVPlayer Live2DMVPlayer Live2DMVPlayer Pointer
    public partial class LightweightLiveScene : DataModel
    {
        public RawImage?                                BackgroundImage                         { get; set; }
        public Live2DMVPlayer?                          Live2DMVPlayer                          { get; set; }

        public static LightweightLiveScene? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightweightLiveScene() { Pointer= p0 };

            value.BackgroundImage                           = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 BackgroundImage             ( ModelClassType RawImage RawImage RawImage Pointer )
            value.Live2DMVPlayer                            = GetObject<Live2DMVPlayer>(new IntPtr(p + 0x030), ReversePrism.DataModels.Live2DMVPlayer.FromPointer); // 0x30 Live2DMVPlayer              ( ModelClassType Live2DMVPlayer Live2DMVPlayer Live2DMVPlayer Pointer )

            return value;
        }
    }
}
