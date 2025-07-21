using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectCards                              ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 018 onUpdateSelectCards                      Subject`1<DeleteProduceCardPopupViewModel> IL2CPP_TYPE_GENERICINST
    // 020 MaxDeletableCardAmount                   ModelPrimitiveType int int int Int32
    // 028 <SelectablePCardViewModels>k__BackingField IList`1<SelectablePCardViewModel> IL2CPP_TYPE_GENERICINST
    public partial class DeleteProduceCardPopupViewModel : DataModel
    {
        public List<IProduceCardStatus>?                SelectCards                             { get; set; }
        public int                                      MaxDeletableCardAmount                  { get; set; }

        public static DeleteProduceCardPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeleteProduceCardPopupViewModel() { Pointer= p0 };

            value.SelectCards                               = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x10 SelectCards                 ( ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.MaxDeletableCardAmount                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 MaxDeletableCardAmount      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
