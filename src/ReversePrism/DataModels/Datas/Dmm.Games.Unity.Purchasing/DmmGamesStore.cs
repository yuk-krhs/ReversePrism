using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _g                                       GameObject IL2CPP_TYPE_CLASS
    // 008 _sdk                                     DmmGamesStoreSdk IL2CPP_TYPE_CLASS
    // 010 ResultLoginData                          0001865AFD10 ModelClassType ResultLoginData ResultLoginData ResultLoginData Pointer
    // 018 _resultAction                            Action`1<ResultLoginData> IL2CPP_TYPE_GENERICINST
    // 020 IsInit                                   000186595C30 ModelPrimitiveType bool bool bool Bool
    public partial class DmmGamesStore : DataModel
    {
        public ResultLoginData?                         ResultLoginData                         { get; set; }
        public bool                                     IsInit                                  { get; set; }

        public static DmmGamesStore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DmmGamesStore() { Pointer= p0 };

            value.ResultLoginData                           = GetObject<ResultLoginData>(new IntPtr(p + 0x010), ReversePrism.DataModels.ResultLoginData.FromPointer); // 02466B50E558 0x10 ResultLoginData             ( 0001865AFD10 ModelClassType ResultLoginData ResultLoginData ResultLoginData Pointer )
            value.IsInit                                    = GetBool(new IntPtr(p + 0x020)); // 02466B50E598 0x20 IsInit                      ( 000186595C30 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
