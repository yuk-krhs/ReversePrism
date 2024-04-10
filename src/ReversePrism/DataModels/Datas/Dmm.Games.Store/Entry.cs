using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 IgnorelistId                             0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Entry : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      IgnorelistId                            { get; set; }

        public static Entry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Entry() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 02466B5479B0 0x10 Id                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IgnorelistId                              = GetInt32(new IntPtr(p + 0x014)); // 02466B5479D0 0x14 IgnorelistId                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
