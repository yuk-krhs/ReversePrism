using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Exponential> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NumFiniteBucketsFieldNumber              int IL2CPP_TYPE_I4
    // 018 NumFiniteBuckets                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 GrowthFactorFieldNumber                  int IL2CPP_TYPE_I4
    // 020 GrowthFactor                             0001865C2950 ModelPrimitiveType double double double Double
    // 000 ScaleFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Scale                                    0001865C2950 ModelPrimitiveType double double double Double
    public partial class Exponential
    {
        public int                                      NumFiniteBuckets                        { get; set; }
        public double                                   GrowthFactor                            { get; set; }
        public double                                   Scale                                   { get; set; }

        public static Exponential? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Exponential();

            value.NumFiniteBuckets                          = GetInt32(new IntPtr(p + 0x018)); // 0270DA7969E0 0x18 NumFiniteBuckets            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GrowthFactor                              = GetDouble(new IntPtr(p + 0x020)); // 0270DA796A20 0x20 GrowthFactor                ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.Scale                                     = GetDouble(new IntPtr(p + 0x028)); // 0270DA796A60 0x28 Scale                       ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
