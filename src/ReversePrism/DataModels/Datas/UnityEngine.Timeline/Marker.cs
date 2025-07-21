using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Time                                   ModelPrimitiveType double double double Double
    // 020 Parent                                   ModelClassType TrackAsset TrackAsset TrackAsset Pointer
    public partial class Marker : DataModel
    {
        public double                                   M_Time                                  { get; set; }
        public TrackAsset?                              Parent                                  { get; set; }

        public static Marker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Marker() { Pointer= p0 };

            value.M_Time                                    = GetDouble(new IntPtr(p + 0x018)); // 0x18 M_Time                      ( ModelPrimitiveType double double double Double )
            value.Parent                                    = GetObject<TrackAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.TrackAsset.FromPointer); // 0x20 Parent                      ( ModelClassType TrackAsset TrackAsset TrackAsset Pointer )

            return value;
        }
    }
}
