using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AutoReleaseKeepCount                     int IL2CPP_TYPE_I4
    // 000 queuedKeys                               HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 008 tags                                     List`1<ValueTuple`2<string, Dictionary`2<string, sbyte[]>>> IL2CPP_TYPE_GENERICINST
    // 010 TagCount                                 ModelPrimitiveType int int int Int32
    public partial class DataFile : DataModel
    {
        public int                                      TagCount                                { get; set; }

        public static DataFile? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataFile() { Pointer= p0 };

            value.TagCount                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 TagCount                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
