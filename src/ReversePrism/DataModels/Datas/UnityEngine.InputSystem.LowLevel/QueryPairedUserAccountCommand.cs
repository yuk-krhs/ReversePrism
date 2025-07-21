using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMaxNameLength                           int IL2CPP_TYPE_I4
    // 000 kMaxIdLength                             int IL2CPP_TYPE_I4
    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 010 BaseCommand                              ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32
    // 018 Handle                                   ModelPrimitiveType ulong ulong ulong UInt64
    // 020 NameBuffer                               ModelEnumType <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer Int32
    // 220 IdBuffer                                 ModelEnumType <idBuffer>e__FixedBuffer <idBuffer>e__FixedBuffer <idBuffer>e__FixedBuffer Int32
    public partial class QueryPairedUserAccountCommand : DataModel
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public ulong                                    Handle                                  { get; set; }
        public <nameBuffer>e__FixedBuffer               NameBuffer                              { get; set; }
        public <idBuffer>e__FixedBuffer                 IdBuffer                                { get; set; }

        public static QueryPairedUserAccountCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueryPairedUserAccountCommand() { Pointer= p0 };

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 0x10 BaseCommand                 ( ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.Handle                                    = GetUInt64(new IntPtr(p + 0x018)); // 0x18 Handle                      ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.NameBuffer                                = (<nameBuffer>e__FixedBuffer)GetInt32(new IntPtr(p + 0x020)); // 0x20 NameBuffer                  ( ModelEnumType <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer Int32 )
            value.IdBuffer                                  = (<idBuffer>e__FixedBuffer)GetInt32(new IntPtr(p + 0x220)); // 0x220 IdBuffer                    ( ModelEnumType <idBuffer>e__FixedBuffer <idBuffer>e__FixedBuffer <idBuffer>e__FixedBuffer Int32 )

            return value;
        }
    }
}
