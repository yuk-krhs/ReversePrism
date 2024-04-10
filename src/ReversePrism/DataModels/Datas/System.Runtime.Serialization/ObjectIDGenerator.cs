using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_currentCount                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 M_currentSize                            0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 M_ids                                    000185B7E3E0 ModelPrimitiveListType long[] long[] List<long> Pointer
    // 020 m_objs                                   <object>[] IL2CPP_TYPE_SZARRAY
    // 000 sizes                                    int[] IL2CPP_TYPE_SZARRAY
    public partial class ObjectIDGenerator : DataModel
    {
        public int                                      M_currentCount                          { get; set; }
        public int                                      M_currentSize                           { get; set; }
        public List<long>?                              M_ids                                   { get; set; }

        public static ObjectIDGenerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectIDGenerator() { Pointer= p0 };

            value.M_currentCount                            = GetInt32(new IntPtr(p + 0x010)); // 024666C8D270 0x10 M_currentCount              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_currentSize                             = GetInt32(new IntPtr(p + 0x014)); // 024666C8D290 0x14 M_currentSize               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_ids                                     = GetInt64List(new IntPtr(p + 0x018)); // 024666C8D2B0 0x18 M_ids                       ( 000185B7E3E0 ModelPrimitiveListType long[] long[] List<long> Pointer )

            return value;
        }
    }
}
