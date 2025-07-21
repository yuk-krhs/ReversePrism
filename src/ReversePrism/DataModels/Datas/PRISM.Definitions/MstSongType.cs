using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 All                                      MstSongType IL2CPP_TYPE_CLASS
    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 SongCategory                             ModelPrimitiveType int int int Int32
    public partial class MstSongType : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      SongCategory                            { get; set; }

        public static MstSongType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstSongType() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.SongCategory                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 SongCategory                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
