using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Region3dHn                               000186644120 ModelClassType CriAtomEx3dRegion CriAtomEx3dRegion CriAtomEx3dRegion Pointer
    // 038 ReferringSources                         000185CD51B8 ModelClassListType List`1<CriAtomSourceBase> List`1<CriAtomSourceBase> List<CriAtomSourceBase> Pointer
    // 040 ReferringListeners                       000185CD4EA8 ModelClassListType List`1<CriAtomListener> List`1<CriAtomListener> List<CriAtomListener> Pointer
    // 048 ReferringTransceivers                    000185CD53D8 ModelClassListType List`1<CriAtomTransceiver> List`1<CriAtomTransceiver> List<CriAtomTransceiver> Pointer
    public partial class CriAtomRegion : DataModel
    {
        public CriAtomEx3dRegion?                       Region3dHn                              { get; set; }
        public List<CriAtomSourceBase>?                 ReferringSources                        { get; set; }
        public List<CriAtomListener>?                   ReferringListeners                      { get; set; }
        public List<CriAtomTransceiver>?                ReferringTransceivers                   { get; set; }

        public static CriAtomRegion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomRegion() { Pointer= p0 };

            value.Region3dHn                                = GetObject<CriAtomEx3dRegion>(new IntPtr(p + 0x030), ReversePrism.DataModels.CriAtomEx3dRegion.FromPointer); // 02466AC8B3D0 0x30 Region3dHn                  ( 000186644120 ModelClassType CriAtomEx3dRegion CriAtomEx3dRegion CriAtomEx3dRegion Pointer )
            value.ReferringSources                          = GetObjectList<CriAtomSourceBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.CriAtomSourceBase.FromPointer); // 02466AC8B3F0 0x38 ReferringSources            ( 000185CD51B8 ModelClassListType List`1<CriAtomSourceBase> List`1<CriAtomSourceBase> List<CriAtomSourceBase> Pointer )
            value.ReferringListeners                        = GetObjectList<CriAtomListener>(new IntPtr(p + 0x040), ReversePrism.DataModels.CriAtomListener.FromPointer); // 02466AC8B410 0x40 ReferringListeners          ( 000185CD4EA8 ModelClassListType List`1<CriAtomListener> List`1<CriAtomListener> List<CriAtomListener> Pointer )
            value.ReferringTransceivers                     = GetObjectList<CriAtomTransceiver>(new IntPtr(p + 0x048), ReversePrism.DataModels.CriAtomTransceiver.FromPointer); // 02466AC8B430 0x48 ReferringTransceivers       ( 000185CD53D8 ModelClassListType List`1<CriAtomTransceiver> List`1<CriAtomTransceiver> List<CriAtomTransceiver> Pointer )

            return value;
        }
    }
}
