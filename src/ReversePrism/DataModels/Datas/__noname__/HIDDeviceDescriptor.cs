using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VendorId                                 ModelPrimitiveType int int int Int32
    // 014 ProductId                                ModelPrimitiveType int int int Int32
    // 018 Usage                                    ModelPrimitiveType int int int Int32
    // 01C UsagePage                                ModelEnumType UsagePage UsagePage UsagePage Int32
    // 020 InputReportSize                          ModelPrimitiveType int int int Int32
    // 024 OutputReportSize                         ModelPrimitiveType int int int Int32
    // 028 FeatureReportSize                        ModelPrimitiveType int int int Int32
    // 030 Elements                                 ModelEnumListType HIDElementDescriptor[] HIDElementDescriptor[] List<HIDElementDescriptor> Pointer
    // 038 Collections                              ModelEnumListType HIDCollectionDescriptor[] HIDCollectionDescriptor[] List<HIDCollectionDescriptor> Pointer
    public partial class HIDDeviceDescriptor : DataModel
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
            var value   = new HIDDeviceDescriptor() { Pointer= p0 };

            value.VendorId                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 VendorId                    ( ModelPrimitiveType int int int Int32 )
            value.ProductId                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 ProductId                   ( ModelPrimitiveType int int int Int32 )
            value.Usage                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Usage                       ( ModelPrimitiveType int int int Int32 )
            value.UsagePage                                 = (UsagePage)GetInt32(new IntPtr(p + 0x01C)); // 0x1C UsagePage                   ( ModelEnumType UsagePage UsagePage UsagePage Int32 )
            value.InputReportSize                           = GetInt32(new IntPtr(p + 0x020)); // 0x20 InputReportSize             ( ModelPrimitiveType int int int Int32 )
            value.OutputReportSize                          = GetInt32(new IntPtr(p + 0x024)); // 0x24 OutputReportSize            ( ModelPrimitiveType int int int Int32 )
            value.FeatureReportSize                         = GetInt32(new IntPtr(p + 0x028)); // 0x28 FeatureReportSize           ( ModelPrimitiveType int int int Int32 )
            value.Elements                                  = GetEnumList<HIDElementDescriptor>(new IntPtr(p + 0x030)); // 0x30 Elements                    ( ModelEnumListType HIDElementDescriptor[] HIDElementDescriptor[] List<HIDElementDescriptor> Pointer )
            value.Collections                               = GetEnumList<HIDCollectionDescriptor>(new IntPtr(p + 0x038)); // 0x38 Collections                 ( ModelEnumListType HIDCollectionDescriptor[] HIDCollectionDescriptor[] List<HIDCollectionDescriptor> Pointer )

            return value;
        }
    }
}
