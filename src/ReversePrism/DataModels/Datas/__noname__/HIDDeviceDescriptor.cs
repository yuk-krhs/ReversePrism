using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VendorId                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 ProductId                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Usage                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C UsagePage                                00018652C5F0 ModelEnumType UsagePage UsagePage UsagePage Int32
    // 020 InputReportSize                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 OutputReportSize                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 FeatureReportSize                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 Elements                                 000185CBB198 ModelEnumListType HIDElementDescriptor[] HIDElementDescriptor[] List<HIDElementDescriptor> Pointer
    // 038 Collections                              000185CBB0F8 ModelEnumListType HIDCollectionDescriptor[] HIDCollectionDescriptor[] List<HIDCollectionDescriptor> Pointer
    public partial class HIDDeviceDescriptor
    {
        public int                                      VendorId                                { get; set; }
        public int                                      ProductId                               { get; set; }
        public int                                      Usage                                   { get; set; }
        public UsagePage                                UsagePage                               { get; set; }
        public int                                      InputReportSize                         { get; set; }
        public int                                      OutputReportSize                        { get; set; }
        public int                                      FeatureReportSize                       { get; set; }
        public List<HIDElementDescriptor>?              Elements                                { get; set; }
        public List<HIDCollectionDescriptor>?           Collections                             { get; set; }

        public static HIDDeviceDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HIDDeviceDescriptor();

            value.VendorId                                  = GetInt32(new IntPtr(p + 0x010)); // 027003496D30 0x10 VendorId                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ProductId                                 = GetInt32(new IntPtr(p + 0x014)); // 027003496D50 0x14 ProductId                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Usage                                     = GetInt32(new IntPtr(p + 0x018)); // 027003496D70 0x18 Usage                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UsagePage                                 = (UsagePage)GetInt32(new IntPtr(p + 0x01C)); // 027003496D90 0x1C UsagePage                   ( 00018652C5F0 ModelEnumType UsagePage UsagePage UsagePage Int32 )
            value.InputReportSize                           = GetInt32(new IntPtr(p + 0x020)); // 027003496DB0 0x20 InputReportSize             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OutputReportSize                          = GetInt32(new IntPtr(p + 0x024)); // 027003496DD0 0x24 OutputReportSize            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FeatureReportSize                         = GetInt32(new IntPtr(p + 0x028)); // 027003496DF0 0x28 FeatureReportSize           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Elements                                  = GetEnumList<HIDElementDescriptor>(new IntPtr(p + 0x030)); // 027003496E10 0x30 Elements                    ( 000185CBB198 ModelEnumListType HIDElementDescriptor[] HIDElementDescriptor[] List<HIDElementDescriptor> Pointer )
            value.Collections                               = GetEnumList<HIDCollectionDescriptor>(new IntPtr(p + 0x038)); // 027003496E30 0x38 Collections                 ( 000185CBB0F8 ModelEnumListType HIDCollectionDescriptor[] HIDCollectionDescriptor[] List<HIDCollectionDescriptor> Pointer )

            return value;
        }
    }
}
