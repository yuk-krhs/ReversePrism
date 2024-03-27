using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectId                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 Value                                    0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class BinaryCrossAppDomainString
    {
        public int                                      ObjectId                                { get; set; }
        public int                                      Value                                   { get; set; }

        public static BinaryCrossAppDomainString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryCrossAppDomainString();

            value.ObjectId                                  = GetInt32(new IntPtr(p + 0x010)); // 0270D6C31EA8 0x10 ObjectId                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Value                                     = GetInt32(new IntPtr(p + 0x014)); // 0270D6C31EC8 0x14 Value                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
