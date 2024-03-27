using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 PrefabName                               000186672F10 ModelPrimitiveType string string string String
    public partial class MstAccessoryResource
    {
        public int                                      Id                                      { get; set; }
        public string                                   PrefabName                              { get; set; }

        public static MstAccessoryResource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstAccessoryResource();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 027004632AE0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.PrefabName                                = GetString(new IntPtr(p + 0x018)); // 027004632B00 0x18 PrefabName                  ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
