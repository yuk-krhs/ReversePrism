using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Int16                                  Instruction IL2CPP_TYPE_CLASS
    // 008 s_Int32                                  Instruction IL2CPP_TYPE_CLASS
    // 010 S_Int64                                  00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    public partial class NegateCheckedInstruction
    {
        public Instruction?                             S_Int64                                 { get; set; }

        public static NegateCheckedInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NegateCheckedInstruction();

            value.S_Int64                                   = GetObject<Instruction>(new IntPtr(p + 0x010), ReversePrism.DataModels.Instruction.FromPointer); // 0270DA031CB8 0x10 S_Int64                     ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )

            return value;
        }
    }
}
