using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_values                                 000185B7E2C0 ModelPrimitiveListType long[] long[] List<long> Pointer
    // 018 M_count                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C M_totalItems                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_currentItem                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LongList : DataModel
    {
        public List<long>?                              M_values                                { get; set; }
        public int                                      M_count                                 { get; set; }
        public int                                      M_totalItems                            { get; set; }
        public int                                      M_currentItem                           { get; set; }

        public static LongList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LongList() { Pointer= p0 };

            value.M_values                                  = GetInt64List(new IntPtr(p + 0x010)); // 024666C98370 0x10 M_values                    ( 000185B7E2C0 ModelPrimitiveListType long[] long[] List<long> Pointer )
            value.M_count                                   = GetInt32(new IntPtr(p + 0x018)); // 024666C98390 0x18 M_count                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_totalItems                              = GetInt32(new IntPtr(p + 0x01C)); // 024666C983B0 0x1C M_totalItems                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_currentItem                             = GetInt32(new IntPtr(p + 0x020)); // 024666C983D0 0x20 M_currentItem               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
