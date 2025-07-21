using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 HashCodeRandomizer                       int IL2CPP_TYPE_I4
    // 010 Count                                    ModelPrimitiveType int int int Int32
    // 018 Entries                                  ModelClassListType Entry[] Entry[] List<Entry> Pointer
    // 020 Mask                                     ModelPrimitiveType int int int Int32
    public partial class DefaultJsonNameTable : DataModel
    {
        public int                                      Count                                   { get; set; }
        public List<Entry>?                             Entries                                 { get; set; }
        public int                                      Mask                                    { get; set; }

        public static DefaultJsonNameTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultJsonNameTable() { Pointer= p0 };

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Count                       ( ModelPrimitiveType int int int Int32 )
            value.Entries                                   = GetObjectList<Entry>(new IntPtr(p + 0x018), ReversePrism.DataModels.Entry.FromPointer); // 0x18 Entries                     ( ModelClassListType Entry[] Entry[] List<Entry> Pointer )
            value.Mask                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Mask                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
