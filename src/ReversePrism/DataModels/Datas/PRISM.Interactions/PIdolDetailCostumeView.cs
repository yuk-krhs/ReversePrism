using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoContent                                00018662ABC0 ModelClassType CostumeContentView CostumeContentView CostumeContentView Pointer
    // 030 ContentParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 <OnCostumeDetail>k__BackingField         IObservable`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    public partial class PIdolDetailCostumeView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public CostumeContentView?                      GoContent                               { get; set; }
        public Transform?                               ContentParent                           { get; set; }

        public static PIdolDetailCostumeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolDetailCostumeView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA305470 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoContent                                 = GetObject<CostumeContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CostumeContentView.FromPointer); // 0270DA305490 0x28 GoContent                   ( 00018662ABC0 ModelClassType CostumeContentView CostumeContentView CostumeContentView Pointer )
            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270DA3054B0 0x30 ContentParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
