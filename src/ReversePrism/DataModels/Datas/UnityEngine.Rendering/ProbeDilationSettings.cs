using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EnableDilation                           ModelPrimitiveType bool bool bool Bool
    // 014 DilationDistance                         ModelPrimitiveType float float float Single
    // 018 DilationValidityThreshold                ModelPrimitiveType float float float Single
    // 01C DilationIterations                       ModelPrimitiveType int int int Int32
    // 020 SquaredDistWeighting                     ModelPrimitiveType bool bool bool Bool
    public partial class ProbeDilationSettings : DataModel
    {
        public bool                                     EnableDilation                          { get; set; }
        public float                                    DilationDistance                        { get; set; }
        public float                                    DilationValidityThreshold               { get; set; }
        public int                                      DilationIterations                      { get; set; }
        public bool                                     SquaredDistWeighting                    { get; set; }

        public static ProbeDilationSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeDilationSettings() { Pointer= p0 };

            value.EnableDilation                            = GetBool(new IntPtr(p + 0x010)); // 0x10 EnableDilation              ( ModelPrimitiveType bool bool bool Bool )
            value.DilationDistance                          = GetSingle(new IntPtr(p + 0x014)); // 0x14 DilationDistance            ( ModelPrimitiveType float float float Single )
            value.DilationValidityThreshold                 = GetSingle(new IntPtr(p + 0x018)); // 0x18 DilationValidityThreshold   ( ModelPrimitiveType float float float Single )
            value.DilationIterations                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C DilationIterations          ( ModelPrimitiveType int int int Int32 )
            value.SquaredDistWeighting                      = GetBool(new IntPtr(p + 0x020)); // 0x20 SquaredDistWeighting        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
