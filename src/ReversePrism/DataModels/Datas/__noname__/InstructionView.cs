using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 014 StackDepth                               0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ContinuationsDepth                       0001865F4260 ModelPrimitiveType int int int Int32
    // 020 Name                                     000186672F10 ModelPrimitiveType string string string String
    // 028 Instruction                              00018670E540 ModelClassType Instruction Instruction Instruction Pointer
    public partial class InstructionView
    {
        public int                                      Index                                   { get; set; }
        public int                                      StackDepth                              { get; set; }
        public int                                      ContinuationsDepth                      { get; set; }
        public string                                   Name                                    { get; set; }
        public Instruction?                             Instruction                             { get; set; }

        public static InstructionView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InstructionView();

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0270D9FC0948 0x10 Index                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.StackDepth                                = GetInt32(new IntPtr(p + 0x014)); // 0270D9FC0968 0x14 StackDepth                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ContinuationsDepth                        = GetInt32(new IntPtr(p + 0x018)); // 0270D9FC0988 0x18 ContinuationsDepth          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0270D9FC09A8 0x20 Name                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.Instruction                               = GetObject<Instruction>(new IntPtr(p + 0x028), ReversePrism.DataModels.Instruction.FromPointer); // 0270D9FC09C8 0x28 Instruction                 ( 00018670E540 ModelClassType Instruction Instruction Instruction Pointer )

            return value;
        }
    }
}
