using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Values                                 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 018 M_NumValues                              ModelPrimitiveType int int int Int32
    // 01C M_LastIndex                              ModelPrimitiveType int int int Int32
    // 020 M_AverageValue                           ModelPrimitiveType float float float Single
    public partial class RunningAverage : DataModel
    {
        public List<float>?                             M_Values                                { get; set; }
        public int                                      M_NumValues                             { get; set; }
        public int                                      M_LastIndex                             { get; set; }
        public float                                    M_AverageValue                          { get; set; }

        public static RunningAverage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RunningAverage() { Pointer= p0 };

            value.M_Values                                  = GetSingleList(new IntPtr(p + 0x010)); // 0x10 M_Values                    ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_NumValues                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_NumValues                 ( ModelPrimitiveType int int int Int32 )
            value.M_LastIndex                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_LastIndex                 ( ModelPrimitiveType int int int Int32 )
            value.M_AverageValue                            = GetSingle(new IntPtr(p + 0x020)); // 0x20 M_AverageValue              ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
