using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseUrl                                  000186672F10 ModelPrimitiveType string string string String
    // 018 progress                                 IProgress`1<float> IL2CPP_TYPE_GENERICINST
    // 020 next                                     Func`3<RequestContext, CancellationToken, UniTask`1<ResponseContext>> IL2CPP_TYPE_GENERICINST
    // 028 Decorators                               000185B85A60 ModelClassListType IAsyncDecorator[] IAsyncDecorator[] List<IAsyncDecorator> Pointer
    // 030 CurrentWebRequest                        00018672DF10 ModelClassType UnityWebRequest UnityWebRequest UnityWebRequest Pointer
    public partial class UnityWebRequestClient : DataModel
    {
        public string                                   BaseUrl                                 { get; set; }
        public List<IAsyncDecorator>?                   Decorators                              { get; set; }
        public UnityWebRequest?                         CurrentWebRequest                       { get; set; }

        public static UnityWebRequestClient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityWebRequestClient() { Pointer= p0 };

            value.BaseUrl                                   = GetString(new IntPtr(p + 0x010)); // 0245A4E4E9D8 0x10 BaseUrl                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.Decorators                                = GetObjectList<IAsyncDecorator>(new IntPtr(p + 0x028), ReversePrism.DataModels.IAsyncDecorator.FromPointer); // 0245A4E4EA38 0x28 Decorators                  ( 000185B85A60 ModelClassListType IAsyncDecorator[] IAsyncDecorator[] List<IAsyncDecorator> Pointer )
            value.CurrentWebRequest                         = GetObject<UnityWebRequest>(new IntPtr(p + 0x030), ReversePrism.DataModels.UnityWebRequest.FromPointer); // 0245A4E4EA58 0x30 CurrentWebRequest           ( 00018672DF10 ModelClassType UnityWebRequest UnityWebRequest UnityWebRequest Pointer )

            return value;
        }
    }
}
