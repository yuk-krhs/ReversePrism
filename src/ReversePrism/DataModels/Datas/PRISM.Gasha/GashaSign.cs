using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Image                                    000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 TransformParents                         000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    public partial class GashaSign
    {
        public RawImage?                                Image                                   { get; set; }
        public List<Transform>?                         TransformParents                        { get; set; }

        public static GashaSign? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaSign();

            value.Image                                     = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0270D535BF40 0x20 Image                       ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TransformParents                          = GetObjectList<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270D535BF60 0x28 TransformParents            ( 000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer )

            return value;
        }
    }
}
