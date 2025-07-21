using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectId                                 ModelPrimitiveType int int int Int32
    // 014 MapId                                    ModelPrimitiveType int int int Int32
    public partial class BinaryObject : DataModel
    {
        public int                                      ObjectId                                { get; set; }
        public int                                      MapId                                   { get; set; }

        public static BinaryObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryObject() { Pointer= p0 };

            value.ObjectId                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 ObjectId                    ( ModelPrimitiveType int int int Int32 )
            value.MapId                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 MapId                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
