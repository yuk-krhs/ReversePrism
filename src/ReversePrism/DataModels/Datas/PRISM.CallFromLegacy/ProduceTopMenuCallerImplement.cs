using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 viewFactory                              PopupViewFactory`1<IProduceGiveUpConfirmationPopupView> IL2CPP_TYPE_GENERICINST
    // 028 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 030 IsGiveupResult                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceTopMenuCallerImplement
    {
        public IResourceTag?                            ResourceTag                             { get; set; }
        public bool                                     IsGiveupResult                          { get; set; }

        public static ProduceTopMenuCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTopMenuCallerImplement();

            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x028), ReversePrism.DataModels.IResourceTag.FromPointer); // 027004FB9750 0x28 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.IsGiveupResult                            = GetBool(new IntPtr(p + 0x030)); // 027004FB9770 0x30 IsGiveupResult              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
