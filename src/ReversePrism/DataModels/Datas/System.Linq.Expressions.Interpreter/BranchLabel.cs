using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 StackDepth                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 ContinuationStackDepth                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 ForwardBranchFixups                      000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 028 LabelIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class BranchLabel
    {
        public int                                      TargetIndex                             { get; set; }
        public int                                      StackDepth                              { get; set; }
        public int                                      ContinuationStackDepth                  { get; set; }
        public List<int>?                               ForwardBranchFixups                     { get; set; }
        public int                                      LabelIndex                              { get; set; }

        public static BranchLabel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BranchLabel();

            value.TargetIndex                               = GetInt32(new IntPtr(p + 0x010)); // 0270D9F874E8 0x10 TargetIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StackDepth                                = GetInt32(new IntPtr(p + 0x014)); // 0270D9F87508 0x14 StackDepth                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ContinuationStackDepth                    = GetInt32(new IntPtr(p + 0x018)); // 0270D9F87528 0x18 ContinuationStackDepth      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ForwardBranchFixups                       = GetInt32List(new IntPtr(p + 0x020)); // 0270D9F87548 0x20 ForwardBranchFixups         ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.LabelIndex                                = GetInt32(new IntPtr(p + 0x028)); // 0270D9F87568 0x28 LabelIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
