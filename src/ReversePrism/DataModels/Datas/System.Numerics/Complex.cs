using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Zero                                     Complex IL2CPP_TYPE_VALUETYPE
    // 010 One                                      ModelEnumType Complex Complex Complex Int32
    // 020 ImaginaryOne                             ModelEnumType Complex Complex Complex Int32
    // 030 S_sqrtRescaleThreshold                   ModelPrimitiveType double double double Double
    // 038 S_asinOverflowThreshold                  ModelPrimitiveType double double double Double
    // 040 S_log2                                   ModelPrimitiveType double double double Double
    // 010 M_real                                   ModelPrimitiveType double double double Double
    // 018 M_imaginary                              ModelPrimitiveType double double double Double
    public partial class Complex : DataModel
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
            var value   = new Complex() { Pointer= p0 };

            value.One                                       = (Complex)GetInt32(new IntPtr(p + 0x010)); // 0x10 One                         ( ModelEnumType Complex Complex Complex Int32 )
            value.ImaginaryOne                              = (Complex)GetInt32(new IntPtr(p + 0x020)); // 0x20 ImaginaryOne                ( ModelEnumType Complex Complex Complex Int32 )
            value.S_sqrtRescaleThreshold                    = GetDouble(new IntPtr(p + 0x030)); // 0x30 S_sqrtRescaleThreshold      ( ModelPrimitiveType double double double Double )
            value.S_asinOverflowThreshold                   = GetDouble(new IntPtr(p + 0x038)); // 0x38 S_asinOverflowThreshold     ( ModelPrimitiveType double double double Double )
            value.S_log2                                    = GetDouble(new IntPtr(p + 0x040)); // 0x40 S_log2                      ( ModelPrimitiveType double double double Double )
            value.M_real                                    = GetDouble(new IntPtr(p + 0x010)); // 0x10 M_real                      ( ModelPrimitiveType double double double Double )
            value.M_imaginary                               = GetDouble(new IntPtr(p + 0x018)); // 0x18 M_imaginary                 ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
