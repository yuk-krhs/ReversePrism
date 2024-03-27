using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 DisplayPriority                          0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstGalleryEtcCategory
    {
        public int                                      Id                                      { get; set; }
        public int                                      DisplayPriority                         { get; set; }

        public static MstGalleryEtcCategory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstGalleryEtcCategory();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 02700459F4E0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.DisplayPriority                           = GetInt32(new IntPtr(p + 0x014)); // 02700459F500 0x14 DisplayPriority             ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
