using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_SByte                                  Instruction IL2CPP_TYPE_CLASS
    // 008 s_Int16                                  Instruction IL2CPP_TYPE_CLASS
    // 010 S_Int32                                  00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 018 S_Int64                                  00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 020 S_Byte                                   00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 028 S_UInt16                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 030 S_UInt32                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 038 S_UInt64                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    public partial class RightShiftInstruction : DataModel
    {
        public Instruction?                             S_Int32                                 { get; set; }
        public Instruction?                             S_Int64                                 { get; set; }
        public Instruction?                             S_Byte                                  { get; set; }
        public Instruction?                             S_UInt16                                { get; set; }
        public Instruction?                             S_UInt32                                { get; set; }
        public Instruction?                             S_UInt64                                { get; set; }

        public static RightShiftInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RightShiftInstruction() { Pointer= p0 };

            value.S_Int32                                   = GetObject<Instruction>(new IntPtr(p + 0x010), ReversePrism.DataModels.Instruction.FromPointer); // 02466A0A1F30 0x10 S_Int32                     ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int64                                   = GetObject<Instruction>(new IntPtr(p + 0x018), ReversePrism.DataModels.Instruction.FromPointer); // 02466A0A1F50 0x18 S_Int64                     ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Byte                                    = GetObject<Instruction>(new IntPtr(p + 0x020), ReversePrism.DataModels.Instruction.FromPointer); // 02466A0A1F70 0x20 S_Byte                      ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt16                                  = GetObject<Instruction>(new IntPtr(p + 0x028), ReversePrism.DataModels.Instruction.FromPointer); // 02466A0A1F90 0x28 S_UInt16                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt32                                  = GetObject<Instruction>(new IntPtr(p + 0x030), ReversePrism.DataModels.Instruction.FromPointer); // 02466A0A1FB0 0x30 S_UInt32                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt64                                  = GetObject<Instruction>(new IntPtr(p + 0x038), ReversePrism.DataModels.Instruction.FromPointer); // 02466A0A1FD0 0x38 S_UInt64                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )

            return value;
        }
    }
}
