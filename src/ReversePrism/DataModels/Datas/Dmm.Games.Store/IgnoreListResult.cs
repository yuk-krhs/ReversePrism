using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TotalResults                             ModelPrimitiveType int int int Int32
    // 014 ItemsPerPage                             ModelPrimitiveType int int int Int32
    // 018 StartIndex                               ModelPrimitiveType int int int Int32
    // 020 Items                                    ModelClassListType List`1<Entry> List`1<Entry> List<Entry> Pointer
    public partial class IgnoreListResult : DataModel
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
            var value   = new IgnoreListResult() { Pointer= p0 };

            value.TotalResults                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 TotalResults                ( ModelPrimitiveType int int int Int32 )
            value.ItemsPerPage                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 ItemsPerPage                ( ModelPrimitiveType int int int Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 StartIndex                  ( ModelPrimitiveType int int int Int32 )
            value.Items                                     = GetObjectList<Entry>(new IntPtr(p + 0x020), ReversePrism.DataModels.Entry.FromPointer); // 0x20 Items                       ( ModelClassListType List`1<Entry> List`1<Entry> List<Entry> Pointer )

            return value;
        }
    }
}
