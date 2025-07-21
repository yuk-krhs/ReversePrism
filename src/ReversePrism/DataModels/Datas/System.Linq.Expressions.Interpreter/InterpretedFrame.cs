using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // FFFFFFFF s_currentFrame                           InterpretedFrame IL2CPP_TYPE_CLASS
    // 010 Interpreter                              ModelClassType Interpreter Interpreter Interpreter Pointer
    // 018 Parent                                   ModelClassType InterpretedFrame InterpretedFrame InterpretedFrame Pointer
    // 020 Continuations                            ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 ContinuationIndex                        ModelPrimitiveType int int int Int32
    // 02C PendingContinuation                      ModelPrimitiveType int int int Int32
    // 030 _pendingValue                            <object> IL2CPP_TYPE_OBJECT
    // 038 Data                                     <object>[] IL2CPP_TYPE_SZARRAY
    // 040 Closure                                  ModelClassListType IStrongBox[] IStrongBox[] List<IStrongBox> Pointer
    // 048 StackIndex                               ModelPrimitiveType int int int Int32
    // 04C InstructionIndex                         ModelPrimitiveType int int int Int32
    public partial class InterpretedFrame : DataModel
    {
        public Interpreter?                             Interpreter                             { get; set; }
        public InterpretedFrame?                        Parent                                  { get; set; }
        public List<int>?                               Continuations                           { get; set; }
        public int                                      ContinuationIndex                       { get; set; }
        public int                                      PendingContinuation                     { get; set; }
        public List<IStrongBox>?                        Closure                                 { get; set; }
        public int                                      StackIndex                              { get; set; }
        public int                                      InstructionIndex                        { get; set; }

        public static InterpretedFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InterpretedFrame() { Pointer= p0 };

            value.Interpreter                               = GetObject<Interpreter>(new IntPtr(p + 0x010), ReversePrism.DataModels.Interpreter.FromPointer); // 0x10 Interpreter                 ( ModelClassType Interpreter Interpreter Interpreter Pointer )
            value.Parent                                    = GetObject<InterpretedFrame>(new IntPtr(p + 0x018), ReversePrism.DataModels.InterpretedFrame.FromPointer); // 0x18 Parent                      ( ModelClassType InterpretedFrame InterpretedFrame InterpretedFrame Pointer )
            value.Continuations                             = GetInt32List(new IntPtr(p + 0x020)); // 0x20 Continuations               ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ContinuationIndex                         = GetInt32(new IntPtr(p + 0x028)); // 0x28 ContinuationIndex           ( ModelPrimitiveType int int int Int32 )
            value.PendingContinuation                       = GetInt32(new IntPtr(p + 0x02C)); // 0x2C PendingContinuation         ( ModelPrimitiveType int int int Int32 )
            value.Closure                                   = GetObjectList<IStrongBox>(new IntPtr(p + 0x040), ReversePrism.DataModels.IStrongBox.FromPointer); // 0x40 Closure                     ( ModelClassListType IStrongBox[] IStrongBox[] List<IStrongBox> Pointer )
            value.StackIndex                                = GetInt32(new IntPtr(p + 0x048)); // 0x48 StackIndex                  ( ModelPrimitiveType int int int Int32 )
            value.InstructionIndex                          = GetInt32(new IntPtr(p + 0x04C)); // 0x4C InstructionIndex            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
