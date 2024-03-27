using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     00018652A0D0 ModelEnumType HIDCollectionType HIDCollectionType HIDCollectionType Int32
    // 014 Usage                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 UsagePage                                00018652C5F0 ModelEnumType UsagePage UsagePage UsagePage Int32
    // 01C Parent                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 ChildCount                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 FirstChild                               0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class HIDCollectionDescriptor
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
            var value   = new HIDCollectionDescriptor();

            value.Type                                      = (HIDCollectionType)GetInt32(new IntPtr(p + 0x010)); // 0270D77BF840 0x10 Type                        ( 00018652A0D0 ModelEnumType HIDCollectionType HIDCollectionType HIDCollectionType Int32 )
            value.Usage                                     = GetInt32(new IntPtr(p + 0x014)); // 0270D77BF860 0x14 Usage                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UsagePage                                 = (UsagePage)GetInt32(new IntPtr(p + 0x018)); // 0270D77BF880 0x18 UsagePage                   ( 00018652C5F0 ModelEnumType UsagePage UsagePage UsagePage Int32 )
            value.Parent                                    = GetInt32(new IntPtr(p + 0x01C)); // 0270D77BF8A0 0x1C Parent                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ChildCount                                = GetInt32(new IntPtr(p + 0x020)); // 0270D77BF8C0 0x20 ChildCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FirstChild                                = GetInt32(new IntPtr(p + 0x024)); // 0270D77BF8E0 0x24 FirstChild                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
