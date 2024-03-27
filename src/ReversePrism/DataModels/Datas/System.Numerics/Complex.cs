using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Zero                                     Complex IL2CPP_TYPE_VALUETYPE
    // 010 One                                      0001865F1F80 ModelEnumType Complex Complex Complex Int32
    // 020 ImaginaryOne                             0001865F1F80 ModelEnumType Complex Complex Complex Int32
    // 030 S_sqrtRescaleThreshold                   0001865C3A90 ModelPrimitiveType double double double Double
    // 038 S_asinOverflowThreshold                  0001865C3A90 ModelPrimitiveType double double double Double
    // 040 S_log2                                   0001865C3A90 ModelPrimitiveType double double double Double
    // 010 M_real                                   0001865C2950 ModelPrimitiveType double double double Double
    // 018 M_imaginary                              0001865C2950 ModelPrimitiveType double double double Double
    public partial class Complex
    {
        public Complex                                  One                                     { get; set; }
        public Complex                                  ImaginaryOne                            { get; set; }
        public double                                   S_sqrtRescaleThreshold                  { get; set; }
        public double                                   S_asinOverflowThreshold                 { get; set; }
        public double                                   S_log2                                  { get; set; }
        public double                                   M_real                                  { get; set; }
        public double                                   M_imaginary                             { get; set; }

        public static Complex? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Complex();

            value.One                                       = (Complex)GetInt32(new IntPtr(p + 0x010)); // 027004480FF0 0x10 One                         ( 0001865F1F80 ModelEnumType Complex Complex Complex Int32 )
            value.ImaginaryOne                              = (Complex)GetInt32(new IntPtr(p + 0x020)); // 027004481010 0x20 ImaginaryOne                ( 0001865F1F80 ModelEnumType Complex Complex Complex Int32 )
            value.S_sqrtRescaleThreshold                    = GetDouble(new IntPtr(p + 0x030)); // 027004481030 0x30 S_sqrtRescaleThreshold      ( 0001865C3A90 ModelPrimitiveType double double double Double )
            value.S_asinOverflowThreshold                   = GetDouble(new IntPtr(p + 0x038)); // 027004481050 0x38 S_asinOverflowThreshold     ( 0001865C3A90 ModelPrimitiveType double double double Double )
            value.S_log2                                    = GetDouble(new IntPtr(p + 0x040)); // 027004481070 0x40 S_log2                      ( 0001865C3A90 ModelPrimitiveType double double double Double )
            value.M_real                                    = GetDouble(new IntPtr(p + 0x010)); // 027004481090 0x10 M_real                      ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_imaginary                               = GetDouble(new IntPtr(p + 0x018)); // 0270044810B0 0x18 M_imaginary                 ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
