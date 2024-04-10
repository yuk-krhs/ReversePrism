using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 currentValue                             ReactiveProperty`1<int> IL2CPP_TYPE_GENERICINST
    // 018 Type                                     00018661DC60 ModelEnumType StaminaType StaminaType StaminaType Int32
    // 01C MaxValue                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 RecoveryTime                             0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 RecoveryInterval                         0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class StaminaModel : DataModel
    {
        public StaminaType                              Type                                    { get; set; }
        public int                                      MaxValue                                { get; set; }
        public DateTime                                 RecoveryTime                            { get; set; }
        public int                                      RecoveryInterval                        { get; set; }

        public static StaminaModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaModel() { Pointer= p0 };

            value.Type                                      = (StaminaType)GetInt32(new IntPtr(p + 0x018)); // 0245A4AECE08 0x18 Type                        ( 00018661DC60 ModelEnumType StaminaType StaminaType StaminaType Int32 )
            value.MaxValue                                  = GetInt32(new IntPtr(p + 0x01C)); // 0245A4AECE28 0x1C MaxValue                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RecoveryTime                              = GetDateTime(new IntPtr(p + 0x020)); // 0245A4AECE48 0x20 RecoveryTime                ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.RecoveryInterval                          = GetInt32(new IntPtr(p + 0x028)); // 0245A4AECE68 0x28 RecoveryInterval            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
