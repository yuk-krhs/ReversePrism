using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Present                                  0001865DD8A0 ModelClassType IPresentStatus IPresentStatus IPresentStatus Pointer
    // 018 ReceiveTime                              0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 HasLimit                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class PresentBoxListViewModel
    {
        public IPresentStatus?                          Present                                 { get; set; }
        public DateTime                                 ReceiveTime                             { get; set; }
        public bool                                     HasLimit                                { get; set; }

        public static PresentBoxListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PresentBoxListViewModel();

            value.Present                                   = GetObject<IPresentStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPresentStatus.FromPointer); // 0270D6440498 0x10 Present                     ( 0001865DD8A0 ModelClassType IPresentStatus IPresentStatus IPresentStatus Pointer )
            value.ReceiveTime                               = GetDateTime(new IntPtr(p + 0x018)); // 0270D64404B8 0x18 ReceiveTime                 ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.HasLimit                                  = GetBool(new IntPtr(p + 0x020)); // 0270D64404D8 0x20 HasLimit                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
