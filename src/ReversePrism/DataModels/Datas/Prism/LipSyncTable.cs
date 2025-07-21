using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 defaultFrameRate                         int IL2CPP_TYPE_I4
    // 000 defaultOffsetFrame                       int IL2CPP_TYPE_I4
    // 018 FrameRate                                ModelPrimitiveType int int int Int32
    // 01C OffsetFrame                              ModelPrimitiveType int int int Int32
    // 020 Datas                                    ModelClassListType LipData[] LipData[] List<LipData> Pointer
    // 028 LastFrame                                ModelPrimitiveType double double double Double
    // 030 CurveData                                ModelClassType LipCurveData LipCurveData LipCurveData Pointer
    public partial class LipSyncTable : DataModel
    {
        public int                                      FrameRate                               { get; set; }
        public int                                      OffsetFrame                             { get; set; }
        public List<LipData>?                           Datas                                   { get; set; }
        public double                                   LastFrame                               { get; set; }
        public LipCurveData?                            CurveData                               { get; set; }

        public static LipSyncTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LipSyncTable() { Pointer= p0 };

            value.FrameRate                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 FrameRate                   ( ModelPrimitiveType int int int Int32 )
            value.OffsetFrame                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C OffsetFrame                 ( ModelPrimitiveType int int int Int32 )
            value.Datas                                     = GetObjectList<LipData>(new IntPtr(p + 0x020), ReversePrism.DataModels.LipData.FromPointer); // 0x20 Datas                       ( ModelClassListType LipData[] LipData[] List<LipData> Pointer )
            value.LastFrame                                 = GetDouble(new IntPtr(p + 0x028)); // 0x28 LastFrame                   ( ModelPrimitiveType double double double Double )
            value.CurveData                                 = GetObject<LipCurveData>(new IntPtr(p + 0x030), ReversePrism.DataModels.LipCurveData.FromPointer); // 0x30 CurveData                   ( ModelClassType LipCurveData LipCurveData LipCurveData Pointer )

            return value;
        }
    }
}
