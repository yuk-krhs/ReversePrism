using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enabled                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 Id                                       0001866722E0 ModelPrimitiveType string string string String
    // 020 CustomData                               0001866722E0 ModelPrimitiveType string string string String
    public partial class FeatureData : DataModel
    {
        public bool                                     Enabled                                 { get; set; }
        public string                                   Id                                      { get; set; }
        public string                                   CustomData                              { get; set; }

        public static FeatureData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FeatureData() { Pointer= p0 };

            value.Enabled                                   = GetBool(new IntPtr(p + 0x010)); // 0246609102E0 0x10 Enabled                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 024660910300 0x18 Id                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CustomData                                = GetString(new IntPtr(p + 0x020)); // 024660910320 0x20 CustomData                  ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
