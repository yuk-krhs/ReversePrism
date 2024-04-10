using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 streamTimeout                            int IL2CPP_TYPE_I4
    // 000 clientType                               ClientType IL2CPP_TYPE_VALUETYPE
    // 020 GeneratedPrismViews                      000185CFB0D8 ModelClassListType List`1<PrismView> List`1<PrismView> List<PrismView> Pointer
    // 028 IsConnecting                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 reconnectingSubject                      Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 008 prismStream                              PrismStream IL2CPP_TYPE_CLASS
    // 038 IsLoadReceiveDataCompleted               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PrismStreaming : DataModel
    {
        public List<PrismView>?                         GeneratedPrismViews                     { get; set; }
        public bool                                     IsConnecting                            { get; set; }
        public bool                                     IsLoadReceiveDataCompleted              { get; set; }

        public static PrismStreaming? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismStreaming() { Pointer= p0 };

            value.GeneratedPrismViews                       = GetObjectList<PrismView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PrismView.FromPointer); // 024664F88480 0x20 GeneratedPrismViews         ( 000185CFB0D8 ModelClassListType List`1<PrismView> List`1<PrismView> List<PrismView> Pointer )
            value.IsConnecting                              = GetBool(new IntPtr(p + 0x028)); // 024664F884A0 0x28 IsConnecting                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLoadReceiveDataCompleted                = GetBool(new IntPtr(p + 0x038)); // 024664F88500 0x38 IsLoadReceiveDataCompleted  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
