using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType HIDCollectionType HIDCollectionType HIDCollectionType Int32
    // 014 Usage                                    ModelPrimitiveType int int int Int32
    // 018 UsagePage                                ModelEnumType UsagePage UsagePage UsagePage Int32
    // 01C Parent                                   ModelPrimitiveType int int int Int32
    // 020 ChildCount                               ModelPrimitiveType int int int Int32
    // 024 FirstChild                               ModelPrimitiveType int int int Int32
    public partial class HIDCollectionDescriptor : DataModel
    {
        public HIDCollectionType                        Type                                    { get; set; }
        public int                                      Usage                                   { get; set; }
        public UsagePage                                UsagePage                               { get; set; }
        public int                                      Parent                                  { get; set; }
        public int                                      ChildCount                              { get; set; }
        public int                                      FirstChild                              { get; set; }

        public static HIDCollectionDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HIDCollectionDescriptor() { Pointer= p0 };

            value.Type                                      = (HIDCollectionType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType HIDCollectionType HIDCollectionType HIDCollectionType Int32 )
            value.Usage                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Usage                       ( ModelPrimitiveType int int int Int32 )
            value.UsagePage                                 = (UsagePage)GetInt32(new IntPtr(p + 0x018)); // 0x18 UsagePage                   ( ModelEnumType UsagePage UsagePage UsagePage Int32 )
            value.Parent                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Parent                      ( ModelPrimitiveType int int int Int32 )
            value.ChildCount                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 ChildCount                  ( ModelPrimitiveType int int int Int32 )
            value.FirstChild                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 FirstChild                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
