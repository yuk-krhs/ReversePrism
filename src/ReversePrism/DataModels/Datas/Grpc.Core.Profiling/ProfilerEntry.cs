using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Timespec                                 0001866750A0 ModelEnumType Timespec Timespec Timespec Int32
    // 020 Type                                     00018667D4D0 ModelEnumType Type Type Type Int32
    // 028 Tag                                      0001866722E0 ModelPrimitiveType string string string String
    public partial class ProfilerEntry
    {
        public Timespec                                 Timespec                                { get; set; }
        public Type                                     Type                                    { get; set; }
        public string                                   Tag                                     { get; set; }

        public static ProfilerEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilerEntry();

            value.Timespec                                  = (Timespec)GetInt32(new IntPtr(p + 0x010)); // 0270D938A728 0x10 Timespec                    ( 0001866750A0 ModelEnumType Timespec Timespec Timespec Int32 )
            value.Type                                      = (Type)GetInt32(new IntPtr(p + 0x020)); // 0270D938A748 0x20 Type                        ( 00018667D4D0 ModelEnumType Type Type Type Int32 )
            value.Tag                                       = GetString(new IntPtr(p + 0x028)); // 0270D938A768 0x28 Tag                         ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
