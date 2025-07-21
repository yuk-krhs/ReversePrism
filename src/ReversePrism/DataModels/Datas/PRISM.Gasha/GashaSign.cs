using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Image                                    ModelClassType RawImage RawImage RawImage Pointer
    // 028 TransformParents                         ModelClassListType Transform[] Transform[] List<Transform> Pointer
    public partial class GashaSign : DataModel
    {
        public RawImage?                                Image                                   { get; set; }
        public List<Transform>?                         TransformParents                        { get; set; }

        public static GashaSign? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaSign() { Pointer= p0 };

            value.Image                                     = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0x20 Image                       ( ModelClassType RawImage RawImage RawImage Pointer )
            value.TransformParents                          = GetObjectList<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 TransformParents            ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )

            return value;
        }
    }
}
