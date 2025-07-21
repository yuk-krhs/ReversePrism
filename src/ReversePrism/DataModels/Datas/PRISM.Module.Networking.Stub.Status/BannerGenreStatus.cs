using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<BannerGenreStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstBannerGenreIdFieldNumber              int IL2CPP_TYPE_I4
    // 018 MstBannerGenreId                         ModelPrimitiveType int int int Int32
    // 000 ResourceIdFieldNumber                    int IL2CPP_TYPE_I4
    // 020 ResourceId                               ModelPrimitiveType string string string String
    public partial class BannerGenreStatus : DataModel
    {
        public int                                      MstBannerGenreId                        { get; set; }
        public string                                   ResourceId                              { get; set; }

        public static BannerGenreStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BannerGenreStatus() { Pointer= p0 };

            value.MstBannerGenreId                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstBannerGenreId            ( ModelPrimitiveType int int int Int32 )
            value.ResourceId                                = GetString(new IntPtr(p + 0x020)); // 0x20 ResourceId                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
