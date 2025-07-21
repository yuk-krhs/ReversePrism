using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 NativeListener                           ModelClassType CriAtomEx3dListener CriAtomEx3dListener CriAtomEx3dListener Pointer
    // 038 RegionOnStart                            ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer
    // 040 ActivateListenerOnEnable                 ModelPrimitiveType bool bool bool Bool
    // 000 listenersList                            List`1<CriAtomListener> IL2CPP_TYPE_GENERICINST
    // 008 dummyNativeListener                      CriAtomEx3dListener IL2CPP_TYPE_CLASS
    // 044 LastPosition                             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 050 CurrentRegion                            ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer
    // 058 IsActive                                 ModelPrimitiveType bool bool bool Bool
    public partial class CriAtomListener : DataModel
    {
        public CriAtomEx3dListener?                     NativeListener                          { get; set; }
        public CriAtomRegion?                           RegionOnStart                           { get; set; }
        public bool                                     ActivateListenerOnEnable                { get; set; }
        public Vector3                                  LastPosition                            { get; set; }
        public CriAtomRegion?                           CurrentRegion                           { get; set; }
        public bool                                     IsActive                                { get; set; }

        public static CriAtomListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomListener() { Pointer= p0 };

            value.NativeListener                            = GetObject<CriAtomEx3dListener>(new IntPtr(p + 0x030), ReversePrism.DataModels.CriAtomEx3dListener.FromPointer); // 0x30 NativeListener              ( ModelClassType CriAtomEx3dListener CriAtomEx3dListener CriAtomEx3dListener Pointer )
            value.RegionOnStart                             = GetObject<CriAtomRegion>(new IntPtr(p + 0x038), ReversePrism.DataModels.CriAtomRegion.FromPointer); // 0x38 RegionOnStart               ( ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer )
            value.ActivateListenerOnEnable                  = GetBool(new IntPtr(p + 0x040)); // 0x40 ActivateListenerOnEnable    ( ModelPrimitiveType bool bool bool Bool )
            value.LastPosition                              = (Vector3)GetInt32(new IntPtr(p + 0x044)); // 0x44 LastPosition                ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CurrentRegion                             = GetObject<CriAtomRegion>(new IntPtr(p + 0x050), ReversePrism.DataModels.CriAtomRegion.FromPointer); // 0x50 CurrentRegion               ( ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x058)); // 0x58 IsActive                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
