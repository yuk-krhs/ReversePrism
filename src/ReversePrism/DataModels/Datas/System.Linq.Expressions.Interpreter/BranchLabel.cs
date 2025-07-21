using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetIndex                              ModelPrimitiveType int int int Int32
    // 014 StackDepth                               ModelPrimitiveType int int int Int32
    // 018 ContinuationStackDepth                   ModelPrimitiveType int int int Int32
    // 020 ForwardBranchFixups                      ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 028 LabelIndex                               ModelPrimitiveType int int int Int32
    public partial class BranchLabel : DataModel
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
            var value   = new BranchLabel() { Pointer= p0 };

            value.TargetIndex                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 TargetIndex                 ( ModelPrimitiveType int int int Int32 )
            value.StackDepth                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 StackDepth                  ( ModelPrimitiveType int int int Int32 )
            value.ContinuationStackDepth                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 ContinuationStackDepth      ( ModelPrimitiveType int int int Int32 )
            value.ForwardBranchFixups                       = GetInt32List(new IntPtr(p + 0x020)); // 0x20 ForwardBranchFixups         ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.LabelIndex                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 LabelIndex                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
