using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Enabled                                ModelPrimitiveType bool bool bool Bool
    // 014 M_PositionOffset                         ModelPrimitiveType float float float Single
    // 018 M_SearchRadius                           ModelPrimitiveType int int int Int32
    // 01C M_SearchResolution                       ModelPrimitiveType int int int Int32
    public partial class AutoDolly : DataModel
    {
        public bool                                     M_Enabled                               { get; set; }
        public float                                    M_PositionOffset                        { get; set; }
        public int                                      M_SearchRadius                          { get; set; }
        public int                                      M_SearchResolution                      { get; set; }

        public static AutoDolly? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoDolly() { Pointer= p0 };

            value.M_Enabled                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 M_Enabled                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_PositionOffset                          = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_PositionOffset            ( ModelPrimitiveType float float float Single )
            value.M_SearchRadius                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_SearchRadius              ( ModelPrimitiveType int int int Int32 )
            value.M_SearchResolution                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_SearchResolution          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
