using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_PageHeight                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_Pages                                  000185D1FC18 ModelEnumListType List`1<Page> List`1<Page> List<Page> Pointer
    // 020 M_AllocMap                               000185D191C8 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 028 M_EntryWidth                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C M_EntryHeight                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class BitmapAllocator32 : DataModel
    {
        public int                                      M_PageHeight                            { get; set; }
        public List<Page>?                              M_Pages                                 { get; set; }
        public List<uint>?                              M_AllocMap                              { get; set; }
        public int                                      M_EntryWidth                            { get; set; }
        public int                                      M_EntryHeight                           { get; set; }

        public static BitmapAllocator32? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitmapAllocator32() { Pointer= p0 };

            value.M_PageHeight                              = GetInt32(new IntPtr(p + 0x010)); // 0245A682D308 0x10 M_PageHeight                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Pages                                   = GetEnumList<Page>(new IntPtr(p + 0x018)); // 0245A682D328 0x18 M_Pages                     ( 000185D1FC18 ModelEnumListType List`1<Page> List`1<Page> List<Page> Pointer )
            value.M_AllocMap                                = GetUInt32List(new IntPtr(p + 0x020)); // 0245A682D348 0x20 M_AllocMap                  ( 000185D191C8 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.M_EntryWidth                              = GetInt32(new IntPtr(p + 0x028)); // 0245A682D368 0x28 M_EntryWidth                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_EntryHeight                             = GetInt32(new IntPtr(p + 0x02C)); // 0245A682D388 0x2C M_EntryHeight               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
