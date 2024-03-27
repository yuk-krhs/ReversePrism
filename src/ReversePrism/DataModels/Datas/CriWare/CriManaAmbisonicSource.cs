using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 AtomEx3DsourceForAmbisonics              0001866445E0 ModelClassType CriAtomEx3dSource CriAtomEx3dSource CriAtomEx3dSource Pointer
    // 038 AmbisonicSourceOrientationFront          0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 AmbisonicSourceOrientationTop            0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 050 LastEulerOfAmbisonicSource               0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class CriManaAmbisonicSource
    {
        public CriAtomEx3dSource?                       AtomEx3DsourceForAmbisonics             { get; set; }
        public Vector3                                  AmbisonicSourceOrientationFront         { get; set; }
        public Vector3                                  AmbisonicSourceOrientationTop           { get; set; }
        public Vector3                                  LastEulerOfAmbisonicSource              { get; set; }

        public static CriManaAmbisonicSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriManaAmbisonicSource();

            value.AtomEx3DsourceForAmbisonics               = GetObject<CriAtomEx3dSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CriAtomEx3dSource.FromPointer); // 0270DACBD7B0 0x30 AtomEx3DsourceForAmbisonics ( 0001866445E0 ModelClassType CriAtomEx3dSource CriAtomEx3dSource CriAtomEx3dSource Pointer )
            value.AmbisonicSourceOrientationFront           = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0270DACBD7D0 0x38 AmbisonicSourceOrientationFront ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.AmbisonicSourceOrientationTop             = (Vector3)GetInt32(new IntPtr(p + 0x044)); // 0270DACBD7F0 0x44 AmbisonicSourceOrientationTop ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LastEulerOfAmbisonicSource                = (Vector3)GetInt32(new IntPtr(p + 0x050)); // 0270DACBD810 0x50 LastEulerOfAmbisonicSource  ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
