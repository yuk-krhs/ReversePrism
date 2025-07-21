using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InvalidId                                uint IL2CPP_TYPE_U4
    // 010 M_Id                                     ModelPrimitiveType uint uint uint UInt32
    // 000 s_GlobalState                            GlobalState IL2CPP_TYPE_VALUETYPE
    public partial class InputUser : DataModel
    {
        public uint                                     M_Id                                    { get; set; }

        public static InputUser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputUser() { Pointer= p0 };

            value.M_Id                                      = GetUInt32(new IntPtr(p + 0x010)); // 0x10 M_Id                        ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
