using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaHistoryCell                         ModelClassType GashaHistoryCellView GashaHistoryCellView GashaHistoryCellView Pointer
    // 028 GoTemplate                               ModelClassType GameObject GameObject GameObject Pointer
    // 030 TraGasha                                 ModelClassType Transform Transform Transform Pointer
    // 038 TraGashaTitle                            ModelClassType Transform Transform Transform Pointer
    // 040 TraOmake                                 ModelClassType Transform Transform Transform Pointer
    // 048 TraOmakeTitle                            ModelClassType Transform Transform Transform Pointer
    // 050 TraPrismGauge                            ModelClassType Transform Transform Transform Pointer
    // 058 TraPrismGaugeTitle                       ModelClassType Transform Transform Transform Pointer
    public partial class GashaHistoryDetailScrollView : DataModel
    {
        public GashaHistoryCellView?                    GashaHistoryCell                        { get; set; }
        public GameObject?                              GoTemplate                              { get; set; }
        public Transform?                               TraGasha                                { get; set; }
        public Transform?                               TraGashaTitle                           { get; set; }
        public Transform?                               TraOmake                                { get; set; }
        public Transform?                               TraOmakeTitle                           { get; set; }
        public Transform?                               TraPrismGauge                           { get; set; }
        public Transform?                               TraPrismGaugeTitle                      { get; set; }

        public static GashaHistoryDetailScrollView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaHistoryDetailScrollView() { Pointer= p0 };

            value.GashaHistoryCell                          = GetObject<GashaHistoryCellView>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaHistoryCellView.FromPointer); // 0x20 GashaHistoryCell            ( ModelClassType GashaHistoryCellView GashaHistoryCellView GashaHistoryCellView Pointer )
            value.GoTemplate                                = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 GoTemplate                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TraGasha                                  = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 TraGasha                    ( ModelClassType Transform Transform Transform Pointer )
            value.TraGashaTitle                             = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0x38 TraGashaTitle               ( ModelClassType Transform Transform Transform Pointer )
            value.TraOmake                                  = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0x40 TraOmake                    ( ModelClassType Transform Transform Transform Pointer )
            value.TraOmakeTitle                             = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0x48 TraOmakeTitle               ( ModelClassType Transform Transform Transform Pointer )
            value.TraPrismGauge                             = GetObject<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0x50 TraPrismGauge               ( ModelClassType Transform Transform Transform Pointer )
            value.TraPrismGaugeTitle                        = GetObject<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 0x58 TraPrismGaugeTitle          ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
