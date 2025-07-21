using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ValueStates                              State IL2CPP_TYPE_VALUETYPE
    // 020 containerStack                           Stack`1<ContainerType> IL2CPP_TYPE_GENERICINST
    // 028 Reader                                   ModelClassType PushBackReader PushBackReader PushBackReader Pointer
    // 030 State                                    ModelEnumType State State State Int32
    public partial class JsonTextTokenizer : DataModel
    {
        public PushBackReader?                          Reader                                  { get; set; }
        public State                                    State                                   { get; set; }

        public static JsonTextTokenizer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonTextTokenizer() { Pointer= p0 };

            value.Reader                                    = GetObject<PushBackReader>(new IntPtr(p + 0x028), ReversePrism.DataModels.PushBackReader.FromPointer); // 0x28 Reader                      ( ModelClassType PushBackReader PushBackReader PushBackReader Pointer )
            value.State                                     = (State)GetInt32(new IntPtr(p + 0x030)); // 0x30 State                       ( ModelEnumType State State State Int32 )

            return value;
        }
    }
}
