using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstLetterGroupId                         0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MstUnitId                                0001865F4260 ModelPrimitiveType int int int Int32
    // 020 ResourceId                               000186672F10 ModelPrimitiveType string string string String
    // 028 GalleryReleaseDate                       0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstLetter
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstLetterGroupId                        { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public string                                   ResourceId                              { get; set; }
        public DateTime                                 GalleryReleaseDate                      { get; set; }

        public static MstLetter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstLetter();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 02700459AF98 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstLetterGroupId                          = GetInt32(new IntPtr(p + 0x014)); // 02700459AFB8 0x14 MstLetterGroupId            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x018)); // 02700459AFD8 0x18 MstUnitId                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ResourceId                                = GetString(new IntPtr(p + 0x020)); // 02700459AFF8 0x20 ResourceId                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.GalleryReleaseDate                        = GetDateTime(new IntPtr(p + 0x028)); // 02700459B018 0x28 GalleryReleaseDate          ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
