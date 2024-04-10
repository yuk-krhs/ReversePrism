using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Entries                                  000185B9F270 ModelEnumListType ProfilerEntry[] ProfilerEntry[] List<ProfilerEntry> Pointer
    // 018 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class BasicProfiler : DataModel
    {
        public List<ProfilerEntry>?                     Entries                                 { get; set; }
        public int                                      Count                                   { get; set; }

        public static BasicProfiler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BasicProfiler() { Pointer= p0 };

            value.Entries                                   = GetEnumList<ProfilerEntry>(new IntPtr(p + 0x010)); // 0245A412FC80 0x10 Entries                     ( 000185B9F270 ModelEnumListType ProfilerEntry[] ProfilerEntry[] List<ProfilerEntry> Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 0245A412FCA0 0x18 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
