using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   ModelClassType IDirectMessageStatus IDirectMessageStatus IDirectMessageStatus Pointer
    // 018 IsNewReactiveProperty                    ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 020 Date                                     ModelPrimitiveType string string string String
    public partial class DirectMessageItemViewModel : DataModel
    {
        public IDirectMessageStatus?                    Status                                  { get; set; }
        public BoolReactiveProperty?                    IsNewReactiveProperty                   { get; set; }
        public string                                   Date                                    { get; set; }

        public static DirectMessageItemViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectMessageItemViewModel() { Pointer= p0 };

            value.Status                                    = GetObject<IDirectMessageStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDirectMessageStatus.FromPointer); // 0x10 Status                      ( ModelClassType IDirectMessageStatus IDirectMessageStatus IDirectMessageStatus Pointer )
            value.IsNewReactiveProperty                     = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x18 IsNewReactiveProperty       ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.Date                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Date                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
