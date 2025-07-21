using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Phase                                    ModelPrimitiveType int int int Int32
    // 018 Sequence                                 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    public partial class Data : DataModel
    {
        public int                                      Phase                                   { get; set; }
        public ITutorialSequence?                       Sequence                                { get; set; }

        public static Data? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Data() { Pointer= p0 };

            value.Phase                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Phase                       ( ModelPrimitiveType int int int Int32 )
            value.Sequence                                  = GetObject<ITutorialSequence>(new IntPtr(p + 0x018), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0x18 Sequence                    ( ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )

            return value;
        }
    }
}
