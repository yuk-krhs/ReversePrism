using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaHistoryCell                         000186604370 ModelClassType GashaHistoryCell GashaHistoryCell GashaHistoryCell Pointer
    // 028 GoTemplate                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 TraGasha                                 0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 TraGashaTitle                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 040 TraOmake                                 0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 048 TraOmakeTitle                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 050 TraPrismGauge                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 058 TraPrismGaugeTitle                       0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class GashaHistoryDetailScroll : DataModel
    {
        public GashaHistoryCell?                        GashaHistoryCell                        { get; set; }
        public GameObject?                              GoTemplate                              { get; set; }
        public Transform?                               TraGasha                                { get; set; }
        public Transform?                               TraGashaTitle                           { get; set; }
        public Transform?                               TraOmake                                { get; set; }
        public Transform?                               TraOmakeTitle                           { get; set; }
        public Transform?                               TraPrismGauge                           { get; set; }
        public Transform?                               TraPrismGaugeTitle                      { get; set; }

        public static GashaHistoryDetailScroll? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaHistoryDetailScroll() { Pointer= p0 };

            value.GashaHistoryCell                          = GetObject<GashaHistoryCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaHistoryCell.FromPointer); // 02466537B658 0x20 GashaHistoryCell            ( 000186604370 ModelClassType GashaHistoryCell GashaHistoryCell GashaHistoryCell Pointer )
            value.GoTemplate                                = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466537B678 0x28 GoTemplate                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TraGasha                                  = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 02466537B698 0x30 TraGasha                    ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.TraGashaTitle                             = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 02466537B6B8 0x38 TraGashaTitle               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.TraOmake                                  = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 02466537B6D8 0x40 TraOmake                    ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.TraOmakeTitle                             = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 02466537B6F8 0x48 TraOmakeTitle               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.TraPrismGauge                             = GetObject<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 02466537B718 0x50 TraPrismGauge               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.TraPrismGaugeTitle                        = GetObject<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 02466537B738 0x58 TraPrismGaugeTitle          ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
