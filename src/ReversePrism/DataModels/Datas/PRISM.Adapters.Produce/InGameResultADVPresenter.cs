using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AdvView                                  ModelClassType IInGameResultADVView IInGameResultADVView IInGameResultADVView Pointer
    // 018 Model3dLoader                            ModelClassType IModel3dLoaderForProduceInGameResult IModel3dLoaderForProduceInGameResult IModel3dLoaderForProduceInGameResult Pointer
    public partial class InGameResultADVPresenter : DataModel
    {
        public IInGameResultADVView?                    AdvView                                 { get; set; }
        public IModel3dLoaderForProduceInGameResult?    Model3dLoader                           { get; set; }

        public static InGameResultADVPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameResultADVPresenter() { Pointer= p0 };

            value.AdvView                                   = GetObject<IInGameResultADVView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IInGameResultADVView.FromPointer); // 0x10 AdvView                     ( ModelClassType IInGameResultADVView IInGameResultADVView IInGameResultADVView Pointer )
            value.Model3dLoader                             = GetObject<IModel3dLoaderForProduceInGameResult>(new IntPtr(p + 0x018), ReversePrism.DataModels.IModel3dLoaderForProduceInGameResult.FromPointer); // 0x18 Model3dLoader               ( ModelClassType IModel3dLoaderForProduceInGameResult IModel3dLoaderForProduceInGameResult IModel3dLoaderForProduceInGameResult Pointer )

            return value;
        }
    }
}
