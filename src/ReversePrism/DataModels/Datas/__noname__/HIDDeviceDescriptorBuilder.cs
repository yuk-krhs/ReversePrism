using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UsagePage                                00018652C5F0 ModelEnumType UsagePage UsagePage UsagePage Int32
    // 014 Usage                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 M_CurrentReportId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C M_CurrentReportType                      00018652B710 ModelEnumType HIDReportType HIDReportType HIDReportType Int32
    // 020 M_CurrentReportOffsetInBits              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_Elements                               000185D24C58 ModelEnumListType List`1<HIDElementDescriptor> List`1<HIDElementDescriptor> List<HIDElementDescriptor> Pointer
    // 030 M_Collections                            000185D24A28 ModelEnumListType List`1<HIDCollectionDescriptor> List`1<HIDCollectionDescriptor> List<HIDCollectionDescriptor> Pointer
    // 038 M_InputReportSize                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C M_OutputReportSize                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 M_FeatureReportSize                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class HIDDeviceDescriptorBuilder : DataModel
    {
        public UsagePage                                UsagePage                               { get; set; }
        public int                                      Usage                                   { get; set; }
        public int                                      M_CurrentReportId                       { get; set; }
        public HIDReportType                            M_CurrentReportType                     { get; set; }
        public int                                      M_CurrentReportOffsetInBits             { get; set; }
        public List<HIDElementDescriptor>?              M_Elements                              { get; set; }
        public List<HIDCollectionDescriptor>?           M_Collections                           { get; set; }
        public int                                      M_InputReportSize                       { get; set; }
        public int                                      M_OutputReportSize                      { get; set; }
        public int                                      M_FeatureReportSize                     { get; set; }

        public static HIDDeviceDescriptorBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HIDDeviceDescriptorBuilder() { Pointer= p0 };

            value.UsagePage                                 = (UsagePage)GetInt32(new IntPtr(p + 0x010)); // 024667817900 0x10 UsagePage                   ( 00018652C5F0 ModelEnumType UsagePage UsagePage UsagePage Int32 )
            value.Usage                                     = GetInt32(new IntPtr(p + 0x014)); // 024667817920 0x14 Usage                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.M_CurrentReportId                         = GetInt32(new IntPtr(p + 0x018)); // 024667817940 0x18 M_CurrentReportId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CurrentReportType                       = (HIDReportType)GetInt32(new IntPtr(p + 0x01C)); // 024667817960 0x1C M_CurrentReportType         ( 00018652B710 ModelEnumType HIDReportType HIDReportType HIDReportType Int32 )
            value.M_CurrentReportOffsetInBits               = GetInt32(new IntPtr(p + 0x020)); // 024667817980 0x20 M_CurrentReportOffsetInBits ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Elements                                = GetEnumList<HIDElementDescriptor>(new IntPtr(p + 0x028)); // 0246678179A0 0x28 M_Elements                  ( 000185D24C58 ModelEnumListType List`1<HIDElementDescriptor> List`1<HIDElementDescriptor> List<HIDElementDescriptor> Pointer )
            value.M_Collections                             = GetEnumList<HIDCollectionDescriptor>(new IntPtr(p + 0x030)); // 0246678179C0 0x30 M_Collections               ( 000185D24A28 ModelEnumListType List`1<HIDCollectionDescriptor> List`1<HIDCollectionDescriptor> List<HIDCollectionDescriptor> Pointer )
            value.M_InputReportSize                         = GetInt32(new IntPtr(p + 0x038)); // 0246678179E0 0x38 M_InputReportSize           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OutputReportSize                        = GetInt32(new IntPtr(p + 0x03C)); // 024667817A00 0x3C M_OutputReportSize          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_FeatureReportSize                       = GetInt32(new IntPtr(p + 0x040)); // 024667817A20 0x40 M_FeatureReportSize         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
