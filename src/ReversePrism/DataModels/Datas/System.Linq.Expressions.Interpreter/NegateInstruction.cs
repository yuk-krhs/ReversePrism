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
    // 018 S_Single                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 020 S_Double                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    public partial class NegateInstruction : DataModel
    {
        public Instruction?                             S_Int64                                 { get; set; }
        public Instruction?                             S_Single                                { get; set; }
        public Instruction?                             S_Double                                { get; set; }

        public static NegateInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NegateInstruction() { Pointer= p0 };

            value.S_Int64                                   = GetObject<Instruction>(new IntPtr(p + 0x010), ReversePrism.DataModels.Instruction.FromPointer); // 02466A07D2A8 0x10 S_Int64                     ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Single                                  = GetObject<Instruction>(new IntPtr(p + 0x018), ReversePrism.DataModels.Instruction.FromPointer); // 02466A07D2C8 0x18 S_Single                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Double                                  = GetObject<Instruction>(new IntPtr(p + 0x020), ReversePrism.DataModels.Instruction.FromPointer); // 02466A07D2E8 0x20 S_Double                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )

            return value;
        }
    }
}
