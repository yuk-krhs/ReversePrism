using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_NlsVersion                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_SortId                                 0001865DBED0 ModelEnumType Guid Guid Guid Int32
    public partial class SortVersion
    {
        public int                                      M_NlsVersion                            { get; set; }
        public Guid                                     M_SortId                                { get; set; }

        public static SortVersion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortVersion();

            value.M_NlsVersion                              = GetInt32(new IntPtr(p + 0x010)); // 0270D6D312B0 0x10 M_NlsVersion                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_SortId                                  = (Guid)GetInt32(new IntPtr(p + 0x014)); // 0270D6D312D0 0x14 M_SortId                    ( 0001865DBED0 ModelEnumType Guid Guid Guid Int32 )

            return value;
        }
    }
}
