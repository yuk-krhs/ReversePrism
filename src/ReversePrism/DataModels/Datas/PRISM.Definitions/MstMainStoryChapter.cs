using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstUnitId                                ModelPrimitiveType int int int Int32
    // 018 SortId                                   ModelPrimitiveType int int int Int32
    // 020 ReleaseDate                              ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstMainStoryChapter : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      SortId                                  { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }

        public static MstMainStoryChapter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstMainStoryChapter() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x020)); // 0x20 ReleaseDate                 ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
