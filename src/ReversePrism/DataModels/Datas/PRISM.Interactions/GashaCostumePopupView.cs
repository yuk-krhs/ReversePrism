using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoCostumeContent                         0001865F73D0 ModelClassType GashaDetailCostumeCell GashaDetailCostumeCell GashaDetailCostumeCell Pointer
    // 028 CostumeParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 <OnClickPIdol>k__BackingField            IObservable`1<int> IL2CPP_TYPE_GENERICINST
    // 038 <OnCostumeDetail>k__BackingField         IObservable`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    // 040 <OnClickDressUpRoom>k__BackingField      IObservable`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 048 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaCostumePopupView
    {
        public GashaDetailCostumeCell?                  GoCostumeContent                        { get; set; }
        public Transform?                               CostumeParent                           { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaCostumePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaCostumePopupView();

            value.GoCostumeContent                          = GetObject<GashaDetailCostumeCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaDetailCostumeCell.FromPointer); // 0270DB9DF8B0 0x20 GoCostumeContent            ( 0001865F73D0 ModelClassType GashaDetailCostumeCell GashaDetailCostumeCell GashaDetailCostumeCell Pointer )
            value.CostumeParent                             = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB9DF8D0 0x28 CostumeParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB9DF970 0x50 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
