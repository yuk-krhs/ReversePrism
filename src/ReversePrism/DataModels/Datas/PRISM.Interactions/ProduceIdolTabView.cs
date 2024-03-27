using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProduceIdolContentPrefab                 00018670DAD0 ModelClassType UnitInfoProduceIdolContent UnitInfoProduceIdolContent UnitInfoProduceIdolContent Pointer
    // 028 ProduceIdolContentArea                   0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class ProduceIdolTabView
    {
        public UnitInfoProduceIdolContent?              ProduceIdolContentPrefab                { get; set; }
        public Transform?                               ProduceIdolContentArea                  { get; set; }

        public static ProduceIdolTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolTabView();

            value.ProduceIdolContentPrefab                  = GetObject<UnitInfoProduceIdolContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitInfoProduceIdolContent.FromPointer); // 0270DA0FA198 0x20 ProduceIdolContentPrefab    ( 00018670DAD0 ModelClassType UnitInfoProduceIdolContent UnitInfoProduceIdolContent UnitInfoProduceIdolContent Pointer )
            value.ProduceIdolContentArea                    = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DA0FA1B8 0x28 ProduceIdolContentArea      ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
