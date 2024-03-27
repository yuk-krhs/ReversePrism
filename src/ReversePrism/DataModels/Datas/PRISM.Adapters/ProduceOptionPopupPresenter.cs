using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865EEDC0 ModelClassType IProduceOptionPopupView IProduceOptionPopupView IProduceOptionPopupView Pointer
    // 018 Option                                   000186561420 ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer
    public partial class ProduceOptionPopupPresenter
    {
        public IProduceOptionPopupView?                 View                                    { get; set; }
        public ProduceOptionSaveData?                   Option                                  { get; set; }

        public static ProduceOptionPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceOptionPopupPresenter();

            value.View                                      = GetObject<IProduceOptionPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceOptionPopupView.FromPointer); // 0270D651AD40 0x10 View                        ( 0001865EEDC0 ModelClassType IProduceOptionPopupView IProduceOptionPopupView IProduceOptionPopupView Pointer )
            value.Option                                    = GetObject<ProduceOptionSaveData>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceOptionSaveData.FromPointer); // 0270D651AD60 0x18 Option                      ( 000186561420 ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer )

            return value;
        }
    }
}
