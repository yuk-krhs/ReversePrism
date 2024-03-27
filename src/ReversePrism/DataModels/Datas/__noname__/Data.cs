using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Phase                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Sequence                                 0001866809B0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    public partial class Data
    {
        public int                                      Phase                                   { get; set; }
        public ITutorialSequence?                       Sequence                                { get; set; }

        public static Data? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Data();

            value.Phase                                     = GetInt32(new IntPtr(p + 0x010)); // 0270DBC10450 0x10 Phase                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Sequence                                  = GetObject<ITutorialSequence>(new IntPtr(p + 0x018), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0270DBC10470 0x18 Sequence                    ( 0001866809B0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )

            return value;
        }
    }
}
