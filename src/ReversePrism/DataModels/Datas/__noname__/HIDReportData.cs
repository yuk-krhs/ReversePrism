using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReportId                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 ReportType                               00018652B960 ModelEnumType HIDReportType HIDReportType HIDReportType Int32
    // 018 CurrentBitOffset                         0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class HIDReportData : DataModel
    {
        public int                                      ReportId                                { get; set; }
        public HIDReportType                            ReportType                              { get; set; }
        public int                                      CurrentBitOffset                        { get; set; }

        public static HIDReportData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HIDReportData() { Pointer= p0 };

            value.ReportId                                  = GetInt32(new IntPtr(p + 0x010)); // 02466782CF48 0x10 ReportId                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ReportType                                = (HIDReportType)GetInt32(new IntPtr(p + 0x014)); // 02466782CF68 0x14 ReportType                  ( 00018652B960 ModelEnumType HIDReportType HIDReportType HIDReportType Int32 )
            value.CurrentBitOffset                          = GetInt32(new IntPtr(p + 0x018)); // 02466782CF88 0x18 CurrentBitOffset            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
