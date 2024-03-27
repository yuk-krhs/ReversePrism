using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Guid                                     0001865DC380 ModelEnumType Guid Guid Guid Int32
    public partial class CriDisposable
    {
        public Guid                                     Guid                                    { get; set; }

        public static CriDisposable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriDisposable();

            value.Guid                                      = (Guid)GetInt32(new IntPtr(p + 0x010)); // 0270041D5068 0x10 Guid                        ( 0001865DC380 ModelEnumType Guid Guid Guid Int32 )

            return value;
        }
    }
}
