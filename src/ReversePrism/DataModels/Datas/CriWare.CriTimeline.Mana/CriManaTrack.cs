using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 FrameSync                                ModelPrimitiveType bool bool bool Bool
    // 0A4 Guid                                     ModelEnumType Guid Guid Guid Int32
    // 000 bindDict                                 Dictionary`2<int, Guid> IL2CPP_TYPE_GENERICINST
    public partial class CriManaTrack : DataModel
    {
        public bool                                     FrameSync                               { get; set; }
        public Guid                                     Guid                                    { get; set; }

        public static CriManaTrack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriManaTrack() { Pointer= p0 };

            value.FrameSync                                 = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 FrameSync                   ( ModelPrimitiveType bool bool bool Bool )
            value.Guid                                      = (Guid)GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 Guid                        ( ModelEnumType Guid Guid Guid Int32 )

            return value;
        }
    }
}
