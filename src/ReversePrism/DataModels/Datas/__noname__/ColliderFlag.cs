using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 On                                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 ParamIdx                                 0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class ColliderFlag
    {
        public bool                                     On                                      { get; set; }
        public int                                      ParamIdx                                { get; set; }

        public static ColliderFlag? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColliderFlag();

            value.On                                        = GetBool(new IntPtr(p + 0x010)); // 0270035A9FF8 0x10 On                          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ParamIdx                                  = GetInt32(new IntPtr(p + 0x014)); // 0270035AA018 0x14 ParamIdx                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
