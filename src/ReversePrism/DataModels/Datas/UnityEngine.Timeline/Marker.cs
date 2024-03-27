using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Time                                   0001865C2950 ModelPrimitiveType double double double Double
    // 020 Parent                                   00018669B680 ModelClassType TrackAsset TrackAsset TrackAsset Pointer
    public partial class Marker
    {
        public double                                   M_Time                                  { get; set; }
        public TrackAsset?                              Parent                                  { get; set; }

        public static Marker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Marker();

            value.M_Time                                    = GetDouble(new IntPtr(p + 0x018)); // 027006B66850 0x18 M_Time                      ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.Parent                                    = GetObject<TrackAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.TrackAsset.FromPointer); // 027006B66870 0x20 Parent                      ( 00018669B680 ModelClassType TrackAsset TrackAsset TrackAsset Pointer )

            return value;
        }
    }
}
