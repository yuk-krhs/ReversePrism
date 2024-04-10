using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NumChannels                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 RmsLevels                                000185B81190 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 020 PeakLevels                               000185B81190 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 028 PeakHoldLevels                           000185B81190 ModelPrimitiveListType float[] float[] List<float> Pointer
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

            value.NumChannels                               = GetInt32(new IntPtr(p + 0x010)); // 02466AC89D20 0x10 NumChannels                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RmsLevels                                 = GetSingleList(new IntPtr(p + 0x018)); // 02466AC89D40 0x18 RmsLevels                   ( 000185B81190 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.PeakLevels                                = GetSingleList(new IntPtr(p + 0x020)); // 02466AC89D60 0x20 PeakLevels                  ( 000185B81190 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.PeakHoldLevels                            = GetSingleList(new IntPtr(p + 0x028)); // 02466AC89D80 0x28 PeakHoldLevels              ( 000185B81190 ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
