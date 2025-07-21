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
    // 010 S_SByte                                  ModelClassType Instruction Instruction Instruction Pointer
    // 018 S_Int16                                  ModelClassType Instruction Instruction Instruction Pointer
    // 020 S_Char                                   ModelClassType Instruction Instruction Instruction Pointer
    // 028 S_Int32                                  ModelClassType Instruction Instruction Instruction Pointer
    // 030 S_Int64                                  ModelClassType Instruction Instruction Instruction Pointer
    // 038 S_Byte                                   ModelClassType Instruction Instruction Instruction Pointer
    // 040 S_UInt16                                 ModelClassType Instruction Instruction Instruction Pointer
    // 048 S_UInt32                                 ModelClassType Instruction Instruction Instruction Pointer
    // 050 S_UInt64                                 ModelClassType Instruction Instruction Instruction Pointer
    // 058 S_Single                                 ModelClassType Instruction Instruction Instruction Pointer
    // 060 S_Double                                 ModelClassType Instruction Instruction Instruction Pointer
    // 068 S_BooleanLiftedToNull                    ModelClassType Instruction Instruction Instruction Pointer
    // 070 S_SByteLiftedToNull                      ModelClassType Instruction Instruction Instruction Pointer
    // 078 S_Int16LiftedToNull                      ModelClassType Instruction Instruction Instruction Pointer
    // 080 S_CharLiftedToNull                       ModelClassType Instruction Instruction Instruction Pointer
    // 088 S_Int32LiftedToNull                      ModelClassType Instruction Instruction Instruction Pointer
    // 090 S_Int64LiftedToNull                      ModelClassType Instruction Instruction Instruction Pointer
    // 098 S_ByteLiftedToNull                       ModelClassType Instruction Instruction Instruction Pointer
    // 0A0 S_UInt16LiftedToNull                     ModelClassType Instruction Instruction Instruction Pointer
    // 0A8 S_UInt32LiftedToNull                     ModelClassType Instruction Instruction Instruction Pointer
    // 0B0 S_UInt64LiftedToNull                     ModelClassType Instruction Instruction Instruction Pointer
    // 0B8 S_SingleLiftedToNull                     ModelClassType Instruction Instruction Instruction Pointer
    // 0C0 S_DoubleLiftedToNull                     ModelClassType Instruction Instruction Instruction Pointer
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

            value.S_SByte                                   = GetObject<Instruction>(new IntPtr(p + 0x010), ReversePrism.DataModels.Instruction.FromPointer); // 0x10 S_SByte                     ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int16                                   = GetObject<Instruction>(new IntPtr(p + 0x018), ReversePrism.DataModels.Instruction.FromPointer); // 0x18 S_Int16                     ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Char                                    = GetObject<Instruction>(new IntPtr(p + 0x020), ReversePrism.DataModels.Instruction.FromPointer); // 0x20 S_Char                      ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int32                                   = GetObject<Instruction>(new IntPtr(p + 0x028), ReversePrism.DataModels.Instruction.FromPointer); // 0x28 S_Int32                     ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int64                                   = GetObject<Instruction>(new IntPtr(p + 0x030), ReversePrism.DataModels.Instruction.FromPointer); // 0x30 S_Int64                     ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Byte                                    = GetObject<Instruction>(new IntPtr(p + 0x038), ReversePrism.DataModels.Instruction.FromPointer); // 0x38 S_Byte                      ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt16                                  = GetObject<Instruction>(new IntPtr(p + 0x040), ReversePrism.DataModels.Instruction.FromPointer); // 0x40 S_UInt16                    ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt32                                  = GetObject<Instruction>(new IntPtr(p + 0x048), ReversePrism.DataModels.Instruction.FromPointer); // 0x48 S_UInt32                    ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt64                                  = GetObject<Instruction>(new IntPtr(p + 0x050), ReversePrism.DataModels.Instruction.FromPointer); // 0x50 S_UInt64                    ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Single                                  = GetObject<Instruction>(new IntPtr(p + 0x058), ReversePrism.DataModels.Instruction.FromPointer); // 0x58 S_Single                    ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Double                                  = GetObject<Instruction>(new IntPtr(p + 0x060), ReversePrism.DataModels.Instruction.FromPointer); // 0x60 S_Double                    ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_BooleanLiftedToNull                     = GetObject<Instruction>(new IntPtr(p + 0x068), ReversePrism.DataModels.Instruction.FromPointer); // 0x68 S_BooleanLiftedToNull       ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_SByteLiftedToNull                       = GetObject<Instruction>(new IntPtr(p + 0x070), ReversePrism.DataModels.Instruction.FromPointer); // 0x70 S_SByteLiftedToNull         ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int16LiftedToNull                       = GetObject<Instruction>(new IntPtr(p + 0x078), ReversePrism.DataModels.Instruction.FromPointer); // 0x78 S_Int16LiftedToNull         ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_CharLiftedToNull                        = GetObject<Instruction>(new IntPtr(p + 0x080), ReversePrism.DataModels.Instruction.FromPointer); // 0x80 S_CharLiftedToNull          ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int32LiftedToNull                       = GetObject<Instruction>(new IntPtr(p + 0x088), ReversePrism.DataModels.Instruction.FromPointer); // 0x88 S_Int32LiftedToNull         ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int64LiftedToNull                       = GetObject<Instruction>(new IntPtr(p + 0x090), ReversePrism.DataModels.Instruction.FromPointer); // 0x90 S_Int64LiftedToNull         ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_ByteLiftedToNull                        = GetObject<Instruction>(new IntPtr(p + 0x098), ReversePrism.DataModels.Instruction.FromPointer); // 0x98 S_ByteLiftedToNull          ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt16LiftedToNull                      = GetObject<Instruction>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Instruction.FromPointer); // 0xA0 S_UInt16LiftedToNull        ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt32LiftedToNull                      = GetObject<Instruction>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Instruction.FromPointer); // 0xA8 S_UInt32LiftedToNull        ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt64LiftedToNull                      = GetObject<Instruction>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Instruction.FromPointer); // 0xB0 S_UInt64LiftedToNull        ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_SingleLiftedToNull                      = GetObject<Instruction>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Instruction.FromPointer); // 0xB8 S_SingleLiftedToNull        ( ModelClassType Instruction Instruction Instruction Pointer )
            value.S_DoubleLiftedToNull                      = GetObject<Instruction>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Instruction.FromPointer); // 0xC0 S_DoubleLiftedToNull        ( ModelClassType Instruction Instruction Instruction Pointer )

            return value;
        }
    }
}
