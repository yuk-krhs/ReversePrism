using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Guid                                     0001865DBED0 ModelEnumType Guid Guid Guid Int32
    public partial class CriMonoBehaviour
    {
        public Guid                                     Guid                                    { get; set; }

        public static CriMonoBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriMonoBehaviour();

            value.Guid                                      = (Guid)GetInt32(new IntPtr(p + 0x020)); // 0270D11069E0 0x20 Guid                        ( 0001865DBED0 ModelEnumType Guid Guid Guid Int32 )

            return value;
        }
    }
}
