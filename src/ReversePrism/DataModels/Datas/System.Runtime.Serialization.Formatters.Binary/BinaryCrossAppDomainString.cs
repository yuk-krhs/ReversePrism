using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectId                                 ModelPrimitiveType int int int Int32
    // 014 Value                                    ModelPrimitiveType int int int Int32
    public partial class BinaryCrossAppDomainString : DataModel
    {
        public int                                      ObjectId                                { get; set; }
        public int                                      Value                                   { get; set; }

        public static BinaryCrossAppDomainString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryCrossAppDomainString() { Pointer= p0 };

            value.ObjectId                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 ObjectId                    ( ModelPrimitiveType int int int Int32 )
            value.Value                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Value                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
