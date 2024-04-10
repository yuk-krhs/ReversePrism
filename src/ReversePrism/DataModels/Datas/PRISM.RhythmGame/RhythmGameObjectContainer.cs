using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 notes                                    Dictionary`2<int, NoteBase> IL2CPP_TYPE_GENERICINST
    // 028 noteLines                                Dictionary`2<int, NoteLine> IL2CPP_TYPE_GENERICINST
    // 030 simultaneousLines                        Dictionary`2<int, SimultaneousLine> IL2CPP_TYPE_GENERICINST
    public partial class RhythmGameObjectContainer : DataModel
    {

        public static RhythmGameObjectContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameObjectContainer() { Pointer= p0 };


            return value;
        }
    }
}
