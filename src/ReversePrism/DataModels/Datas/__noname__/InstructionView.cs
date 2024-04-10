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
    public partial class InstructionView : DataModel
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
            var value   = new InstructionView() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 02466A01C448 0x10 Index                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.StackDepth                                = GetInt32(new IntPtr(p + 0x014)); // 02466A01C468 0x14 StackDepth                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ContinuationsDepth                        = GetInt32(new IntPtr(p + 0x018)); // 02466A01C488 0x18 ContinuationsDepth          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 02466A01C4A8 0x20 Name                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.Instruction                               = GetObject<Instruction>(new IntPtr(p + 0x028), ReversePrism.DataModels.Instruction.FromPointer); // 02466A01C4C8 0x28 Instruction                 ( 00018670E540 ModelClassType Instruction Instruction Instruction Pointer )

            return value;
        }
    }
}
