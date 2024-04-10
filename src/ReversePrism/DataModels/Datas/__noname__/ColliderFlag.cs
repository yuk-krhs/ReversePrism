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
    public partial class ColliderFlag : DataModel
    {
        public bool                                     On                                      { get; set; }
        public int                                      ParamIdx                                { get; set; }

        public static ColliderFlag? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColliderFlag() { Pointer= p0 };

            value.On                                        = GetBool(new IntPtr(p + 0x010)); // 0245A35A9FF8 0x10 On                          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ParamIdx                                  = GetInt32(new IntPtr(p + 0x014)); // 0245A35AA018 0x14 ParamIdx                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
