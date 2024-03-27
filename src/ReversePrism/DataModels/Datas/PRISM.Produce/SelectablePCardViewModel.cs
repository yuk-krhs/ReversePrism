using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceCard                              0001865E4D60 ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer
    // 018 State                                    00018675AEB0 ModelEnumType SelectState SelectState SelectState Int32
    public partial class SelectablePCardViewModel
    {
        public IProduceCardStatus?                      ProduceCard                             { get; set; }
        public SelectState                              State                                   { get; set; }

        public static SelectablePCardViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectablePCardViewModel();

            value.ProduceCard                               = GetObject<IProduceCardStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D5CBC7C0 0x10 ProduceCard                 ( 0001865E4D60 ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer )
            value.State                                     = (SelectState)GetInt32(new IntPtr(p + 0x018)); // 0270D5CBC7E0 0x18 State                       ( 00018675AEB0 ModelEnumType SelectState SelectState SelectState Int32 )

            return value;
        }
    }
}
