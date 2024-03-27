using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Entries                                  000185CBF718 ModelClassListType Entry[] Entry[] List<Entry> Pointer
    // 018 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Mask                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 HashCodeRandomizer                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class NameTable
    {
        public List<Entry>?                             Entries                                 { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      Mask                                    { get; set; }
        public int                                      HashCodeRandomizer                      { get; set; }

        public static NameTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameTable();

            value.Entries                                   = GetObjectList<Entry>(new IntPtr(p + 0x010), ReversePrism.DataModels.Entry.FromPointer); // 0270D7472F58 0x10 Entries                     ( 000185CBF718 ModelClassListType Entry[] Entry[] List<Entry> Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D7472F78 0x18 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Mask                                      = GetInt32(new IntPtr(p + 0x01C)); // 0270D7472F98 0x1C Mask                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HashCodeRandomizer                        = GetInt32(new IntPtr(p + 0x020)); // 0270D7472FB8 0x20 HashCodeRandomizer          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
