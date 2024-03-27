using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GalleryAlbumProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 018 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 InitialStarFieldNumber                   int IL2CPP_TYPE_I4
    // 01C InitialStar                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 EnableFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Enable                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GalleryAlbumProduceIdolStatus
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      InitialStar                             { get; set; }
        public bool                                     Enable                                  { get; set; }

        public static GalleryAlbumProduceIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GalleryAlbumProduceIdolStatus();

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 027004209720 0x18 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x01C)); // 027004209760 0x1C InitialStar                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Enable                                    = GetBool(new IntPtr(p + 0x020)); // 0270042097A0 0x20 Enable                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
