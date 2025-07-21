using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstLetterGroupId                         ModelPrimitiveType int int int Int32
    // 018 MstUnitId                                ModelPrimitiveType int int int Int32
    // 020 ResourceId                               ModelPrimitiveType string string string String
    // 028 GalleryReleaseDate                       ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstLetter : DataModel
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
            var value   = new MstLetter() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstLetterGroupId                          = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstLetterGroupId            ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.ResourceId                                = GetString(new IntPtr(p + 0x020)); // 0x20 ResourceId                  ( ModelPrimitiveType string string string String )
            value.GalleryReleaseDate                        = GetDateTime(new IntPtr(p + 0x028)); // 0x28 GalleryReleaseDate          ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
