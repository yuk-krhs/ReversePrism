using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // FFFFFFFF s_currentFrame                           InterpretedFrame IL2CPP_TYPE_CLASS
    // 010 Interpreter                              000186721D50 ModelClassType Interpreter Interpreter Interpreter Pointer
    // 018 Parent                                   0001867209B0 ModelClassType InterpretedFrame InterpretedFrame InterpretedFrame Pointer
    // 020 Continuations                            000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 ContinuationIndex                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C PendingContinuation                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 _pendingValue                            <object> IL2CPP_TYPE_OBJECT
    // 038 Data                                     <object>[] IL2CPP_TYPE_SZARRAY
    // 040 Closure                                  000185B898E0 ModelClassListType IStrongBox[] IStrongBox[] List<IStrongBox> Pointer
    // 048 StackIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 04C InstructionIndex                         0001865F36C0 ModelPrimitiveType int int int Int32
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

            value.Interpreter                               = GetObject<Interpreter>(new IntPtr(p + 0x010), ReversePrism.DataModels.Interpreter.FromPointer); // 024669FF3FD8 0x10 Interpreter                 ( 000186721D50 ModelClassType Interpreter Interpreter Interpreter Pointer )
            value.Parent                                    = GetObject<InterpretedFrame>(new IntPtr(p + 0x018), ReversePrism.DataModels.InterpretedFrame.FromPointer); // 024669FF3FF8 0x18 Parent                      ( 0001867209B0 ModelClassType InterpretedFrame InterpretedFrame InterpretedFrame Pointer )
            value.Continuations                             = GetInt32List(new IntPtr(p + 0x020)); // 024669FF4018 0x20 Continuations               ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ContinuationIndex                         = GetInt32(new IntPtr(p + 0x028)); // 024669FF4038 0x28 ContinuationIndex           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PendingContinuation                       = GetInt32(new IntPtr(p + 0x02C)); // 024669FF4058 0x2C PendingContinuation         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Closure                                   = GetObjectList<IStrongBox>(new IntPtr(p + 0x040), ReversePrism.DataModels.IStrongBox.FromPointer); // 024669FF40B8 0x40 Closure                     ( 000185B898E0 ModelClassListType IStrongBox[] IStrongBox[] List<IStrongBox> Pointer )
            value.StackIndex                                = GetInt32(new IntPtr(p + 0x048)); // 024669FF40D8 0x48 StackIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.InstructionIndex                          = GetInt32(new IntPtr(p + 0x04C)); // 024669FF40F8 0x4C InstructionIndex            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
