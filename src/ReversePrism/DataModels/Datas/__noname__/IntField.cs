using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 min                                      Func`1<int> IL2CPP_TYPE_GENERICINST
    // 068 max                                      Func`1<int> IL2CPP_TYPE_GENERICINST
    // 070 IncStep                                  ModelPrimitiveType int int int Int32
    // 074 IntStepMult                              ModelPrimitiveType int int int Int32
    public partial class IntField : DataModel
    {
        public int                                      IncStep                                 { get; set; }
        public int                                      IntStepMult                             { get; set; }

        public static IntField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntField() { Pointer= p0 };

            value.IncStep                                   = GetInt32(new IntPtr(p + 0x070)); // 0x70 IncStep                     ( ModelPrimitiveType int int int Int32 )
            value.IntStepMult                               = GetInt32(new IntPtr(p + 0x074)); // 0x74 IntStepMult                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
