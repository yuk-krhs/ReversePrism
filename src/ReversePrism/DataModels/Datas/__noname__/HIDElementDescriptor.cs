using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Usage                                    ModelPrimitiveType int int int Int32
    // 014 UsagePage                                ModelEnumType UsagePage UsagePage UsagePage Int32
    // 018 Unit                                     ModelPrimitiveType int int int Int32
    // 01C UnitExponent                             ModelPrimitiveType int int int Int32
    // 020 LogicalMin                               ModelPrimitiveType int int int Int32
    // 024 LogicalMax                               ModelPrimitiveType int int int Int32
    // 028 PhysicalMin                              ModelPrimitiveType int int int Int32
    // 02C PhysicalMax                              ModelPrimitiveType int int int Int32
    // 030 ReportType                               ModelEnumType HIDReportType HIDReportType HIDReportType Int32
    // 034 CollectionIndex                          ModelPrimitiveType int int int Int32
    // 038 ReportId                                 ModelPrimitiveType int int int Int32
    // 03C ReportSizeInBits                         ModelPrimitiveType int int int Int32
    // 040 ReportOffsetInBits                       ModelPrimitiveType int int int Int32
    // 044 Flags                                    ModelEnumType HIDElementFlags HIDElementFlags HIDElementFlags Int32
    // 048 usageMin                                 Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 050 usageMax                                 Nullable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class HIDElementDescriptor : DataModel
    {
        public int                                      Usage                                   { get; set; }
        public UsagePage                                UsagePage                               { get; set; }
        public int                                      Unit                                    { get; set; }
        public int                                      UnitExponent                            { get; set; }
        public int                                      LogicalMin                              { get; set; }
        public int                                      LogicalMax                              { get; set; }
        public int                                      PhysicalMin                             { get; set; }
        public int                                      PhysicalMax                             { get; set; }
        public HIDReportType                            ReportType                              { get; set; }
        public int                                      CollectionIndex                         { get; set; }
        public int                                      ReportId                                { get; set; }
        public int                                      ReportSizeInBits                        { get; set; }
        public int                                      ReportOffsetInBits                      { get; set; }
        public HIDElementFlags                          Flags                                   { get; set; }

        public static HIDElementDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HIDElementDescriptor() { Pointer= p0 };

            value.Usage                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Usage                       ( ModelPrimitiveType int int int Int32 )
            value.UsagePage                                 = (UsagePage)GetInt32(new IntPtr(p + 0x014)); // 0x14 UsagePage                   ( ModelEnumType UsagePage UsagePage UsagePage Int32 )
            value.Unit                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Unit                        ( ModelPrimitiveType int int int Int32 )
            value.UnitExponent                              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C UnitExponent                ( ModelPrimitiveType int int int Int32 )
            value.LogicalMin                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 LogicalMin                  ( ModelPrimitiveType int int int Int32 )
            value.LogicalMax                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 LogicalMax                  ( ModelPrimitiveType int int int Int32 )
            value.PhysicalMin                               = GetInt32(new IntPtr(p + 0x028)); // 0x28 PhysicalMin                 ( ModelPrimitiveType int int int Int32 )
            value.PhysicalMax                               = GetInt32(new IntPtr(p + 0x02C)); // 0x2C PhysicalMax                 ( ModelPrimitiveType int int int Int32 )
            value.ReportType                                = (HIDReportType)GetInt32(new IntPtr(p + 0x030)); // 0x30 ReportType                  ( ModelEnumType HIDReportType HIDReportType HIDReportType Int32 )
            value.CollectionIndex                           = GetInt32(new IntPtr(p + 0x034)); // 0x34 CollectionIndex             ( ModelPrimitiveType int int int Int32 )
            value.ReportId                                  = GetInt32(new IntPtr(p + 0x038)); // 0x38 ReportId                    ( ModelPrimitiveType int int int Int32 )
            value.ReportSizeInBits                          = GetInt32(new IntPtr(p + 0x03C)); // 0x3C ReportSizeInBits            ( ModelPrimitiveType int int int Int32 )
            value.ReportOffsetInBits                        = GetInt32(new IntPtr(p + 0x040)); // 0x40 ReportOffsetInBits          ( ModelPrimitiveType int int int Int32 )
            value.Flags                                     = (HIDElementFlags)GetInt32(new IntPtr(p + 0x044)); // 0x44 Flags                       ( ModelEnumType HIDElementFlags HIDElementFlags HIDElementFlags Int32 )

            return value;
        }
    }
}
