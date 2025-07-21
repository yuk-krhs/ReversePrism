using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 CriAtomTimelinePreviewer IL2CPP_TYPE_CLASS
    // 010 Atom                                     ModelClassType CriAtom CriAtom CriAtom Pointer
    // 018 LastAcfFile                              ModelPrimitiveType string string string String
    // 020 acbTable                                 Dictionary`2<string, CriAtomExAcb> IL2CPP_TYPE_GENERICINST
    // 028 playerTable                              Dictionary`2<Guid, PlayerSource> IL2CPP_TYPE_GENERICINST
    // 030 Listener3d                               ModelClassType CriAtomEx3dListener CriAtomEx3dListener CriAtomEx3dListener Pointer
    public partial class CriAtomTimelinePreviewer : DataModel
    {
        public CriAtom?                                 Atom                                    { get; set; }
        public string                                   LastAcfFile                             { get; set; }
        public CriAtomEx3dListener?                     Listener3d                              { get; set; }

        public static CriAtomTimelinePreviewer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomTimelinePreviewer() { Pointer= p0 };

            value.Atom                                      = GetObject<CriAtom>(new IntPtr(p + 0x010), ReversePrism.DataModels.CriAtom.FromPointer); // 0x10 Atom                        ( ModelClassType CriAtom CriAtom CriAtom Pointer )
            value.LastAcfFile                               = GetString(new IntPtr(p + 0x018)); // 0x18 LastAcfFile                 ( ModelPrimitiveType string string string String )
            value.Listener3d                                = GetObject<CriAtomEx3dListener>(new IntPtr(p + 0x030), ReversePrism.DataModels.CriAtomEx3dListener.FromPointer); // 0x30 Listener3d                  ( ModelClassType CriAtomEx3dListener CriAtomEx3dListener CriAtomEx3dListener Pointer )

            return value;
        }
    }
}
