using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   000186613FA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 018 ArgumentCount                            0001865F4700 ModelPrimitiveType int int int Int32
    public partial class MethodInfoCallInstruction
    {
        public MethodInfo?                              Target                                  { get; set; }
        public int                                      ArgumentCount                           { get; set; }

        public static MethodInfoCallInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MethodInfoCallInstruction();

            value.Target                                    = GetObject<MethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D9FA06B0 0x10 Target                      ( 000186613FA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ArgumentCount                             = GetInt32(new IntPtr(p + 0x018)); // 0270D9FA06D0 0x18 ArgumentCount               ( 0001865F4700 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
