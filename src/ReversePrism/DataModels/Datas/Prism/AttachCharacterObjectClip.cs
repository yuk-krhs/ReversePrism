using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                00018670F800 ModelClassType AttachCharacterObjectBehaviour AttachCharacterObjectBehaviour AttachCharacterObjectBehaviour Pointer
    public partial class AttachCharacterObjectClip
    {
        public AttachCharacterObjectBehaviour?          Behaviour                               { get; set; }

        public static AttachCharacterObjectClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttachCharacterObjectClip();

            value.Behaviour                                 = GetObject<AttachCharacterObjectBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.AttachCharacterObjectBehaviour.FromPointer); // 0270D4DFD1B0 0x18 Behaviour                   ( 00018670F800 ModelClassType AttachCharacterObjectBehaviour AttachCharacterObjectBehaviour AttachCharacterObjectBehaviour Pointer )

            return value;
        }
    }
}
