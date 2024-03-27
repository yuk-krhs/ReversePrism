using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TotalResults                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 ItemsPerPage                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 StartIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Items                                    000185CD9288 ModelClassListType List`1<Entry> List`1<Entry> List<Entry> Pointer
    public partial class IgnoreListResult
    {
        public int                                      TotalResults                            { get; set; }
        public int                                      ItemsPerPage                            { get; set; }
        public int                                      StartIndex                              { get; set; }
        public List<Entry>?                             Items                                   { get; set; }

        public static IgnoreListResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IgnoreListResult();

            value.TotalResults                              = GetInt32(new IntPtr(p + 0x010)); // 0270DB4B75A0 0x10 TotalResults                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ItemsPerPage                              = GetInt32(new IntPtr(p + 0x014)); // 0270DB4B75C0 0x14 ItemsPerPage                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x018)); // 0270DB4B75E0 0x18 StartIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Items                                     = GetObjectList<Entry>(new IntPtr(p + 0x020), ReversePrism.DataModels.Entry.FromPointer); // 0270DB4B7600 0x20 Items                       ( 000185CD9288 ModelClassListType List`1<Entry> List`1<Entry> List<Entry> Pointer )

            return value;
        }
    }
}
