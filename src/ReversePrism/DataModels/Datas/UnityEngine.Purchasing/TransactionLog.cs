using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Logger                                   ModelClassType ILogger ILogger ILogger Pointer
    // 018 PersistentDataPath                       ModelPrimitiveType string string string String
    public partial class TransactionLog : DataModel
    {
        public ILogger?                                 Logger                                  { get; set; }
        public string                                   PersistentDataPath                      { get; set; }

        public static TransactionLog? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransactionLog() { Pointer= p0 };

            value.Logger                                    = GetObject<ILogger>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILogger.FromPointer); // 0x10 Logger                      ( ModelClassType ILogger ILogger ILogger Pointer )
            value.PersistentDataPath                        = GetString(new IntPtr(p + 0x018)); // 0x18 PersistentDataPath          ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
