using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceCard                              ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer
    // 018 State                                    ModelEnumType SelectState SelectState SelectState Int32
    public partial class SelectablePCardViewModel : DataModel
    {
        public IProduceCardStatus?                      ProduceCard                             { get; set; }
        public SelectState                              State                                   { get; set; }

        public static SelectablePCardViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectablePCardViewModel() { Pointer= p0 };

            value.ProduceCard                               = GetObject<IProduceCardStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x10 ProduceCard                 ( ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer )
            value.State                                     = (SelectState)GetInt32(new IntPtr(p + 0x018)); // 0x18 State                       ( ModelEnumType SelectState SelectState SelectState Int32 )

            return value;
        }
    }
}
