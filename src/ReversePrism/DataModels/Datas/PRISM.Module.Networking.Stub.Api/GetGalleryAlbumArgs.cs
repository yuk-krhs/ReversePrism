using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGalleryAlbumArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    public partial class GetGalleryAlbumArgs : DataModel
    {
        public int                                      MstCharacterInfoId                      { get; set; }

        public static GetGalleryAlbumArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGalleryAlbumArgs() { Pointer= p0 };

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
