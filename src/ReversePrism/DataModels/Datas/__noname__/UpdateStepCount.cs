using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_WasUpdated                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 Value                                    000186698B70 ModelPrimitiveType uint uint uint UInt32
    public partial class UpdateStepCount : DataModel
    {
        public bool                                     M_WasUpdated                            { get; set; }
        public uint                                     Value                                   { get; set; }

        public static UpdateStepCount? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpdateStepCount() { Pointer= p0 };

            value.M_WasUpdated                              = GetBool(new IntPtr(p + 0x010)); // 0245A33C9048 0x10 M_WasUpdated                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Value                                     = GetUInt32(new IntPtr(p + 0x014)); // 0245A33C9068 0x14 Value                       ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
