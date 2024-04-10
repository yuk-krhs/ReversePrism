using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ticksOffset                            0001865F7700 ModelPrimitiveType long long long Int64
    // 018 M_standardName                           000186671910 ModelPrimitiveType string string string String
    // 020 M_daylightName                           000186671910 ModelPrimitiveType string string string String
    // 028 M_CachedDaylightChanges                  0001865DF1C0 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class CurrentSystemTimeZone : DataModel
    {
        public long                                     M_ticksOffset                           { get; set; }
        public string                                   M_standardName                          { get; set; }
        public string                                   M_daylightName                          { get; set; }
        public Hashtable?                               M_CachedDaylightChanges                 { get; set; }

        public static CurrentSystemTimeZone? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CurrentSystemTimeZone() { Pointer= p0 };

            value.M_ticksOffset                             = GetInt64(new IntPtr(p + 0x010)); // 024666A0A818 0x10 M_ticksOffset               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.M_standardName                            = GetString(new IntPtr(p + 0x018)); // 024666A0A838 0x18 M_standardName              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_daylightName                            = GetString(new IntPtr(p + 0x020)); // 024666A0A858 0x20 M_daylightName              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_CachedDaylightChanges                   = GetObject<Hashtable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Hashtable.FromPointer); // 024666A0A878 0x28 M_CachedDaylightChanges     ( 0001865DF1C0 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
