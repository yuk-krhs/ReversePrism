using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 AppId                                    ModelPrimitiveType string string string String
    // 030 Size                                     ModelPrimitiveType string string string String
    // 038 Pids                                     ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 040 AdjustVga                                ModelPrimitiveType string string string String
    public partial class ThumbnailParameter : DataModel
    {
        public string                                   AppId                                   { get; set; }
        public string                                   Size                                    { get; set; }
        public List<string>?                            Pids                                    { get; set; }
        public string                                   AdjustVga                               { get; set; }

        public static ThumbnailParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThumbnailParameter() { Pointer= p0 };

            value.AppId                                     = GetString(new IntPtr(p + 0x028)); // 0x28 AppId                       ( ModelPrimitiveType string string string String )
            value.Size                                      = GetString(new IntPtr(p + 0x030)); // 0x30 Size                        ( ModelPrimitiveType string string string String )
            value.Pids                                      = GetStringList(new IntPtr(p + 0x038)); // 0x38 Pids                        ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.AdjustVga                                 = GetString(new IntPtr(p + 0x040)); // 0x40 AdjustVga                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
