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
    // 018 S_UInt16                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 020 S_UInt32                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 028 S_UInt64                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 030 S_Single                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 038 S_Double                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    public partial class SubInstruction
    {
        public Instruction?                             S_Int64                                 { get; set; }
        public Instruction?                             S_UInt16                                { get; set; }
        public Instruction?                             S_UInt32                                { get; set; }
        public Instruction?                             S_UInt64                                { get; set; }
        public Instruction?                             S_Single                                { get; set; }
        public Instruction?                             S_Double                                { get; set; }

        public static SubInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubInstruction();

            value.S_Int64                                   = GetObject<Instruction>(new IntPtr(p + 0x010), ReversePrism.DataModels.Instruction.FromPointer); // 0270DA037680 0x10 S_Int64                     ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt16                                  = GetObject<Instruction>(new IntPtr(p + 0x018), ReversePrism.DataModels.Instruction.FromPointer); // 0270DA0376A0 0x18 S_UInt16                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt32                                  = GetObject<Instruction>(new IntPtr(p + 0x020), ReversePrism.DataModels.Instruction.FromPointer); // 0270DA0376C0 0x20 S_UInt32                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt64                                  = GetObject<Instruction>(new IntPtr(p + 0x028), ReversePrism.DataModels.Instruction.FromPointer); // 0270DA0376E0 0x28 S_UInt64                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Single                                  = GetObject<Instruction>(new IntPtr(p + 0x030), ReversePrism.DataModels.Instruction.FromPointer); // 0270DA037700 0x30 S_Single                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Double                                  = GetObject<Instruction>(new IntPtr(p + 0x038), ReversePrism.DataModels.Instruction.FromPointer); // 0270DA037720 0x38 S_Double                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )

            return value;
        }
    }
}
