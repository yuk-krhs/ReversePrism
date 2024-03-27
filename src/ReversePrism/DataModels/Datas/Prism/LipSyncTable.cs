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
    // 018 FrameRate                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C OffsetFrame                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Datas                                    000185B90480 ModelClassListType LipData[] LipData[] List<LipData> Pointer
    // 028 LastFrame                                0001865C2E50 ModelPrimitiveType double double double Double
    // 030 CurveData                                000186532C00 ModelClassType LipCurveData LipCurveData LipCurveData Pointer
    public partial class LipSyncTable
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
            var value   = new LipSyncTable();

            value.FrameRate                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D4D9E3A0 0x18 FrameRate                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OffsetFrame                               = GetInt32(new IntPtr(p + 0x01C)); // 0270D4D9E3C0 0x1C OffsetFrame                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Datas                                     = GetObjectList<LipData>(new IntPtr(p + 0x020), ReversePrism.DataModels.LipData.FromPointer); // 0270D4D9E3E0 0x20 Datas                       ( 000185B90480 ModelClassListType LipData[] LipData[] List<LipData> Pointer )
            value.LastFrame                                 = GetDouble(new IntPtr(p + 0x028)); // 0270D4D9E400 0x28 LastFrame                   ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.CurveData                                 = GetObject<LipCurveData>(new IntPtr(p + 0x030), ReversePrism.DataModels.LipCurveData.FromPointer); // 0270D4D9E420 0x30 CurveData                   ( 000186532C00 ModelClassType LipCurveData LipCurveData LipCurveData Pointer )

            return value;
        }
    }
}
