using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NumChannels                              ModelPrimitiveType int int int Int32
    // 018 RmsLevels                                ModelPrimitiveListType float[] float[] List<float> Pointer
    // 020 PeakLevels                               ModelPrimitiveListType float[] float[] List<float> Pointer
    // 028 PeakHoldLevels                           ModelPrimitiveListType float[] float[] List<float> Pointer
    public partial class BusAnalyzerInfo : DataModel
    {
        public int                                      NumChannels                             { get; set; }
        public List<float>?                             RmsLevels                               { get; set; }
        public List<float>?                             PeakLevels                              { get; set; }
        public List<float>?                             PeakHoldLevels                          { get; set; }

        public static BusAnalyzerInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BusAnalyzerInfo() { Pointer= p0 };

            value.NumChannels                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 NumChannels                 ( ModelPrimitiveType int int int Int32 )
            value.RmsLevels                                 = GetSingleList(new IntPtr(p + 0x018)); // 0x18 RmsLevels                   ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.PeakLevels                                = GetSingleList(new IntPtr(p + 0x020)); // 0x20 PeakLevels                  ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.PeakHoldLevels                            = GetSingleList(new IntPtr(p + 0x028)); // 0x28 PeakHoldLevels              ( ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
