using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProduceCardContent                       0001865353C0 ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer
    // 028 SelectFrame                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 CurrentState                             00018675AEB0 ModelEnumType SelectState SelectState SelectState Int32
    public partial class SelectableProduceCardContent : DataModel
    {
        public ProduceCardContent?                      ProduceCardContent                      { get; set; }
        public GameObject?                              SelectFrame                             { get; set; }
        public SelectState                              CurrentState                            { get; set; }

        public static SelectableProduceCardContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectableProduceCardContent() { Pointer= p0 };

            value.ProduceCardContent                        = GetObject<ProduceCardContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 024665D2A6C0 0x20 ProduceCardContent          ( 0001865353C0 ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer )
            value.SelectFrame                               = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 024665D2A6E0 0x28 SelectFrame                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CurrentState                              = (SelectState)GetInt32(new IntPtr(p + 0x030)); // 024665D2A700 0x30 CurrentState                ( 00018675AEB0 ModelEnumType SelectState SelectState SelectState Int32 )

            return value;
        }
    }
}
