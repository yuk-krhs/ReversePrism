using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 min                                      Func`1<uint> IL2CPP_TYPE_GENERICINST
    // 068 max                                      Func`1<uint> IL2CPP_TYPE_GENERICINST
    // 070 IncStep                                  0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 074 IntStepMult                              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class UIntField : DataModel
    {
        public uint                                     IncStep                                 { get; set; }
        public uint                                     IntStepMult                             { get; set; }

        public static UIntField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIntField() { Pointer= p0 };

            value.IncStep                                   = GetUInt32(new IntPtr(p + 0x070)); // 0246691DDF40 0x70 IncStep                     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.IntStepMult                               = GetUInt32(new IntPtr(p + 0x074)); // 0246691DDF60 0x74 IntStepMult                 ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
