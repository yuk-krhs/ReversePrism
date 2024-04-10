using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_value                                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 000 True                                     int IL2CPP_TYPE_I4
    // 000 False                                    int IL2CPP_TYPE_I4
    // 000 TrueLiteral                              string IL2CPP_TYPE_STRING
    // 000 FalseLiteral                             string IL2CPP_TYPE_STRING
    // 000 TrueString                               string IL2CPP_TYPE_STRING
    // 008 FalseString                              string IL2CPP_TYPE_STRING
    public partial class Boolean : DataModel
    {
        public bool                                     M_value                                 { get; set; }

        public static Boolean? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Boolean() { Pointer= p0 };

            value.M_value                                   = GetBool(new IntPtr(p + 0x010)); // 0245A15327B8 0x10 M_value                     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
