using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_reference                              Instruction IL2CPP_TYPE_CLASS
    // 008 s_Boolean                                Instruction IL2CPP_TYPE_CLASS
    // 010 S_SByte                                  00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 018 S_Int16                                  00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 020 S_Char                                   00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 028 S_Int32                                  00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 030 S_Int64                                  00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 038 S_Byte                                   00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 040 S_UInt16                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 048 S_UInt32                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 050 S_UInt64                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 058 S_Single                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 060 S_Double                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 068 S_BooleanLiftedToNull                    00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 070 S_SByteLiftedToNull                      00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 078 S_Int16LiftedToNull                      00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 080 S_CharLiftedToNull                       00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 088 S_Int32LiftedToNull                      00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 090 S_Int64LiftedToNull                      00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 098 S_ByteLiftedToNull                       00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 0A0 S_UInt16LiftedToNull                     00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 0A8 S_UInt32LiftedToNull                     00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 0B0 S_UInt64LiftedToNull                     00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 0B8 S_SingleLiftedToNull                     00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 0C0 S_DoubleLiftedToNull                     00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    public partial class EqualInstruction : DataModel
    {
        public Instruction?                             S_SByte                                 { get; set; }
        public Instruction?                             S_Int16                                 { get; set; }
        public Instruction?                             S_Char                                  { get; set; }
        public Instruction?                             S_Int32                                 { get; set; }
        public Instruction?                             S_Int64                                 { get; set; }
        public Instruction?                             S_Byte                                  { get; set; }
        public Instruction?                             S_UInt16                                { get; set; }
        public Instruction?                             S_UInt32                                { get; set; }
        public Instruction?                             S_UInt64                                { get; set; }
        public Instruction?                             S_Single                                { get; set; }
        public Instruction?                             S_Double                                { get; set; }
        public Instruction?                             S_BooleanLiftedToNull                   { get; set; }
        public Instruction?                             S_SByteLiftedToNull                     { get; set; }
        public Instruction?                             S_Int16LiftedToNull                     { get; set; }
        public Instruction?                             S_CharLiftedToNull                      { get; set; }
        public Instruction?                             S_Int32LiftedToNull                     { get; set; }
        public Instruction?                             S_Int64LiftedToNull                     { get; set; }
        public Instruction?                             S_ByteLiftedToNull                      { get; set; }
        public Instruction?                             S_UInt16LiftedToNull                    { get; set; }
        public Instruction?                             S_UInt32LiftedToNull                    { get; set; }
        public Instruction?                             S_UInt64LiftedToNull                    { get; set; }
        public Instruction?                             S_SingleLiftedToNull                    { get; set; }
        public Instruction?                             S_DoubleLiftedToNull                    { get; set; }

        public static EqualInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EqualInstruction() { Pointer= p0 };

            value.S_SByte                                   = GetObject<Instruction>(new IntPtr(p + 0x010), ReversePrism.DataModels.Instruction.FromPointer); // 02466A016E48 0x10 S_SByte                     ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int16                                   = GetObject<Instruction>(new IntPtr(p + 0x018), ReversePrism.DataModels.Instruction.FromPointer); // 02466A016E68 0x18 S_Int16                     ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Char                                    = GetObject<Instruction>(new IntPtr(p + 0x020), ReversePrism.DataModels.Instruction.FromPointer); // 02466A016E88 0x20 S_Char                      ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int32                                   = GetObject<Instruction>(new IntPtr(p + 0x028), ReversePrism.DataModels.Instruction.FromPointer); // 02466A016EA8 0x28 S_Int32                     ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int64                                   = GetObject<Instruction>(new IntPtr(p + 0x030), ReversePrism.DataModels.Instruction.FromPointer); // 02466A016EC8 0x30 S_Int64                     ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Byte                                    = GetObject<Instruction>(new IntPtr(p + 0x038), ReversePrism.DataModels.Instruction.FromPointer); // 02466A016EE8 0x38 S_Byte                      ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt16                                  = GetObject<Instruction>(new IntPtr(p + 0x040), ReversePrism.DataModels.Instruction.FromPointer); // 02466A016F08 0x40 S_UInt16                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt32                                  = GetObject<Instruction>(new IntPtr(p + 0x048), ReversePrism.DataModels.Instruction.FromPointer); // 02466A016F28 0x48 S_UInt32                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt64                                  = GetObject<Instruction>(new IntPtr(p + 0x050), ReversePrism.DataModels.Instruction.FromPointer); // 02466A016F48 0x50 S_UInt64                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Single                                  = GetObject<Instruction>(new IntPtr(p + 0x058), ReversePrism.DataModels.Instruction.FromPointer); // 02466A016F68 0x58 S_Single                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Double                                  = GetObject<Instruction>(new IntPtr(p + 0x060), ReversePrism.DataModels.Instruction.FromPointer); // 02466A016F88 0x60 S_Double                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_BooleanLiftedToNull                     = GetObject<Instruction>(new IntPtr(p + 0x068), ReversePrism.DataModels.Instruction.FromPointer); // 02466A016FA8 0x68 S_BooleanLiftedToNull       ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_SByteLiftedToNull                       = GetObject<Instruction>(new IntPtr(p + 0x070), ReversePrism.DataModels.Instruction.FromPointer); // 02466A016FC8 0x70 S_SByteLiftedToNull         ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int16LiftedToNull                       = GetObject<Instruction>(new IntPtr(p + 0x078), ReversePrism.DataModels.Instruction.FromPointer); // 02466A016FE8 0x78 S_Int16LiftedToNull         ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_CharLiftedToNull                        = GetObject<Instruction>(new IntPtr(p + 0x080), ReversePrism.DataModels.Instruction.FromPointer); // 02466A017008 0x80 S_CharLiftedToNull          ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int32LiftedToNull                       = GetObject<Instruction>(new IntPtr(p + 0x088), ReversePrism.DataModels.Instruction.FromPointer); // 02466A017028 0x88 S_Int32LiftedToNull         ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int64LiftedToNull                       = GetObject<Instruction>(new IntPtr(p + 0x090), ReversePrism.DataModels.Instruction.FromPointer); // 02466A017048 0x90 S_Int64LiftedToNull         ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_ByteLiftedToNull                        = GetObject<Instruction>(new IntPtr(p + 0x098), ReversePrism.DataModels.Instruction.FromPointer); // 02466A017068 0x98 S_ByteLiftedToNull          ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt16LiftedToNull                      = GetObject<Instruction>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Instruction.FromPointer); // 02466A017088 0xA0 S_UInt16LiftedToNull        ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt32LiftedToNull                      = GetObject<Instruction>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Instruction.FromPointer); // 02466A0170A8 0xA8 S_UInt32LiftedToNull        ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt64LiftedToNull                      = GetObject<Instruction>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Instruction.FromPointer); // 02466A0170C8 0xB0 S_UInt64LiftedToNull        ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_SingleLiftedToNull                      = GetObject<Instruction>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Instruction.FromPointer); // 02466A0170E8 0xB8 S_SingleLiftedToNull        ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_DoubleLiftedToNull                      = GetObject<Instruction>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Instruction.FromPointer); // 02466A017108 0xC0 S_DoubleLiftedToNull        ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )

            return value;
        }
    }
}
