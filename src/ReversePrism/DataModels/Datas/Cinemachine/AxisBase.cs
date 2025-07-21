using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  ModelPrimitiveType float float float Single
    // 014 M_MinValue                               ModelPrimitiveType float float float Single
    // 018 M_MaxValue                               ModelPrimitiveType float float float Single
    // 01C M_Wrap                                   ModelPrimitiveType bool bool bool Bool
    public partial class AxisBase : DataModel
    {
        public float                                    M_Value                                 { get; set; }
        public float                                    M_MinValue                              { get; set; }
        public float                                    M_MaxValue                              { get; set; }
        public bool                                     M_Wrap                                  { get; set; }

        public static AxisBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AxisBase() { Pointer= p0 };

            value.M_Value                                   = GetSingle(new IntPtr(p + 0x010)); // 0x10 M_Value                     ( ModelPrimitiveType float float float Single )
            value.M_MinValue                                = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_MinValue                  ( ModelPrimitiveType float float float Single )
            value.M_MaxValue                                = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_MaxValue                  ( ModelPrimitiveType float float float Single )
            value.M_Wrap                                    = GetBool(new IntPtr(p + 0x01C)); // 0x1C M_Wrap                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
