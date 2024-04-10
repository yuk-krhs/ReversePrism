using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LatLng> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LatitudeFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Latitude                                 0001865C2950 ModelPrimitiveType double double double Double
    // 000 LongitudeFieldNumber                     int IL2CPP_TYPE_I4
    // 020 Longitude                                0001865C2950 ModelPrimitiveType double double double Double
    public partial class LatLng : DataModel
    {
        public double                                   Latitude                                { get; set; }
        public double                                   Longitude                               { get; set; }

        public static LatLng? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LatLng() { Pointer= p0 };

            value.Latitude                                  = GetDouble(new IntPtr(p + 0x018)); // 02466A700DD0 0x18 Latitude                    ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.Longitude                                 = GetDouble(new IntPtr(p + 0x020)); // 02466A700E10 0x20 Longitude                   ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
