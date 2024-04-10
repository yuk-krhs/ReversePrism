using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_value                                  00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 000 True                                     SqlBoolean IL2CPP_TYPE_VALUETYPE
    // 001 False                                    SqlBoolean IL2CPP_TYPE_VALUETYPE
    // 002 Null                                     SqlBoolean IL2CPP_TYPE_VALUETYPE
    // 003 Zero                                     SqlBoolean IL2CPP_TYPE_VALUETYPE
    // 004 One                                      SqlBoolean IL2CPP_TYPE_VALUETYPE
    public partial class SqlBoolean : DataModel
    {
        public sbyte                                    M_value                                 { get; set; }

        public static SqlBoolean? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlBoolean() { Pointer= p0 };

            value.M_value                                   = GetSByte(new IntPtr(p + 0x010)); // 0246689EA7C0 0x10 M_value                     ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
